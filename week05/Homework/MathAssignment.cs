public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problem = "";


    public MathAssignment(string name, string topic, string textbook, string problem) : base(name, topic)
    {
        _problem = problem;
        _textbookSection = textbook;
    }


    public string GetHomeWorkList()
    {
        return $"Section: {_textbookSection} Problems: {_problem}\n";
    }
}