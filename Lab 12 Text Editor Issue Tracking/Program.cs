class Program
{
    public static void Main(String[] args)
    {
        TextEditor editor = new TextEditor();
        History history = new History(editor);

        editor.SetCursorPosition(5);
        editor.AddSelection("Hello");
        history.Backup();

      

        history.Undo();
        Console.WriteLine("\nAfter Undo:");
       
    }
}
