using System;
using System.IO;
namespace LRC
{
    public class variables{
        public static string version;
        public static string shouldbeversion = File.ReadAllText(".version").Replace(" DON'T CHANGE ME, THIS KEEPS TRACK OF THE CURRENT VERSION", string.Empty).Replace(Environment.NewLine, string.Empty);
    }
}
