using WordPlay.Shared.Repository;
using System.Web.Mvc;
using System.Linq;
using WordPlay.Shared;
using WordPlay.Shared.Models;
using System.Net.Mail;
using System.Net;
using System;
using System.Collections.Generic;

namespace WordPlaySyncService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            ViewBag.Title = "Home";

            var words = new List<string>();
            return View(words);
        }

        public ActionResult Browse()
        {
            ViewBag.Title = "Browse";
            ViewBag.TextBrowseWord = Request.QueryString["Lookup"] ?? "Hello";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.TextBrowseWord = Request.Form["TextBrowseWord"];
            }

            return View(WordRepository.BrowseWords(ViewBag.TextBrowseWord));
        }

        public ActionResult Translate()
        {
            ViewBag.Title = "Translate";
            ViewBag.TextBrowseWord = Request.QueryString["Lookup"] ?? "Hello";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.TextBrowseWord = Request.Form["TextBrowseWord"];
            }

            return View(WordRepository.Translate(ViewBag.TextBrowseWord));
        }

        public ActionResult SoundsLikeMetaphone()
        {
            ViewBag.Title = "SoundsLike (Metaphone)";
            ViewBag.TextBrowseWord = Request.QueryString["Lookup"] ?? "Hello";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.TextBrowseWord = Request.Form["TextBrowseWord"];
            }

            return View(WordRepository.SoundsLikeMetaphone(ViewBag.TextBrowseWord));
        }

        public ActionResult SoundsLikeDoubleMetaphone()
        {
            ViewBag.Title = "SoundsLike (Double-Metaphone)";
            ViewBag.TextBrowseWord = Request.QueryString["Lookup"] ?? "Hello";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.TextBrowseWord = Request.Form["TextBrowseWord"];
            }

            return View(WordRepository.SoundsLikeDoubleMetaphone(ViewBag.TextBrowseWord));
        }

        public ActionResult SoundsLikeSoundEx()
        {
            ViewBag.Title = "SoundsLike (SoundEx)";
            ViewBag.TextBrowseWord = Request.QueryString["Lookup"] ?? "Hello";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.TextBrowseWord = Request.Form["TextBrowseWord"];
            }

            return View(WordRepository.SoundsLikeSoundEx(ViewBag.TextBrowseWord));
        }

        public ActionResult Synonyms()
        {
            ViewBag.Title = "Synonyms";
            ViewBag.TextBrowseWord = Request.QueryString["Lookup"] ?? "Hello";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.TextBrowseWord = Request.Form["TextBrowseWord"];
            }

            return View(WordRepository.Synonyms(ViewBag.TextBrowseWord));
        }
    }
}
