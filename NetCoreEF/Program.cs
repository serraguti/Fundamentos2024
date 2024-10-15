using Microsoft.EntityFrameworkCore;
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
            //string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            string connectionString = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;User ID=SA;Persist Security Info=True;";
            //NECESITAMOS UN OBJETO LLAMADO ServiceProvider QUE ES EL ENCARGADO
            //DE RESOLVER LAS DEPENDENCIAS EN LAS CLASES
            //DEBEMOS INDICAR CADA CLASE QUE UTILIZAREMOS
            //1) SI SON CLASES "NORMALES" SE UTILIZA AddTransient()
            //2) CLASES DBCONTEXT SE DEBEN ENVIAR MEDIANTE AddDbContext()
            //CUANDO GENERAMOS UN DBCONTEXT DEBEMOS INDICAR A QUE BASE DE DATOS
            //NOS CONECTAREMOS MEDIANTE LA CADENA DE CONEXION Y EL METODO DE CADA 
            //PROVEEDOR: UseSqlServer (SQL Server).  UseMySql(My Sql)
            ServiceProvider provider = new ServiceCollection()
                .AddTransient<RepositoryEmpleados>()
                .AddDbContext<EmpleadosContext>(options => options.UseSqlServer(connectionString))
                .BuildServiceProvider();

            //LANZA MI FORMULARIO
            Application.Run(new Form1());
        }
    }
}