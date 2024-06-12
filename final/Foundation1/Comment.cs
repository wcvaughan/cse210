public class Comment
{
    public string _name { get; private set; }
    public string _commentText { get; private set; }
    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }
}