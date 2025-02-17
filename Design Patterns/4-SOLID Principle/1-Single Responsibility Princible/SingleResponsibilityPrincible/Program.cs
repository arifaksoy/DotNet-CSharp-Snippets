var mybook = new Book { Title="Dive Into Design pattern",Author="Alexander S.", Price=30};

var formattedBook = BookFormatter.DisplayBookInfo(mybook);
Console.WriteLine(formattedBook);

var discountedPrice = PriceCalculator.CalculateDisCountedPrice(mybook);
Console.WriteLine(discountedPrice);


public class NonSingleResponsiblePrincibleBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Price { get; set; }

    public string DisplayBookInfo() //get and format book info 
    {
       return this.Title + "book";
    }

    public string CalculateDisCountedPrice()
    {
        return "price: " + (this.Price + 20).ToString();
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Price { get; set; }
}

public class BookFormatter
{
    public static string DisplayBookInfo(Book book) //get and format book info 
    {
        return book.Title + " book";
    }
}

public class PriceCalculator
{
    public static string CalculateDisCountedPrice(Book book)
    {
        return"price: " + (book.Price + 20).ToString();
    }
}
