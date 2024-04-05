public class Comment
{
    private string commenterName;
    private string text;

    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }

    public string CommenterName
    {
        get { return commenterName; }
    }

    public string Text
    {
        get { return text; }
    }
}