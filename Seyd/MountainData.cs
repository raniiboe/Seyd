﻿using System;

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

        internal object Solve1()
        {
            throw new NotImplementedException();
        }
    }
}
