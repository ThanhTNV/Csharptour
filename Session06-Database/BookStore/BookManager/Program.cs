using Repositories;
using Repositories.Entities;

namespace BookManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> arr = new BookManagementDbContext().Books.ToList();
            //đã select * from Books
            //in 17 cuốn sách ra thôi
            Console.WriteLine("The list of books in table:");
            foreach (Book book in arr)
            {
                string bookToString = $" {book.BookId} | {book.BookName} | {book.Author} | {book.BookCategoryId}";
                Console.WriteLine(bookToString);
            }
            List<UserAccount> arr2 = new BookManagementDbContext().UserAccounts.ToList();
            Console.WriteLine("The list of users in table:");
        }
    }
}
