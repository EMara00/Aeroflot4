using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    public class MainContr
    {
        FirmMngr firm_manager;

        public void CreateFilter()
        {
            firm_manager = new FirmMngr();
            FilterContr filter_controler = new FilterContr(firm_manager);
            frmFilter frm_filter = new frmFilter(filter_controler);
            frm_filter.Show();
        }
        public MainContr()
        {
            firm_manager = new FirmMngr();
            FirmCol.AddPassFromFile();
        }

        public List<Passenger> get_firms()
        {
            return firm_manager.GetFirm();
        }
    }
}