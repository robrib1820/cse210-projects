using System;
public class MathAssignment : Assignment {
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textBookSection,string problems, string studentName, string topic) : base(studentName, topic) {
        _textbookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomewokList() {
        return _textbookSection + " - " + _problems; 
    }
}