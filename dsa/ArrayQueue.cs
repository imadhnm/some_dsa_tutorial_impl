public class ArrayQueue<T>
{
    private T[] queue_rec { get; set; }
    private int size = 0;
    private int index = -1;
    private int front = 0;


    public ArrayQueue(int _size)
    {
        this.size = _size;
        queue_rec = new T[size];
    }

    public void Enqueue(T Data)
    {
        if (index == size - 1)
        {
            Console.WriteLine("Queue Full");
            return;
        }

        queue_rec[++index] = Data;
    }

    public T? Dequeue()
    {
        if (index == -1)
        {
            Console.WriteLine("Queue Empty");
            return default;
        }

        var dequeue_value = queue_rec[front];
        front++;

        return dequeue_value;
    }
}