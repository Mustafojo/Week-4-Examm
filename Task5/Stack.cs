public class Stack<T>
{
    public List<T> list = new List<T>();
    public void Push(T value)
    {
        list.Add(value);
    }
    public T Pop()
    {
        T li = list[list.Count - 1];
        list.Remove(li);
        return li;   
    }
    public T Peek()
    {
        var li = list[list.Count - 1];
        return li;
    }
}
