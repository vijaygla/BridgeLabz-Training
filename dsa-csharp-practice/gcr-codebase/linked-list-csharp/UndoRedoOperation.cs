using System;

class TextNode
{
    public string Content;
    public TextNode Prev;
    public TextNode Next;

    public TextNode(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextNode head;
    private TextNode current;
    private int size;
    private const int LIMIT = 10;

    public void AddState(string text)
    {
        TextNode newNode = new TextNode(text);

        if (current != null)
            current.Next = null;

        if (current != null)
        {
            newNode.Prev = current;
            current.Next = newNode;
        }
        else
        {
            head = newNode;
        }

        current = newNode;
        size++;

        if (size > LIMIT)
        {
            head = head.Next;
            head.Prev = null;
            size--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
            current = current.Prev;
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
            current = current.Next;
    }

    public void Display()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.Content);
    }
}

class UndoRedoOperation
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");

        editor.Display();
        editor.Undo();
        editor.Display();
        editor.Redo();
        editor.Display();
    }
}
