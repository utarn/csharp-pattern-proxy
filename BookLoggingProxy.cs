namespace pattern_proxy
{
    public class BookLoggingProxy : IBook
    {
        public string fileName { get; }
        private RealBook realBook;

        public BookLoggingProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void Show()
        {
            if (realBook == null)
            {
                realBook = new RealBook(fileName);
            }
            System.Console.WriteLine("Logging book " + fileName);
            realBook.Show();
            
        }
    }
}