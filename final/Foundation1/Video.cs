public class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetNumberOfComments(){
        return _comments.Count.ToString();
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public void DisplayComments(){
        foreach(Comment comment in _comments){
            Console.WriteLine(comment.GetCommenterName() + " said: " + comment.GetCommentText());
        }
    }

    public string GetTitle(){
        return _title;
    }
    public string GetAuthor(){
        return _author;
    }
    public int GetLength(){
        return _length;
    }


}