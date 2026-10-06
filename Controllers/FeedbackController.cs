using System.Web.Mvc;
using DNET_Practical_7.Models;

namespace DNET_Practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                TempData["FeedbackMessage"] = "Thank you for your valuable feedback!";
                TempData["FeedbackName"] = feedback.Name;
                TempData["FeedbackCourse"] = feedback.Course;
                TempData["FeedbackRating"] = feedback.Rating;
                TempData["FeedbackComments"] = feedback.Comments;

                return RedirectToAction("Result");
            }

            return View(feedback);
        }

        public ActionResult Result()
        {
            return View();
        }
    }
}