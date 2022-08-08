using DanceNotes.Domain.Persistance;
using DanceNotes.Maui.Domain.Services;
using DanceNotes.Maui.Models;

namespace DanceNotes.Maui.Services.Services;

public class DanceService : IDanceService
{
    private readonly IUnitOfWork _unitOfWork;

    public DanceService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<DanceCategory> GetAllSteps(string danceclass)
    {
        return await _unitOfWork.DanceCategories.GetEntityAsync<IEnumerable<DanceStep>>(x => x.Name == danceclass, y => y.DanceSteps);
    }
}
