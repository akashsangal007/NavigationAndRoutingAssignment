namespace ViewComponentPartialViewAssignment.Models
{
    public class CommentViewModel
    {
        public int id { get; set; }
        public int postId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}
