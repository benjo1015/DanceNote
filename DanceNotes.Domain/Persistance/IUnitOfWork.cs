using DanceNotes.Maui.Models;

namespace DanceNotes.Domain.Persistance;

public interface IUnitOfWork
{
    IRepository<DanceCategory> DanceCategories { get; }
    Task<int> Complete();
}
