using Microsoft.Extensions.Configuration;

namespace C_RESUME_Extension
{
    public class DBConnString
    {
        public static string GetDBConnString()
        {
            var build = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            string? connectionstring = build.GetConnectionString("DefaultString");
            return connectionstring ?? "";
        }
    }
}