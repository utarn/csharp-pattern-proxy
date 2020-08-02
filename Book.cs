namespace pattern_proxy
{
    public class Book
    {
        private string fileName;

        public Book(string fileName)
        {
            this.fileName = fileName;
            Load();
        }

        private void Load() {
            System.Console.WriteLine("Loading book " + fileName);
        }
    }
}