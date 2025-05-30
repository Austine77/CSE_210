// Program.cs
class Program
{
    static void Main()
    {
        var video1 = new Video("Cooking 101", "Chef Anna", 600);
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Looks tasty."));
        video1.AddComment(new Comment("Cara", "Trying this tonight!"));

        var video2 = new Video("Guitar Lessons", "John Music", 900);
        video2.AddComment(new Comment("Dave", "Helpful tips."));
        video2.AddComment(new Comment("Emma", "Nice teaching style."));

        var videos = new List<Video> { video1, video2 };

        foreach (var v in videos)
            v.DisplayInfo();
    }
}
