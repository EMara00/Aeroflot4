using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    public interface ILogExp
    {
        bool check(string filter_value, string firm_value);
    }

    public class ExpEQ : ILogExp
    {
        public bool check(string filter_value, string firm_value)
        {
            return filter_value == firm_value;
        }
    }

    public class ExpNoEQ : ILogExp
    {
        public bool check(string filter_value, string firm_value)
        {
            return filter_value != firm_value;
        }
    }

    public class ExpContains : ILogExp
    {
        public bool check(string filter_value, string firm_value)
        {
            return firm_value.Contains(filter_value);
        }
    }

    public class ExpNoContains : ILogExp
    {
        public bool check(string filter_value, string firm_value)
        {
            return !firm_value.Contains(filter_value);
        }
    }

    public class ExpGT : ILogExp
    {
        public bool check(string filter_value, string firm_value)
        {
            return Convert.ToInt32(filter_value) < Convert.ToInt32(firm_value);
        }
    }

    public class ExpLT : ILogExp
    {
        public bool check(string filter_value, string firm_value)
        {
            return Convert.ToInt32(filter_value) > Convert.ToInt32(firm_value);
        }
    }
    public class ExpGreatDate : ILogExp
    {
        public bool check(string filter_value, string firm_value)
        {
            char separator = '.';
            string[] filter = filter_value.Split(separator);
            string[] firm = firm_value.Split(separator);

            if (filter.Length != firm.Length || filter.Length != 3) return false;

            if (Convert.ToInt32(filter[2]) < Convert.ToInt32(firm[2])) return true;
            else if (Convert.ToInt32(filter[2]) > Convert.ToInt32(firm[2])) return false;
            else if (Convert.ToInt32(filter[1]) < Convert.ToInt32(firm[1])) return true;
            else if (Convert.ToInt32(filter[1]) > Convert.ToInt32(firm[1])) return false;
            else if (Convert.ToInt32(filter[0]) < Convert.ToInt32(firm[0])) return true;
            else if (Convert.ToInt32(filter[0]) > Convert.ToInt32(firm[0])) return false;

            return false;
        }
    }

    public class ExpLessDate : ILogExp
    {
        public bool check(string filter_value, string firm_value)
        {
            char separator = '.';
            string[] filter = filter_value.Split(separator);
            string[] firm = firm_value.Split(separator);

            if (filter.Length != firm.Length || filter.Length != 3) return false;

            if (Convert.ToInt32(filter[2]) > Convert.ToInt32(firm[2])) return true;
            else if (Convert.ToInt32(filter[2]) < Convert.ToInt32(firm[2])) return false;
            else if (Convert.ToInt32(filter[1]) > Convert.ToInt32(firm[1])) return true;
            else if (Convert.ToInt32(filter[1]) < Convert.ToInt32(firm[1])) return false;
            else if (Convert.ToInt32(filter[0]) > Convert.ToInt32(firm[0])) return true;
            else if (Convert.ToInt32(filter[0]) < Convert.ToInt32(firm[0])) return false;

            return false;
        }
    }


}