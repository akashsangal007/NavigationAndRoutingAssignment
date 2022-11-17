using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ViewComponentPartialViewAssignment.Models;
using static System.Net.WebRequestMethods;

namespace ViewComponentPartialViewAssignment.Controllers
{
    public class PostController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
           
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            IEnumerable<PostViewModel> model = new List<PostViewModel>();
            var response = await client.GetAsync(client.BaseAddress + "posts");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                model = JsonSerializer.Deserialize<IEnumerable<PostViewModel>>(data);
            }

            PostViewModel post = model.FirstOrDefault();
        

            IEnumerable<CommentViewModel> modelComment = new List<CommentViewModel>();
            var responseComment = await client.GetAsync(client.BaseAddress + "comments");
            if (responseComment.IsSuccessStatusCode)
            {
                var dataComment = await responseComment.Content.ReadAsStringAsync();
                modelComment = JsonSerializer.Deserialize<IEnumerable<CommentViewModel>>(dataComment);
            }
            CommentViewModel comment = modelComment.FirstOrDefault(x=>x.postId == post.id);
            var tupleModel = new Tuple<PostViewModel,CommentViewModel>(post, comment);

            return View(tupleModel);
        }
    }
}
