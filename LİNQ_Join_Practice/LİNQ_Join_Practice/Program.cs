
using LİNQ_Join_Practice;

List<Author> authors = new List<Author>
{
    new Author { AuhtorId = 1, Name = "Yılmaz Çınar" },
    new Author { AuhtorId = 2, Name = "JR Tolkien" },
    new Author { AuhtorId = 3, Name = "Ahmet Ümit" }
};

List<Book> books = new List<Book>
{
    new Book { BookId = 1, Title = "Kuyucaklı Yusuf", AuthorId = 1 },
    new Book { BookId = 2, Title = "Yüzüklerin Efendisi", AuthorId = 2 },
    new Book { BookId = 3, Title = "İstanbul Hatırası", AuthorId = 3 }
};


//Join ile kitapları ve yazarları birleştirme.

var query = from book in books join author in authors on book.AuthorId equals author.AuhtorId
            select new
            {
                book.Title,
                author.Name
            };


Console.WriteLine("\nKitaplar ve Yazarları : \n");

foreach (var item in query)
{
    Console.WriteLine($"Kitap : {item.Title}, Yazar : {item.Name}");
}