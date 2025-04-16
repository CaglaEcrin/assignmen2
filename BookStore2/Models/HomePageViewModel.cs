namespace BookStore2.Models;

public class HomePageViewModel
{
    public List<Book> MostViewBook { get; set; } = new List<Book>();
    
    public List<Book> NewBooks { get; set; } = new List<Book>();
}