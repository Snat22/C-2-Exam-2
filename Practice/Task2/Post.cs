namespace Task2;

public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }

    public List<string> Comments = new List<string>();
    public bool IsPublished { get; set; }

    public string Publish()
    {
        IsPublished = true;
        return "The post is published.";
        
    }

    public int Like()
    {
       return LikeCount++;
    }

    public void Comment(string messages)
    {
        Comments.Add(messages);
    }
}
