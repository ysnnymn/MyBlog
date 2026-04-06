namespace MyBlogPresentationLayer.Areas.Admin.Models;

public class WriterEditViewModel
{
    public int  Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string ImageUrl { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public IFormFile Image { get; set; }
}