using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    public class FilterContr
    {
        private FirmMngr firm_manager;

        public void sort(LogExpEnum filters)
        {
            List<Passenger> firms = FirmCol.get_firms();

            foreach (Passenger firm in firms)
            {
                bool sort = true;
                foreach (Filter exp_filter in filters.filters)
                    if (!(sort = exp_filter.check(firm))) break;
                if (sort) firm_manager.AddFirm(firm);
            }
        }

        public FirmMngr get_frm_manager()
        {
            return firm_manager;
        }

        public FilterContr(FirmMngr new_firm_manager)
        {
            firm_manager = new_firm_manager;
        }
    }
}