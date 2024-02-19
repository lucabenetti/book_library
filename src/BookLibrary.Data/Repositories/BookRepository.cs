using BookLibrary.Data.Context;
using BookLibrary.Domain.Contracts;
using BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookLibrary.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookLibraryDbContext _context;

        public BookRepository(BookLibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Book>> FilterAsync(Expression<Func<Book, bool>> predicate)
        {
            return await _context.Set<Book>().Where(predicate).ToListAsync();
        }
    }
}

// TO DO: create generic base repository 
