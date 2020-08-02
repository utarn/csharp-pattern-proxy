using System.Collections.Generic;
namespace pattern_proxy
{
    public class Library
    {
        private Dictionary<string, IBook> books = new Dictionary<string, IBook>();
        public void AddBook(IBook book)
        {
            books.Add(book.fileName, book);
        }

        public void OpenBook(string fileName)
        {
            if (books.ContainsKey(fileName))
            {
                books[fileName].Show();
            }
            else
            {
                // Show error!
            }
        }
    }
}