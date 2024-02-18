using BookLibrary.Domain.Entities;
using System.Linq.Expressions;

namespace BookLibrary.Domain.Contracts
{
    public interface IBookRepository
    {
        Task<IReadOnlyList<Book>> FilterAsync(Expression<Func<Book, bool>> predicate);
    }
}
