using DanceNotes.Domain.Persistance;
using DanceNotes.Maui.Models;
using Microsoft.EntityFrameworkCore;

namespace DanceNotes.Maui.Services.Persistance;

public class UnitOfWork : IUnitOfWork
{
    private readonly MobileDbContext _mobileDbContext;

    public IRepository<DanceCategory> DanceCategories { get; }

    public UnitOfWork(MobileDbContext mobileDbContext)
    {
        _mobileDbContext = mobileDbContext;
        DanceCategories = new Repository<DanceCategory>(mobileDbContext);
    }

    public async Task<int> Complete()
    {
        try
        {
            return await _mobileDbContext.SaveChangesAsync();
        }
        catch (DbUpdateException)
        {
            return 0;
        }
    }
}

