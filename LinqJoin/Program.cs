using LinqJoin;

List<Authors> authors = new List<Authors> //Yazarlar listesi
{
    new Authors { Id = 1, Name = "Orhan Pamuk"},
    new Authors { Id = 2, Name = "Elif Şafak"},
    new Authors { Id = 3, Name = "Ahmet Ümit"}
};

List<Books> books = new List<Books> //Kitaplar listesi
{
    new Books { Id = 1, Title = "Kar", AuthorId = 1},
    new Books { Id = 2, Title = "İstanbul", AuthorId = 1},
    new Books { Id = 3, Title = "10 Min 38 Sec in This Strange World", AuthorId = 2},
    new Books { Id = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3},
};

//Yazarlar ve kitaplar join kullanarak birleştiriliyor
var authorBooks = from author in authors 
                  join book in books on author.Id equals book.AuthorId 
                  select new
                  {
                      AuthorName = author.Name,
                      BookTitle = book.Title
                  };

// Sonuçlar ekrana yazdırılıyor
foreach (var i in authorBooks) 
{
    Console.WriteLine($"Yazar: {i.AuthorName}, Kitap: {i.BookTitle}");
}