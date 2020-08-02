namespace pattern_proxy
{
    public class BookProxy : IBook
    {
        public string fileName { get; }
        private RealBook realBook;

        public BookProxy(string fileName) {
            this.fileName = fileName;
        }

        public void Show()
        {
            if (realBook == null) {
                realBook = new RealBook(fileName);
            }
            
            realBook.Show();
        }
    }
}