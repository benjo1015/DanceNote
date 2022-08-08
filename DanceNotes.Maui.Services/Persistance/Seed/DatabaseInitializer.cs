using DanceNotes.Maui.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DanceNotes.Maui.Services.Persistance.Seed;

public static class DatabaseInitializer
{
    public static void Seed(MobileDbContext context)
    {
        var name = "DanceNotes.Maui.Services.Persistance.Seed.seed.json";
        var assembly = Assembly.GetExecutingAssembly();

        using (Stream stream = assembly.GetManifestResourceStream(name))
        using (StreamReader reader = new StreamReader(stream))
        {
            string result = reader.ReadToEnd();
            var categories = JsonConvert.DeserializeObject<List<DanceCategory>>(result);
            context.DanceCategories.AddRange(categories);
            context.SaveChanges();
        }
    }
}
