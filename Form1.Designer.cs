namespace GMO_Helper
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDbPort = new System.Windows.Forms.TextBox();
            this.TxtFolderStories = new System.Windows.Forms.TextBox();
            this.TxtDbUrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDbCatalog = new System.Windows.Forms.TextBox();
            this.TxtDbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDbUsername = new System.Windows.Forms.TextBox();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInputFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numMaxWidth = new System.Windows.Forms.NumericUpDown();
            this.numMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ChkFictionImages = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ChkChapterImages = new System.Windows.Forms.CheckBox();
            this.ChkChapterImagesIntext = new System.Windows.Forms.CheckBox();
            this.NumGenres = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NumPersos = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.NumCat = new System.Windows.Forms.NumericUpDown();
            this.ChkChapterContent = new System.Windows.Forms.CheckBox();
            this.TxtWordsToLookFor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPersos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtDbPort);
            this.groupBox1.Controls.Add(this.TxtFolderStories);
            this.groupBox1.Controls.Add(this.TxtDbUrl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtDbCatalog);
            this.groupBox1.Controls.Add(this.TxtDbPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtDbUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serveur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DbCatalog";
            // 
            // TxtDbPort
            // 
            this.TxtDbPort.Location = new System.Drawing.Point(284, 32);
            this.TxtDbPort.Name = "TxtDbPort";
            this.TxtDbPort.Size = new System.Drawing.Size(101, 20);
            this.TxtDbPort.TabIndex = 4;
            this.TxtDbPort.Text = "3306";
            // 
            // TxtFolderStories
            // 
            this.TxtFolderStories.Location = new System.Drawing.Point(9, 136);
            this.TxtFolderStories.Name = "TxtFolderStories";
            this.TxtFolderStories.Size = new System.Drawing.Size(379, 20);
            this.TxtFolderStories.TabIndex = 0;
            this.TxtFolderStories.Text = "V:\\BackupHPF\\14052025\\250514_ 445_hpfic_full\\250514_ 445_hpfic\\fr\\stories\\";
            // 
            // TxtDbUrl
            // 
            this.TxtDbUrl.Location = new System.Drawing.Point(150, 32);
            this.TxtDbUrl.Name = "TxtDbUrl";
            this.TxtDbUrl.Size = new System.Drawing.Size(128, 20);
            this.TxtDbUrl.TabIndex = 4;
            this.TxtDbUrl.Text = "127.0.0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Dossier stories du serveur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DbPort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "DbUsername";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DbUrl";
            // 
            // TxtDbCatalog
            // 
            this.TxtDbCatalog.Location = new System.Drawing.Point(9, 32);
            this.TxtDbCatalog.Name = "TxtDbCatalog";
            this.TxtDbCatalog.Size = new System.Drawing.Size(135, 20);
            this.TxtDbCatalog.TabIndex = 4;
            this.TxtDbCatalog.Text = "hpfanfiction_14052025";
            // 
            // TxtDbPassword
            // 
            this.TxtDbPassword.Location = new System.Drawing.Point(227, 82);
            this.TxtDbPassword.Name = "TxtDbPassword";
            this.TxtDbPassword.Size = new System.Drawing.Size(158, 20);
            this.TxtDbPassword.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "DbPassword";
            // 
            // TxtDbUsername
            // 
            this.TxtDbUsername.Location = new System.Drawing.Point(9, 82);
            this.TxtDbUsername.Name = "TxtDbUsername";
            this.TxtDbUsername.Size = new System.Drawing.Size(166, 20);
            this.TxtDbUsername.TabIndex = 4;
            this.TxtDbUsername.Text = "root";
            // 
            // TxtLog
            // 
            this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtLog.Location = new System.Drawing.Point(21, 407);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLog.Size = new System.Drawing.Size(379, 74);
            this.TxtLog.TabIndex = 10;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(296, 487);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(104, 45);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheck.Location = new System.Drawing.Point(21, 487);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 45);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Vérifier";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fichier d\'entrée";
            // 
            // TxtInputFile
            // 
            this.TxtInputFile.Location = new System.Drawing.Point(21, 195);
            this.TxtInputFile.Name = "TxtInputFile";
            this.TxtInputFile.Size = new System.Drawing.Size(379, 20);
            this.TxtInputFile.TabIndex = 0;
            this.TxtInputFile.Text = "input_prod.csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dimensions max image";
            // 
            // numMaxWidth
            // 
            this.numMaxWidth.Location = new System.Drawing.Point(138, 234);
            this.numMaxWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxWidth.Name = "numMaxWidth";
            this.numMaxWidth.Size = new System.Drawing.Size(66, 20);
            this.numMaxWidth.TabIndex = 11;
            this.numMaxWidth.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // numMaxHeight
            // 
            this.numMaxHeight.Location = new System.Drawing.Point(227, 234);
            this.numMaxHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxHeight.Name = "numMaxHeight";
            this.numMaxHeight.Size = new System.Drawing.Size(66, 20);
            this.numMaxHeight.TabIndex = 11;
            this.numMaxHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "*";
            // 
            // ChkFictionImages
            // 
            this.ChkFictionImages.AutoSize = true;
            this.ChkFictionImages.Checked = true;
            this.ChkFictionImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFictionImages.Location = new System.Drawing.Point(21, 260);
            this.ChkFictionImages.Name = "ChkFictionImages";
            this.ChkFictionImages.Size = new System.Drawing.Size(217, 17);
            this.ChkFictionImages.TabIndex = 12;
            this.ChkFictionImages.Text = "Vérifier la taille des images dans la fiction";
            this.ChkFictionImages.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "px";
            // 
            // ChkChapterImages
            // 
            this.ChkChapterImages.AutoSize = true;
            this.ChkChapterImages.Checked = true;
            this.ChkChapterImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChapterImages.Location = new System.Drawing.Point(21, 283);
            this.ChkChapterImages.Name = "ChkChapterImages";
            this.ChkChapterImages.Size = new System.Drawing.Size(276, 17);
            this.ChkChapterImages.TabIndex = 12;
            this.ChkChapterImages.Text = "Vérifier la taille des images dans les notes du chapitre";
            this.ChkChapterImages.UseVisualStyleBackColor = true;
            // 
            // ChkChapterImagesIntext
            // 
            this.ChkChapterImagesIntext.AutoSize = true;
            this.ChkChapterImagesIntext.Checked = true;
            this.ChkChapterImagesIntext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChapterImagesIntext.Location = new System.Drawing.Point(21, 306);
            this.ChkChapterImagesIntext.Name = "ChkChapterImagesIntext";
            this.ChkChapterImagesIntext.Size = new System.Drawing.Size(303, 17);
            this.ChkChapterImagesIntext.TabIndex = 12;
            this.ChkChapterImagesIntext.Text = "Vérifier la taille des images dans le chapitre (corps du texte)";
            this.ChkChapterImagesIntext.UseVisualStyleBackColor = true;
            // 
            // NumGenres
            // 
            this.NumGenres.Location = new System.Drawing.Point(111, 329);
            this.NumGenres.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumGenres.Name = "NumGenres";
            this.NumGenres.Size = new System.Drawing.Size(66, 20);
            this.NumGenres.TabIndex = 11;
            this.NumGenres.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nb genres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nb personnages";
            // 
            // NumPersos
            // 
            this.NumPersos.Location = new System.Drawing.Point(111, 355);
            this.NumPersos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumPersos.Name = "NumPersos";
            this.NumPersos.Size = new System.Drawing.Size(66, 20);
            this.NumPersos.TabIndex = 11;
            this.NumPersos.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nb catégories";
            // 
            // NumCat
            // 
            this.NumCat.Location = new System.Drawing.Point(111, 381);
            this.NumCat.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumCat.Name = "NumCat";
            this.NumCat.Size = new System.Drawing.Size(66, 20);
            this.NumCat.TabIndex = 11;
            this.NumCat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ChkChapterContent
            // 
            this.ChkChapterContent.AutoSize = true;
            this.ChkChapterContent.Checked = true;
            this.ChkChapterContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChapterContent.Location = new System.Drawing.Point(233, 327);
            this.ChkChapterContent.Name = "ChkChapterContent";
            this.ChkChapterContent.Size = new System.Drawing.Size(167, 17);
            this.ChkChapterContent.TabIndex = 12;
            this.ChkChapterContent.Text = "Vérifier le contenu du chapitre";
            this.ChkChapterContent.UseVisualStyleBackColor = true;
            // 
            // TxtWordsToLookFor
            // 
            this.TxtWordsToLookFor.Location = new System.Drawing.Point(232, 350);
            this.TxtWordsToLookFor.Multiline = true;
            this.TxtWordsToLookFor.Name = "TxtWordsToLookFor";
            this.TxtWordsToLookFor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtWordsToLookFor.Size = new System.Drawing.Size(168, 51);
            this.TxtWordsToLookFor.TabIndex = 14;
            this.TxtWordsToLookFor.Text = "pénis\r\nviol\r\nsang\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 537);
            this.Controls.Add(this.TxtWordsToLookFor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ChkChapterContent);
            this.Controls.Add(this.ChkChapterImagesIntext);
            this.Controls.Add(this.ChkChapterImages);
            this.Controls.Add(this.ChkFictionImages);
            this.Controls.Add(this.numMaxHeight);
            this.Controls.Add(this.NumCat);
            this.Controls.Add(this.NumPersos);
            this.Controls.Add(this.NumGenres);
            this.Controls.Add(this.numMaxWidth);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.TxtInputFile);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GMO Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPersos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDbPort;
        private System.Windows.Forms.TextBox TxtFolderStories;
        private System.Windows.Forms.TextBox TxtDbUrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDbCatalog;
        private System.Windows.Forms.TextBox TxtDbPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDbUsername;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMaxWidth;
        private System.Windows.Forms.NumericUpDown numMaxHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ChkFictionImages;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ChkChapterImages;
        private System.Windows.Forms.CheckBox ChkChapterImagesIntext;
        private System.Windows.Forms.NumericUpDown NumGenres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown NumPersos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NumCat;
        private System.Windows.Forms.CheckBox ChkChapterContent;
        private System.Windows.Forms.TextBox TxtWordsToLookFor;
    }
}

