using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoW.Core.Helpers;
using WoW.Core.Models;
using WoW.Core.Repositories;
using WoW.Core.Services;

namespace WoW
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            ConfigureServices();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Dependency Injection configuration
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ISettings>(new Settings(GetConnectionString()));
            services.AddTransient<IDatabaseHelpers, DapperHelpers>();

            // Repository Registrations
            services.AddTransient<ICharacterRepository, CharacterRepository>();

            // Services Registrations
            services.AddTransient<ICharacterService, CharacterService>();
        }

        // Gets the DbConnection string from the AppSettings.config file
        static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        }
    }
}
