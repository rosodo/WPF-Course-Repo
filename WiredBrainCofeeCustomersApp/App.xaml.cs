using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using WiredBrainCofeeCustomersApp.ViewModels;
using WiredBrainCoffee.CustomersApp.Data;

namespace WiredBrainCofeeCustomersApp
{
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {

            ServiceCollection services = new();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainWindow>();

            services.AddTransient<MainViewModel>();
            services.AddTransient<CustomersViewModel>();
            services.AddTransient<ProductsViewModel>();

            services.AddTransient<ICustomerDataProvider, CustomerDataProvider>();
            services.AddTransient<IProductDataProvider, ProductDataProvider>();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow?.Show();
        }
    }
}
