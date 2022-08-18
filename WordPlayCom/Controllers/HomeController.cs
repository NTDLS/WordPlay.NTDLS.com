using System.Collections.Generic;
using System.Web.Mvc;
using WordPlay.Shared.Repository;

namespace WordPlaySyncService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            ViewBag.Title = "Home";

            return View(new List<string>());
        }

        public ActionResult Browse()
        {
            ViewBag.Title = "Browse";
            ViewBag.Word = Request.QueryString["Word"] ?? "Hello%";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.Word = Request.Form["Word"];
            }

            return View(WordRepository.BrowseWords(ViewBag.Word));
        }

        public ActionResult Translate()
        {
            ViewBag.Title = "Translate";
            ViewBag.Word = Request.QueryString["Word"] ?? "Hello%";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.Word = Request.Form["Word"];
            }

            return View(WordRepository.Translate(ViewBag.Word));
        }

        public ActionResult SoundsLikeMetaphone()
        {
            ViewBag.Title = "SoundsLike (Metaphone)";
            ViewBag.Word = Request.QueryString["Word"] ?? "Hello%";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.Word = Request.Form["Word"];
            }

            return View(WordRepository.SoundsLikeMetaphone(ViewBag.Word));
        }

        public ActionResult SoundsLikeDoubleMetaphone()
        {
            ViewBag.Title = "SoundsLike (Double-Metaphone)";
            ViewBag.Word = Request.QueryString["Word"] ?? "Hello%";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.Word = Request.Form["Word"];
            }

            return View(WordRepository.SoundsLikeDoubleMetaphone(ViewBag.Word));
        }

        public ActionResult SoundsLikeSoundEx()
        {
            ViewBag.Title = "SoundsLike (SoundEx)";
            ViewBag.Word = Request.QueryString["Word"] ?? "Hello%";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.Word = Request.Form["Word"];
            }

            return View(WordRepository.SoundsLikeSoundEx(ViewBag.Word));
        }

        public ActionResult Synonyms()
        {
            ViewBag.Title = "Synonyms";
            ViewBag.Word = Request.QueryString["Word"] ?? "Hello%";

            if (Request.HttpMethod == "POST")
            {
                ViewBag.Word = Request.Form["Word"];
            }

            return View(WordRepository.Synonyms(ViewBag.Word));
        }
    }
}
