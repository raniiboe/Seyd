using System;
using System.Collections.Generic;
using Python.Runtime;

namespace Seyd
{
    internal class Mountain
    {
        private (string, decimal)[] Owners;
        private decimal[] Eves;
        private decimal[] EveLambs;
        private decimal[] RamLambs;

        public Mountain((string, decimal)[] owners, decimal[] eves, decimal[] eveLambs, decimal[] ramLambs)
        {
            Owners = owners;
            Eves = eves;
            EveLambs = eveLambs;
            RamLambs = ramLambs;
        }

        public string Solve()
        {
            Runtime.PythonDLL = @"C:\Users\Rani\Documents\GitHub\Seyd\Seyd\packages\pythonx86.3.12.0\tools\python312.dll";
            PythonEngine.Initialize();
            using (Py.GIL())
            {
                var result = Py.Import("solver").InvokeMethod("solve");
                Console.WriteLine(result.ToString());
                return result.ToString();
            }                
        }
    }
}
