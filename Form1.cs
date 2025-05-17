using GMO_Helper.data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace GMO_Helper
{
    public partial class Form1 : Form
    {
        private MySqlConnection mySqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.TxtLog.Clear();
            string connectionStringMySQL = "SERVER=" + this.TxtDbUrl.Text + ";" + "DATABASE=" + this.TxtDbCatalog.Text + ";" + "UID=" + this.TxtDbUsername.Text + ";" + "PASSWORD=" + this.TxtDbPassword.Text + ";" + "PORT=" + this.TxtDbPort.Text + ";";
            this.mySqlConnection = new MySqlConnection(connectionStringMySQL);
            try
            {
                this.mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw;
            }

            if (!System.IO.Directory.Exists(this.TxtFolderStories.Text)) return;
            if (!System.IO.File.Exists(this.TxtInputFile.Text)) return;

            this.TxtLog.AppendText("Vérifications OK." + "\r\n");
            this.TxtLog.Select(0, 1);
            this.TxtLog.ScrollToCaret();
            this.mySqlConnection.Close();
            this.btnGo.Enabled = true;
        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            this.btnCheck.Enabled = false;
            this.btnGo.Enabled = false;
            Application.DoEvents();
            this.mySqlConnection.Open();

            // Charger les fanfiction_classes en mémoire ici
            List<fanfiction_classes> classes = new List<fanfiction_classes>();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.mySqlConnection;
                cmd.CommandText = @"SELECT * FROM fanfiction_classes";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fanfiction_classes record = new fanfiction_classes();
                        MapDataToClass(reader, record);
                        classes.Add(record);
                    }
                }
            }
            // Id des classes de type "Genre"
            string[] genresIds = classes.Where(t => t.class_type == 1).Select(t => t.class_id.ToString()).ToArray();
            string[] warningIds = classes.Where(t => t.class_type == 2).Select(t => t.class_id.ToString()).ToArray();


            StringBuilder result = new StringBuilder();
            // Header - IdAuteur, Auteur, IdFiction, Fiction, IdChapitre, Chapitre, Date de création, date de dernière écriture, nombre de mots, entre 110 et 185 mots, entre 215 et 499 mots Lien direct

            result.AppendLine("Id Auteur;Nom auteur;Id Fiction;Titre fiction;Lemon hard; Scènes gores;Présence d'un warning;Genres > " + this.NumGenres.Value.ToString() + ";Persos > " +this.NumPersos.Value.ToString() + ";Catégories > " + this.NumCat.Value.ToString() + ";-18 manquant;-16 manquant;Nb images mauvaise taille résumé;Nb images mauvaise taille notes fiction;Id Chapitre;Titre chapitre;Date de création chapitre;Date dernière écriture chapitre;Nombre de mots;[110,185];[215,499];Nb images mauvaise taille notes début;Nb images mauvaise taille notes fin;Images directement dans le chapitre;Présence de mot surveillé;Lien direct");

            //
            foreach (var line in System.IO.File.ReadAllLines(this.TxtInputFile.Text))
            {
                if (line.StartsWith("pseudo;")) continue;

                string[] split = line.Split(';');

                // Déjà traité
                if (split[4] == "1") continue;

                //DateTime dateStart = DateTime.Parse(split[2]);
                DateTime dateStart = DateTime.Parse("01/04/2020");
                //DateTime dateEnd = DateTime.Parse(split[3]);
                DateTime dateEnd = DateTime.Parse("01/04/2024");
                // Rechercher les chapitres modifiés de cet utilisateur en se basant sur les dates des fichiers,
                // puisqu'il n'y a pas d'information sur les dates des chapitres directement
                var chapterFolderPath = System.IO.Path.Combine(this.TxtFolderStories.Text, split[1]);
                DirectoryInfo di = new DirectoryInfo(chapterFolderPath);
                if (di.Exists == false)
                {
                    // Logger l'erreur 
                    continue;
                }

                var chaptersToCheck = di.GetFiles("*.txt").Where(t => (t.CreationTime >= dateStart && t.CreationTime <= dateEnd) || (t.LastWriteTime >= dateStart && t.LastWriteTime <= dateEnd));
                if(chaptersToCheck.Any())
                {
                    // Charger les données de l'auteur
                    fanfiction_authors author = null;
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = this.mySqlConnection;
                        cmd.CommandText = @"SELECT * FROM fanfiction_authors WHERE fanfiction_authors.uid = "+ split[1];
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                author = new fanfiction_authors();
                                MapDataToClass(reader, author);
                            }
                        }
                    }

                    // Charger les metadonnées des chapitres
                    int[] chaptersIds = chaptersToCheck.Select(t => int.Parse(System.IO.Path.GetFileNameWithoutExtension(t.Name))).ToArray();
                    List<fanfiction_chapters> chapters = new List<fanfiction_chapters>();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = this.mySqlConnection;
                        cmd.CommandText = @"SELECT * FROM fanfiction_chapters WHERE fanfiction_chapters.chapid in (" + string.Join(",", chaptersIds.Select(t=>t.ToString())) + ")";
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                fanfiction_chapters record = new fanfiction_chapters();
                                MapDataToClass(reader, record);
                                chapters.Add(record);
                            }
                        }
                    }

                    // Charger les fictions liées à ces chapitres
                    int[] storiesIds = chapters.Select(t=>t.sid).GroupBy(t=>t).Select(t=>t.Key).ToArray();
                    List<fanfiction_stories> stories = new List<fanfiction_stories>();
                    using(MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = this.mySqlConnection;
                        cmd.CommandText = @"SELECT * FROM fanfiction_stories WHERE fanfiction_stories.uid = @uid and (fanfiction_stories.sid in (" + string.Join(",", storiesIds.Select(t => t.ToString())) + ") " +
                            "or (fanfiction_stories.updated >= @fromDate and fanfiction_stories.updated <= @untilDate))";
                        cmd.Parameters.AddWithValue("@uid", split[1]);
                        cmd.Parameters.AddWithValue("@fromDate", dateStart);
                        cmd.Parameters.AddWithValue("@untilDate", dateEnd);
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        { 
                            while (reader.Read())
                            {
                                fanfiction_stories record = new fanfiction_stories();
                                MapDataToClass(reader, record);
                                stories.Add(record);
                            }
                        }
                    }


                    // Pour chacun de ces chapitres les lister (groupés par fictions)
                    foreach (fanfiction_stories story in stories.OrderBy(t=>t.title))
                    {
                        // Vérifications sur la fiction
                        // Contient-elle des images hors dimensions
                        int wrongImageSummary = 0;
                        int wrongImageStorynote = 0;
                        if (this.ChkFictionImages.Checked)
                        {
                            // Dans le résumé
                            wrongImageSummary = await CheckForWrongImages(story.summary, (int)this.numMaxWidth.Value, (int)this.numMaxHeight.Value);
                            // Dans les notes d'histoires
                            wrongImageStorynote = await CheckForWrongImages(story.storynotes, (int)this.numMaxWidth.Value, (int)this.numMaxHeight.Value);
                        }

                        string[] ffCatid = (string.IsNullOrWhiteSpace(story.catid) == false) ? story.catid.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) : new string[] { };
                        string[] ffClasses = (string.IsNullOrWhiteSpace(story.classes) == false) ? story.classes.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) : new string[] { };
                        int nbGenres = ffClasses.Count(t => genresIds.Contains(t));
                        string[] ffCharid = (string.IsNullOrWhiteSpace(story.charid) == false) ? story.charid.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) : new string[] { };

                        bool warningLemonHardMissing = ffClasses.Any(t => t == "11" || t == "12") && story.rid != "4";
                        bool warningLemonSoftMissing = ffClasses.Any(t => t == "11" || t == "12") == false && ffClasses.Any(t => t == "10") && story.rid != "3";

                        // Il n'y pas forcément de chapitre parfois (changement seulement sur la fiction)
                        if (chapters.Any(t => t.sid == story.sid))
                        {
                            foreach (var chapter in chapters.Where(t => t.sid == story.sid))
                            {
                                int wrongImageStartNotes = 0;
                                int wrongImageEndNotes = 0;
                                if (this.ChkChapterImages.Checked)
                                {
                                    // Note de début
                                    wrongImageSummary = await CheckForWrongImages(chapter.notes, (int)this.numMaxWidth.Value, (int)this.numMaxHeight.Value);
                                    // note de fin
                                    wrongImageStorynote = await CheckForWrongImages(chapter.endnotes, (int)this.numMaxWidth.Value, (int)this.numMaxHeight.Value);
                                }

                                FileInfo fi = chaptersToCheck.FirstOrDefault(t => System.IO.Path.GetFileNameWithoutExtension(t.Name) == chapter.chapid.ToString());

                                string chapterContent = null;
                                // Présence d'une image dans le chapitre
                                int nbImgInChapter = 0;
                                if (this.ChkChapterImagesIntext.Checked)
                                {
                                    if (string.IsNullOrWhiteSpace(chapterContent)) chapterContent = System.IO.File.ReadAllText(fi.FullName, Encoding.UTF8);
                                    nbImgInChapter = Regex.Matches(chapterContent, "<img ").Count;
                                }

                                bool containsBanWord = false;
                                if (this.ChkChapterContent.Checked)
                                {

                                    string[] banWords = this.TxtWordsToLookFor.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                                    if (banWords.Length > 0)
                                    {
                                        if (string.IsNullOrWhiteSpace(chapterContent)) chapterContent = System.IO.File.ReadAllText(fi.FullName, Encoding.UTF8);
                                        for (int i = 0; i < banWords.Length; i++)
                                        {
                                            containsBanWord |= Regex.IsMatch(chapterContent, "\\b" + banWords[i] + "\\b", RegexOptions.IgnoreCase);
                                        }
                                    }
                                }

                                result.AppendLine(author.uid + ";" + author.penname.Replace(";", "") + ";" + story.sid + ";" + story.title.Replace(";", "") + ";" + (ffClasses.Any(t => t == "11") ? "Y" : "N") + ";" + (ffClasses.Any(t => t == "12") ? "Y" : "N") + ";" + (ffClasses.Any(t=> warningIds.Contains(t)) ? "Y" : "N") + ";"+ (nbGenres > this.NumGenres.Value ? "Y" : "N") + ";" + (ffCharid.Count() > this.NumPersos.Value ? "Y" : "N") + ";" + (ffCatid.Count() > this.NumCat.Value ? "Y" : "N") + ";" + (warningLemonHardMissing ? "Y" : "N") + ";" + (warningLemonSoftMissing ? "Y" : "N") + ";" + wrongImageSummary.ToString() + ";" + wrongImageStorynote.ToString() + ";" + chapter.chapid + ";" + chapter.title.Replace(";", "") + ";" + fi.CreationTime.ToShortDateString() + ";" + fi.LastWriteTime.ToShortDateString() + ";" + chapter.wordcount.ToString() + ";" + ((chapter.wordcount >= 110 && chapter.wordcount <= 185) ? "Y" : "N") + ";" + ((chapter.wordcount >= 215 && chapter.wordcount <= 499) ? "Y" : "N") + ";" + wrongImageStartNotes.ToString() + ";" + wrongImageEndNotes + ";" + nbImgInChapter + ";" + (containsBanWord ? "Y" : "N") + ";" + string.Format(@"https://www.hpfanfiction.org/fr/viewstory.php?sid={0}&textsize=0&chapter={1}", story.sid.ToString(), chapter.inorder));
                            }
                        }
                        else
                        {
                            result.AppendLine(author.uid + ";" + author.penname.Replace(";", "") + ";" + story.sid + ";" + story.title.Replace(";", "") + ";" + (ffClasses.Any(t => t == "11") ? "Y" : "N") + ";" + (ffClasses.Any(t => t == "12") ? "Y" : "N") + ";" + (ffClasses.Any(t => warningIds.Contains(t)) ? "Y" : "N") + ";" +(nbGenres > this.NumGenres.Value ? "Y" : "N") + ";" + (ffCharid.Count() > this.NumPersos.Value ? "Y" : "N") + ";" + (ffCatid.Count() > this.NumCat.Value ? "Y" : "N") + ";" + (warningLemonHardMissing ? "Y" : "N") + ";" + (warningLemonSoftMissing ? "Y" : "N") + ";" + wrongImageSummary.ToString() + ";" + wrongImageStorynote.ToString() + ";N/A;N/A;N/A;N/A;N/A;N/A;N/A;N/A;N/A;N/A;N/A;N/A");
                        }
                        Application.DoEvents();
                    }
                }
            }

            System.IO.File.WriteAllText("output.csv", result.ToString(), Encoding.UTF8);
            this.mySqlConnection.Close();

            this.TxtLog.Clear();
            this.TxtLog.AppendText("Succès !");
            this.btnCheck.Enabled = true;
            this.btnGo.Enabled = true;
        }

        private async Task<int> CheckForWrongImages(string text, int maxWidth, int maxHeight)
        {
            int result = 0;
            if (string.IsNullOrWhiteSpace(text) == false && text.Contains("<img"))
            {
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(text);
                // Trouver toutes les balises <img>
                var images = doc.DocumentNode.SelectNodes("//img");

                if (images != null)
                {
                    foreach (var img in images)
                    {
                        string src = img.GetAttributeValue("src", null);
                        if (string.IsNullOrEmpty(src))
                        {
                            continue;
                        }

                        // Vérification des dimensions
                        int width = img.GetAttributeValue("width", 0);
                        int height = img.GetAttributeValue("height", 0);

                        if (width > 0 && height > 0)
                        {
                            if ((width <= maxWidth && height <= maxHeight)
                                || (width <= maxHeight && height <= maxWidth))
                            {
                                // Ok c'est bon
                            }
                            else
                            {
                                result++;
                            }
                        }
                        else
                        {
                            if (await IsImageWrongSize(src)) result++;
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Data to class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="instance"></param>
        private void MapDataToClass<T>(MySqlDataReader reader, T instance)
        {
            // Obtient toutes les propriétés de la classe T
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                // Vérifie si la propriété correspond à une colonne dans le DataReader
                if (reader.HasColumn(property.Name) && !reader.IsDBNull(reader.GetOrdinal(property.Name)))
                {
                    // Obtient la valeur de la colonne et la convertit au type de la propriété
                    object value = reader.GetValue(reader.GetOrdinal(property.Name));
                    property.SetValue(instance, Convert.ChangeType(value, property.PropertyType));
                }
            }
        }

        private async Task<bool> IsImageWrongSize(string imageUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(imageUrl))
                {
                    response.EnsureSuccessStatusCode();

                    using (Stream stream = await response.Content.ReadAsStreamAsync())
                    using (Image img = Image.FromStream(stream))
                    {
                        int actualWidth = img.Width;
                        int actualHeight = img.Height;

                        if ((actualWidth <= this.numMaxWidth.Value && actualHeight <= this.numMaxHeight.Value)
                        || (actualWidth <= this.numMaxHeight.Value && actualHeight <= this.numMaxWidth.Value))
                        {
                            // Ok c'est bon
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Un erreur s'est produite, l'image n'est pas disponible
                return false;
            }
        }
    }

    // Extension method to check if a column exists in the DataReader
    public static class DataReaderExtensions
    {
        public static bool HasColumn(this MySqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
