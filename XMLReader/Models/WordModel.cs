using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XMLReader.Models
{
    public class WordModel
    {
        public string text { get; set; }
        public int count { get; set; }

        public string book;
        public WordModel() 
        {
            book = "Moby Dick";
        }
    }
}