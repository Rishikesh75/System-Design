using System;
using System.Collections.Generic;

// Memento
public class EditorMemento
{
    public string State { get; }

    public EditorMemento(string state)
    {
        State = state;
    }
}

// Originator
public class TextEditor
{
    private string _content;

    public void Type(string words)
    {
        _content += words + " ";
    }

    public string GetContent()
    {
        return _content;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(_content);
    }

    public void Restore(EditorMemento memento)
    {
        _content = memento.State;
    }
}

// Caretaker
public class History
{
    private Stack<EditorMemento> _history = new Stack<EditorMemento>();

    public void Save(TextEditor editor)
    {
        _history.Push(editor.Save());
    }

    public void Undo(TextEditor editor)
    {
        if (_history.Count > 0)
        {
            var memento = _history.Pop();
            editor.Restore(memento);
        }
    }
}

// Client
public class Program
{
    public static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        History history = new History();

        editor.Type("Hello");
        history.Save(editor);

        editor.Type("World");
        history.Save(editor);

        editor.Type("!!!");

        Console.WriteLine("Current Content: " + editor.GetContent());

        history.Undo(editor);
        Console.WriteLine("After Undo: " + editor.GetContent());

        history.Undo(editor);
        Console.WriteLine("After Second Undo: " + editor.GetContent());
    }
}
