using Repositories;
using Repositories.Entities;

namespace BookManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //thêm cuốn sách xem sao, gọi cabinet dbcontext
            List<Book> arr = new BookManagementDbContext().Books.ToList();
            BookManagementDbContext context = new BookManagementDbContext();
            context.Books.Add(new Book()
            {
                BookId = 18,
                BookName = "Test",
                Author = "Japan",
                Description = "Test",
                Price = 1,
                Quantity = 1,
                BookCategoryId = 1,
                PublicationDate = DateTime.Now,
            }) ;
            context.SaveChanges();
            //đã select * from Books
            //in 17 cuốn sách ra thôi
            Console.WriteLine("The list of books in table:");
            foreach (Book book in arr)
            {
                string bookToString = $" {book.BookId} | {book.BookName} | {book.Author} | {book.BookCategoryId}";
                Console.WriteLine(bookToString);
            }
            List<UserAccount> arr2 = new BookManagementDbContext().UserAccounts.ToList();
        }
    }
}
