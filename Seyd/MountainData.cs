using System;

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

        internal string Solve1()
        {
            double[] cc = {1, -2};
            double[] cl = {0, 0};
            double[] cu = {10, 10};
            double[] rl = {0, 0};
            double[] ru = {2, 1};
            int[] astart = {0, 2};
            int[] aindex = {0, 1, 0, 1};
            double[] avalue = {1, 2, 1, 3};
            HighsObjectiveSense sense = HighsObjectiveSense.kMinimize;
            double offset = 0;
            HighsMatrixFormat a_format = HighsMatrixFormat.kColwise;

            HighsModel model = new HighsModel(cc, cl, cu, rl, ru, astart, aindex, avalue, null, offset, a_format, sense);

            HighsLpSolver solver = new HighsLpSolver();

            HighsStatus status = solver.passLp(model);
            status = solver.run();
            HighsSolution sol = solver.getSolution();
            HighsBasis bas = solver.getBasis();
            HighsModelStatus modelStatus = solver.GetModelStatus();
          
            Console.WriteLine("Status: " + status);
            Console.WriteLine("Modelstatus: " + modelStatus);
       
            for (int i=0; i<sol.rowvalue.Length; i++) {
                 Console.WriteLine("Activity for row " + i + " = " + sol.rowvalue[i]);
            }
            for (int i=0; i<sol.coldual.Length; i++) {
                 Console.WriteLine("Reduced cost x[" + i + "] = " + sol.coldual[i]);
            }
            for (int i=0; i<sol.rowdual.Length; i++) {
                Console.WriteLine("Dual value for row " + i + " = " + sol.rowdual[i]);
            }
            for (int i=0; i<sol.colvalue.Length; i++) {
                Console.WriteLine("x" + i + " = " + sol.colvalue[i] + " is " + bas.colbasisstatus[i]);
            }
            return "bla";
        }
    }
}
