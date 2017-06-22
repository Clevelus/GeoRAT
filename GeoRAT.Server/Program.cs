using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using GeoRAT.Server.Runtime;

namespace GeoRAT.Server
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            var dll = "GeoRAT.Server.Libraries.GeoRAT.Core.dll";
            EmbeddedAssembly.Load(dll, "GeoRAT.Server.Libraries.GeoRAT.Core.dll");
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
