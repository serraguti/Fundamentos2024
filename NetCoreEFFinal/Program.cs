using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreEFFinal.Data;
using NetCoreEFFinal.Repositories;

namespace NetCoreEFFinal
{
    internal static class Program
    {
        public static ServiceProvider provider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //CONFIGURACION DE SETTINGS
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("HospitalSQLServer");
            //string connectionString = configuration.GetConnectionString("HospitalMySql");
            //string connectionString = configuration.GetConnectionString("HospitalOracle");
            //UNA VEZ QUE TENEMOS LA CADENA DE CONEXION Y LOS SETTINGS
            //CONFIGURAMOS LOS SERVICIOS (DbContext, Repository)
            provider = new ServiceCollection()
                .AddTransient<RepositoryHospitales>()
                //.AddDbContext<HospitalContext>(options => options.UseOracle(connectionString))
                .AddDbContext<HospitalContext>(options => options.UseSqlServer(connectionString))
                //.AddDbContext<HospitalContext>(options => options.UseMySql(connectionString
                //, ServerVersion.AutoDetect(connectionString)))
                .BuildServiceProvider();
                
            Application.Run(new Form01HospitalesCRUD());
        }
    }
}