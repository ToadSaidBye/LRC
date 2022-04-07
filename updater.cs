using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
namespace LRC
{
   public class updater{

      public  static void update(){
            WebClient client = new WebClient();
Stream stream = client.OpenRead("https://raw.githubusercontent.com/ToadSaidBye/LRC/main/.version");
StreamReader reader = new StreamReader(stream);
String content = reader.ReadToEnd();
 string version = content.Replace(" DON'T CHANGE ME, THIS KEEPS TRACK OF THE CURRENT VERSION", string.Empty).Replace(Environment.NewLine, string.Empty);
variables.version = version;
            
        }
    }

    
}
