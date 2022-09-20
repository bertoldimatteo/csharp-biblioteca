using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {
        public int code { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string typo { get; set; }
        public bool status { get; set; }
        public string position { get; set; }
        public string author { get; set; }

        public Document(string title, int year, string typo, string author)
        {
            this.title = title;
            this.year = year;
            this.typo = typo;
            this.author = author;
        }

        public Document(string stringCode, string title, int year, string typo, string author)
        {
            this.code = new Random().Next();
            this.title = title;
            this.year = year;
            this.typo = typo;
            this.author = author;
        }
    }
}
