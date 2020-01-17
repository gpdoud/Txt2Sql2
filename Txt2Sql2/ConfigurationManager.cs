using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Txt2Sql2 {
    
    public static class ConfigurationManager {
        
        public static IConfigurationRoot Configuration { get;  }

        static ConfigurationManager() {

            var builder = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

        }
    }
}
