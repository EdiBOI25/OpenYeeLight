using Colore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colore;
using ColoreColor = Colore.Data.Color;

namespace OpenYeeLightUI.Classes
{
    public class RazerSDK
    {

        static public void Initialize()
        {
            // Create the regular native SDK backend, like in version 5.x
            ColoreProvider.CreateNativeAsync();
            // When creating a Chroma instance using the REST API backend, you need to supply the SDK with information
            // about your app.
            //var appInfo = new AppInfo("OpenYeeLight Chroma", "OpenYeeLight Razer Chroma test", "EdiBOI", "jaguarul2501@gmail.com", Category.Application);
            //ColoreProvider.CreateRestAsync(appInfo);
            Console.WriteLine("\n\n\nChroma SDK Initialized\n\n\n");
        }
        
    }
}
