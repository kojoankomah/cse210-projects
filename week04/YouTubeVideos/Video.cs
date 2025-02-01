public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments;

    public Video(string title, string author, int length){
        _author = author;
        _title = title;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetTitle(){
        return _title;
    }

    public string GetAuthor(){
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public int GetNumberOfComments(){
        return _comments.Count;
    }

    public List<Comment> GetComments(){
        return _comments;
    }
}