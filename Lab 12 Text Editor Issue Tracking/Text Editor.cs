 public class TextEditor
{
    private string _content;
    private int _cursorPosition;
    private List<string> _selections;

    public TextEditor()
    {
        _content = "";
        _cursorPosition = 0;
        _selections = new List<string>();
    }
    public void setcontent(string content)
    {
        _content=content;
    }
    public void SetCursorPosition(int cursorPosition)
    {
        if(cursorPosition <0||cursorPosition > _content.Length)
        {
            throw new ArgumentOutOfRangeException("Invalid Cursor Position!");
        }
        _cursorPosition = cursorPosition;
    }
    public void AddSelection(string selection)
    {
        _selections.Add(selection);
    }
    public void ClearSelection(string selection)
    {
        _selections.Clear();
    }
}
 
