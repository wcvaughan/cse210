public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> comments { get; set; }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void GetNumComments()
    {
        int numComments = comments.Count();
        Console.WriteLine($"{numComments} comments");
        Console.WriteLine();
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title} Author: {_author} Length: {_length} seconds");
    }
        public void DisplayComments()
    {
        foreach (Comment c in comments)
        {
            Console.WriteLine($"User: {c.Name} Comment: {c.CommentText}");
        }
    }
}