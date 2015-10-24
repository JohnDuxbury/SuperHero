using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Superhero.Models;

namespace Superhero.Controllers
{
    public class MembersController : Controller
    {
        public ActionResult Welcome(MembersViewModel model)
        {
            if (!Request.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login?returnUrl="
                    + Request.Url.LocalPath);
            }
            else
            {
                model.LoggedInUserName = User.Identity.GetUserName();
                ViewBag.Title = "Members Welcome";
            }
            return View(model);
        }
    }
} 
