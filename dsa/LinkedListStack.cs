public class LinkedListStack<T>
{
    public Node<T>? head;
    private int Count { get; set; }

    public void Push(T Data)
    {
        Node<T> top_node = new Node<T>(Data);

        if (head == null)
        {
            head = top_node;
        }
        else
        {
            Node<T> current = new Node<T>(Data);
            var next = head;

            head = current;
            current.next = next;
        }

        Count++;
    }

    public T? Pop()
    {
        if (head == null)
        {
            Console.WriteLine("Stack Empty");
            return default;
        }

        var pop_val = head.Data;

        Node<T> current = head;

        if (current.next != null)
        {
            head = current.next;
            Count--;
        }

        return pop_val;
    }

    public T? Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Stack Empty");
            return default;
        }

        return head.Data;
    }

    public void Print()
    {
        Console.WriteLine("Printing LinkedList ....... ");
        for (var cur = head; cur != null; cur = cur.next)
        {
            Console.Write($"{cur.Data} -> ");
        }

        Console.WriteLine("null");
    }
}