public class Node<T>
{
    public T Data;

    public Node<T>? next;

    public Node(T _value)
    {
        this.Data = _value;
        this.next = null;
    }
}

public class LinkedList<T>
{
    public Node<T>? head;
    private int Count { get; set; }

    public void AddFirst(T data)
    {
        Node<T> new_node = new Node<T>(data);
        head = new_node;
        Count++;
    }

    public void AddLast(T data)
    {
        Node<T>? new_node = new Node<T>(data);

        if (head == null)
        {
            head = new_node;
        }
        else
        {
            Node<T> current = head;

            while (current.next != null)
            {
                current = current.next;
            }

            current.next = new_node;
        }
        Count++;
    }

    public void Reverse()
    {
        Node<T>? prev = null, cur = head;
        while (cur != null)
        {
            var next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }

        head = prev;
    }

    public bool Remove(T Data)
    {
        if (head == null) return false;

        if (head.Data.Equals(Data))
        {
            head = head.next;
            Count--;
            return true;
        }

        Node<T> _current = head;
        while (_current.next != null)
        {
            if (_current.next.Data.Equals(Data))
            {
                _current.next = _current.next.next;
                Count--;
                return true;
            }

            _current = _current.next;
        }

        return false;
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