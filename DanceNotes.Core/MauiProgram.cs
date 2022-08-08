using CommunityToolkit.Maui;
using DanceNotes.Core.Database;
using DanceNotes.Domain.Persistance;
using DanceNotes.Maui.Domain.Services;
using DanceNotes.Maui.Services.Persistance;
using DanceNotes.Maui.Services.Services;
using DanceNotes.UI.ViewModels.Ballroom;
using DanceNotes.UI.ViewModels.Latin;
using DanceNotes.UI.Views.Ballroom;
using DanceNotes.UI.Views.Latin;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DanceNotes.Core;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        })
        .UseMauiCommunityToolkit();

        builder.Services.AddDbContext<MobileDbContext>();
        builder.Services.AddTransient<IDatabaseFactory, DatabaseFactory>();
        builder.Services.AddScoped<DbContext,MobileDbContext>();
        builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
        builder.Services.AddTransient<IDanceService, DanceService>();
        builder.Services.AddTransient<ChaChaChaViewModel>();
        builder.Services.AddTransient<SambaViewModel>();
        builder.Services.AddTransient<PasoDobleViewModel>();
        builder.Services.AddTransient<RhumbaViewModel>();
        builder.Services.AddTransient<JiveViewModel>();
        builder.Services.AddTransient<WaltzViewModel>();
        builder.Services.AddTransient<ViennesseWaltzViewModel>();
        builder.Services.AddTransient<TangoViewModel>();
        builder.Services.AddTransient<FoxtrotViewModel>();
        builder.Services.AddTransient<QuickStepViewModel>();
        builder.Services.AddTransient<ChaChaChaPage>();
        builder.Services.AddTransient<RhumbaPage>();
        builder.Services.AddTransient<PasoDoblePage>();
        builder.Services.AddTransient<JivePage>();
        builder.Services.AddTransient<SambaPage>();
        builder.Services.AddTransient<WaltzPage>();
        builder.Services.AddTransient<VienesseWaltzPage>();
        builder.Services.AddTransient<FoxtrotPage>();
        builder.Services.AddTransient<TangoPage>();
        builder.Services.AddTransient<QuickStepPage>();

        return builder.Build();
    }
}