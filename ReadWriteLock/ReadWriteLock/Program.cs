namespace ReadWriteLock;

internal class Program
{
    private static void Main(string[] args)
    {
        ReadWriteLock rwLock = new ReadWriteLock();
        Reader reader = new Reader();
        Writer writer = new Writer();

        // Example usage
        for (int i = 0; i < 5; i++)
        {
            new Thread(() =>
            {
                reader.Read(rwLock);
            }).Start();

            new Thread(() =>
            {
                writer.Write(rwLock);
            }).Start();
        }
    }
}