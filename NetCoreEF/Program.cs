using Microsoft.Extensions.DependencyInjection;
using NetCoreEF.Data;

namespace NetCoreEF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //ANTES DE LANZAR EL FORMULARIO, VAMOS A REALIZAR TODAS LAS INYECCIONES NECESARIAS
            //this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            string connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            //NECESITAMOS UN OBJETO LLAMADO ServiceProvider QUE ES EL ENCARGADO
            //DE RESOLVER LAS DEPENDENCIAS EN LAS CLASES
            //DEBEMOS INDICAR CADA CLASE QUE UTILIZAREMOS
            //1) SI SON CLASES "NORMALES" SE UTILIZA AddTransient()
            //2) CLASES DBCONTEXT SE DEBEN ENVIAR MEDIANTE AddDbContext()
            ServiceProvider provider = new ServiceCollection()
                .AddTransient<RepositoryEmpleados>()
                .AddDbContext<EmpleadosContext>()
                .BuildServiceProvider();

            provider.GetService<RepositoryEmpleados>();
            Application.Run(new Form1());
        }
    }
}