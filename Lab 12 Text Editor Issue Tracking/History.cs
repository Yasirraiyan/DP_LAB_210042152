public class History
{
    private List<EditorMemento> _history;
    private TextEditor _editor;
    public History(TextEditor editor)
        {
        _editor = editor; 
        _history = new List<EditorMemento>();
    }
    public void Backup()
    {
        //_history.Add(_editor.CreateMemento());

    }
    public void Undo()
    {
        if (_history.Count == 0)
        {
            return;
        }
        _history.RemoveAt(_history.Count - 1);
       // _history.RestoreFromMemento(memento);
    }

}
