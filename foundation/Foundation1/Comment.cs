public class Comment
{
    public string _personName;
    public string _text;

    public Comment(string personName, string text)
    {
        _personName = personName;
        _text = text;
    }

    public string GetCommentDetails()
    {
        return $"Name: {_personName}" + " - " + $"{_text}";
    }
}