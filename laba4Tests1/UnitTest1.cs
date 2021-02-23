using System;
using System.Collections.Generic;
using laba4;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace laba4Tests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDelPass()
        {
            FirmMngr firm_manager = new FirmMngr();
            FilterContr filter_contr = new FilterContr(firm_manager);
            LogExpFactory factory = new LogExpFactory();

            FirmCol.AddPassFromFile();

            factory.add_filter("Имя", "Анна", "string", 1);
            LogExpEnum filters = factory.get_filters();
            filter_contr.sort(filters);
            List<Passenger> col_firm = firm_manager.GetFirm();

            if (col_firm.Count == 1)
            {
                Assert.AreEqual("Анна", col_firm[0].fields[1].GetValue());
            }
            else Assert.Fail();
        }

        [TestMethod]
        public void TestDate()
        {
            FirmMngr firm_manager = new FirmMngr();
            FilterContr filter_contr = new FilterContr(firm_manager);
            LogExpFactory factory = new LogExpFactory();

            FirmCol.AddPassFromFile();

            factory.add_filter("Дата отправления", "27.11.2019", "date", 1);
            LogExpEnum filters = factory.get_filters();
            filter_contr.sort(filters);
            List<Passenger> col_firm = firm_manager.GetFirm();

            if (col_firm.Count == 1)
            {
                Assert.AreEqual("27.11.2019", col_firm[0].fields[7].GetValue());
            }
            else Assert.Fail();
        }
        [TestMethod]
        public void TestAddPass()
        {
            FirmCol.AddPassFromFile();

            List<Passenger> firms = FirmCol.get_firms();
            int start_size = firms.Count;

            string[] str = { "Толстова", "Мария", "Георгиевна", "2214 258688", "Россия", "Аэрофлот", "первый", "31.12.2019", "Россия", "Япония" };

            frmCreate.AddPassenger(str);

            firms = FirmCol.get_firms();
            int end_size = firms.Count;

            Assert.AreEqual(start_size + 1, end_size);
        }

    }
    }

