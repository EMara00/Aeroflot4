using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    public class FirmMngr
    {
        private List<Passenger> firms;

        public void AddFirm(Passenger firm)
        {
            firms.Add(firm);
        }

        public List<Passenger> GetFirm()
        {
            return firms;
        }

        public FirmMngr()
        {
            firms = new List<Passenger>();
        }
    }
}