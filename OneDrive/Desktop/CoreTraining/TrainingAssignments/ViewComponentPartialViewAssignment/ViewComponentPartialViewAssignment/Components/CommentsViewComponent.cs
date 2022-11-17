using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ViewComponentPartialViewAssignment.Models;

namespace ViewComponentPartialViewAssignment.Components
{
    public class CommentsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(CommentViewModel comment)
        {

            return View("~/Views/Components/_Comments.cshtml" ,comment);

        }
    }
}
