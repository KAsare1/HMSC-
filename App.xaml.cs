using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth.Requests;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HMS
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
        private readonly IHost _host;

        public App()
        {
            _host = Host
                .CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                string firebaseAPIkey = context.Configuration.GetValue<string>("FIREBASE_API_KEY");
                service.AddSingleton<LoginWindow>((services) => new LoginWindow());
                
                })
                .Build();
        }

        FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuhProvider();

        public LoginWindow LoginWindow { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            LoginWindow = _host.Services.GetRequiredService<LoginWindow>();
            LoginWindow.Show();
            base.OnStartup(e);
        }

    }
}
