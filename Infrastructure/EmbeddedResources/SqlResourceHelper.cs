
using System.Reflection;

namespace Infrastructure
{
    public class SqlResourceHelper : ISqlResourceHelper
    {
        public string GetSqlQuery(SqlResourceEntity entity)
        {

            var assembly = Assembly.GetExecutingAssembly();

            string assemblyName = assembly.GetName().Name!;
            string resourceName = $"{assemblyName}.{entity.Path}";


            using (Stream stream = assembly.GetManifestResourceStream(resourceName)!)
            {

                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}