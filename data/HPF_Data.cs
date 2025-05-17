using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMO_Helper.data
{
    internal class fanfiction_stories
    {
        public int sid { get; set; }
        public string title { get; set; }
        public string summary { get; set; }
        public string storynotes { get; set; }
        public string catid { get; set; }
        public string classes { get; set; }
        public string charid { get; set; }
        public string rid { get; set; }
        public DateTime date { get; set; }
        public DateTime updated { get; set; }
        public int uid { get; set; }
        public string coauthors { get; set; }
        public short featured { get; set; }
        public short validated { get; set; }
        public short completed { get; set; }
        public short rr { get; set; }
        public int wordcount { get; set; }
        public short rating { get; set; }
        public short reviews { get; set; }
        public int count { get; set; }
        public string challenges { get; set; }
    }

    internal class fanfiction_chapters
    {
        public int chapid { get; set; }
        public string title { get; set; }
        public int inorder { get; set; }
        public string notes { get; set; }
        public string storytext { get; set; }
        public string endnotes { get; set; }
        public short validated { get; set; }
        public int wordcount { get; set; }
        public short rating { get; set; }
        public short reviews { get; set; }
        public int sid { get; set; }
        public int uid { get; set; }
        public int count { get; set; }
    }

    internal class fanfiction_authors
    {
        public int uid { get; set; }
        public string penname { get; set; }
        public string realname { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string bio { get; set; }
        public string image { get; set; }
        public DateTime date { get; set; }
        public string password { get; set; }
        public string pic { get; set; }
        public string da { get; set; }
        public string ffn { get; set; }
        public int gender { get; set; }
    }

    internal class fanfiction_classes
    {
        public int class_id { get; set; }
        public int class_type { get; set; }
        public string class_name { get; set; }
    }
}
