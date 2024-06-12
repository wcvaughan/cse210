public class Comment
{
    public string Name { get; private set; }
    public string CommentText { get; private set; }
    public Comment(string name, string commentText)
    {
        Name = name;
        CommentText = commentText;
    }
}