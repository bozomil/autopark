using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mariadb.Helpers
{
    public static class ConfigurationHelper
    {
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name]?.ConnectionString
                   ?? throw new InvalidOperationException($"Connection string '{name}' not found.");
        }
    }
}
