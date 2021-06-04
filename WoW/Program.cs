﻿using Microsoft.Extensions.DependencyInjection;
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
using WoW.Forms;

namespace WoW
{
    static class Program
    {
        public static ServiceProvider ServiceProvider { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();       
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a new Service Collection that will contain application dependencies 
            var services = new ServiceCollection();

            // Configure Dependency Injection services
            ConfigureServices(services);

            // Get the services for the initial form (MainForm) and open the Form
            using (ServiceProvider = services.BuildServiceProvider())
            {
                var credentials = ServiceProvider.GetRequiredService<CredentialsForm>();
                Application.Run(credentials);
            }
        }

        // Dependency Injection configuration
        static void ConfigureServices(ServiceCollection services)
        {
            // Register Forms
            services.AddScoped<MainForm>();
            services.AddTransient<CharactersForm>();
            services.AddSingleton<CredentialsForm>();
            services.AddTransient<RegisterForm>();
            services.AddTransient<MainMenuForm>();
            services.AddTransient<CreateCharacterForm>();

            services.AddSingleton<ISettings>(new Settings(GetConnectionString()));
            services.AddTransient<IDatabaseHelpers, DapperHelpers>();

            // Repository Registrations
            services.AddTransient<ICharacterRepository, CharacterRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IRaceRepository, RaceRepository>();
            services.AddTransient<IClassRepository, ClassRepository>();

            // Services Registrations
            services.AddTransient<ICharacterService, CharacterService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IRaceService, RaceService>();
            services.AddTransient<IClassService, ClassService>();
        }

        // Gets the DbConnection string from the AppSettings.config file
        static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        }
    }
}
