// Video.cs
public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments = new();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount() => Comments.Count;

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {Length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var c in Comments)
        {
            Console.WriteLine($" - {c.Name}: {c.Text}");
        }
        Console.WriteLine();
    }
}
