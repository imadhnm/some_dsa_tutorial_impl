public class ArrayStack<T>
{
    private T[] stack_rec { get; set; }
    private int size = 0;
    private int top = -1;

    public ArrayStack(int _size)
    {
        this.size = _size;
        stack_rec = new T[_size];
    }

    public void Push(T Data)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack Full");
            return;
        }

        stack_rec[++top] = Data;
    }

    public T? Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Empty");
            return default;
        }

        var pop_value = stack_rec[top];
        top--;

        return pop_value;
    }

    public T? Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Empty");
            return default;
        }

        var peek_value = stack_rec[top];

        return peek_value;
    }
}