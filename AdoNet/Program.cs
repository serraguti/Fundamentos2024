using Microsoft.Extensions.Configuration;

namespace AdoNet
{
    internal static class Program
    {
        //PARA PODER ACCEDER A LOS ELEMENTOS DEBEMOS DECLARAR 
        //LOS METODOS CON LA PALABRA static
        public static IConfigurationRoot GetConfiguration()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //DEBEMOS INDICAR DONDE TENEMOS LA CADENA DE CONEXION
            //EL FICHERO Y SU NOMBRE (appsettings.json)
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            //CONSTRUIMOS EL FICHERO PARA NUESTRA APP
            IConfigurationRoot configuration = builder.Build();
            return configuration;
        }

        public static string GetConnectionString()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //DEBEMOS INDICAR DONDE TENEMOS LA CADENA DE CONEXION
            //EL FICHERO Y SU NOMBRE (appsettings.json)
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            //CONSTRUIMOS EL FICHERO PARA NUESTRA APP
            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("HospitalExpress");
            return connectionString;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form11TestSettings());
        }
    }
}