using ClassLibrary;

namespace EmployeeAPI.Services
{
    public interface IAuthorService
    {
        Task<Author> CreateAuthor(Author author);
        Task<Author> UpdateAuthor(Author author);
    }
}
