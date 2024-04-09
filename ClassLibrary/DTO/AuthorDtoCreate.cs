
namespace ClassLibrary.DTO
{
    public static class ExtensionDto
    {
        public static Author AsAuthor(this AuthorDtoCreate author)
        {
            return new Author
            {
                Name = author.Name,
                Sex = author.Sex
            };
        }
    }
    public class AuthorDtoCreate
    {
        public string? Name { get; set; }
        public string? Sex { get; set; }
    }
    
}
