using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreEF.Data;
using NetCoreEF.Repositories;

namespace NetCoreEF
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
            //NECESITAMOS RECUPERAR LA CADENA DE CONEXION A PARTIR DEL FICHERO
            //JSON DE SETTINGS
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("HospitalSQLExpress");
            //string connectionString = configuration.GetConnectionString("HospitalSQL");
            //ANTES DE LANZAR EL FORMULARIO, VAMOS A REALIZAR TODAS LAS INYECCIONES NECESARIAS
            //NECESITAMOS UN OBJETO LLAMADO ServiceProvider QUE ES EL ENCARGADO
            //DE RESOLVER LAS DEPENDENCIAS EN LAS CLASES
            //DEBEMOS INDICAR CADA CLASE QUE UTILIZAREMOS
            //1) SI SON CLASES "NORMALES" SE UTILIZA AddTransient()
            //2) CLASES DBCONTEXT SE DEBEN ENVIAR MEDIANTE AddDbContext()
            //CUANDO GENERAMOS UN DBCONTEXT DEBEMOS INDICAR A QUE BASE DE DATOS
            //NOS CONECTAREMOS MEDIANTE LA CADENA DE CONEXION Y EL METODO DE CADA 
            //PROVEEDOR: UseSqlServer (SQL Server).  UseMySql(My Sql)
            //ASIGNAMOS AL PROVIDER LA COLECCION DE CLASES
            provider = new ServiceCollection()
                .AddTransient<RepositoryEmpleados>()
                .AddTransient<RepositoryHospital>()
                .AddTransient<RepositoryDoctores>()
                .AddDbContext<EmpleadosContext>(options => options.UseSqlServer(connectionString))
                .BuildServiceProvider();

            //LANZA MI FORMULARIO
            Application.Run(new Form05DoctoresPracticaPaco());
        }
    }
}