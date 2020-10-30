using Openfin.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenFinDotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            RuntimeOptions opts = new RuntimeOptions()
            {
                Version = "16.83.52.32",
                UUID = "OpenFinDotNetFramework"
            };

            Runtime _instance = Runtime.GetRuntimeInstance(opts);
            _instance.Connect(() =>
            {
                Console.WriteLine("openfin connected!");
                Application app = _instance.CreateApplication(new ApplicationOptions("OpenFinDotNetFrameworkApp", "OpenFinDotNetFrameworkApp", "http://localhost:8080/index.html")
                {
                    MainWindowOptions = new WindowOptions("OpenFinDotNetFrameworkApp")
                    {
                        URL = "http://localhost:8080/index.html",
                        AutoShow = true,
                        AcceleratorKeys = new AcceleratorKeyOptions {Zoom = true},
                        PreloadScripts = new List<PreloadScript> { new PreloadScript((@"../../preload.js"), true) }
                    }
                });
                app.Start();
            });

            AutoResetEvent autoEvent = new AutoResetEvent(false);
            autoEvent.WaitOne();



            
              
           
        }
    }
}
