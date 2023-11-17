using System;
using System.Collections.Generic;

namespace Seyd
{
    internal class MountainData
    {
        private (string, decimal)[] Owners;
        private decimal[] Eves;
        private decimal[] EveLambs;
        private decimal[] RamLambs;

        public MountainData((string, decimal)[] owners, decimal[] eves, decimal[] eveLambs, decimal[] ramLambs)
        {
            Owners = owners;
            Eves = eves;
            EveLambs = eveLambs;
            RamLambs = ramLambs;
        }
    }
}
