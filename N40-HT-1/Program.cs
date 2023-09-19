



//public class ThreadSafeQueue<T>
//{
//    private readonly Queue<T> _queue;

//    public void Enqueue(T item)
//    {
//        lock (_queue) 
//        {
//            _queue.Enqueue(item);
//        }
//    }
//    public T Dequeue()
//    {
//        lock (_queue) 
//        { 
//            return _queue.Dequeue();
//        }
//    }

//}



























public class ThreadQueue<T>
{
    private readonly Queue<T> _queue;
    public void Equeue(T item)
    {
        lock (_queue)
            
        {
            _queue.Enqueue(item);
        }
        

    }
    public void Dqueue()
    {
        lock(_queue)
        {
            _queue.Dequeue();
        }
    }
}
