using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XMLReader.Models;

namespace XMLReader.Controllers
{
    public class WordController : Controller
    {
        // GET: Word
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var data = new List<WordModel>();
            data = ReturnData();
            return View(data);
        }

        public List<WordModel> ReturnData()
        {
            string xmldata = Server.MapPath("~/XMLFile/Words.xml");
            DataSet ds = new DataSet();

            ds.ReadXml(xmldata);

            var wordlist = new List<WordModel>();
            wordlist = (from rows in ds.Tables[0].AsEnumerable()
                        select new WordModel
                        {
                            text = rows[0].ToString(),
                            count = Convert.ToInt32(rows[1].ToString()),

                        }).ToList();

            return wordlist;
        }
    }
}