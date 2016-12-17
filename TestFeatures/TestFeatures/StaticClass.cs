using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFeatures
{
    /// <summary>
    /// This is a static class.
    /// </summary>
    public static class StaticClass
    {
        public static string Name => "Forename";

        public static DateTime CurrentDate => DateTime.UtcNow;
    }
}
