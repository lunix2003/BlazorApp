using ClassLibrary;

namespace EmployeeAPI.Services
{
    public class AuthorServiceImp : IAuthorService
    {
        private readonly AppDbContext context;

        public AuthorServiceImp(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Author> CreateAuthor(Author author)
        {
            await context.Authors.AddAsync(author);
            await context.SaveChangesAsync();
            return author;
        }
        public async Task<Author> UpdateAuthor(Author author)
        {
            context.Authors.Update(author);
            await context.SaveChangesAsync();
            return author;
        }
        //Say Hi
    }
}
