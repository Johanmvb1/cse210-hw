public class MathAssignment : Assignment
{
    private string _TextBookSection;
    private string _Problems;

    public MathAssignment(string studentName, string topic,string TextBookSection, string Problems)
        : base (studentName,topic)
    
    {

        _TextBookSection = TextBookSection;
        _Problems = Problems;
    }

public string GetHomeworkList()
{
    return $"Section {_TextBookSection} Problems {_Problems}";
}    
}
