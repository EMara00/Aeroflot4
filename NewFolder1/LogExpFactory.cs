using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    public class LogExpFactory
    {
        LogExpEnum filters;

        public void add_filter(string field_name, string value, string type, int n_radio_but)
        {
            ILogExp new_expression;

            if (n_radio_but == 1) new_expression = new ExpEQ();
            else if (n_radio_but == 2) new_expression = new ExpNoEQ();
            else if (n_radio_but == 3)
            {
                if (type == "string") new_expression = new ExpContains();
                else if (type == "int") new_expression = new ExpGT();
                else new_expression = new ExpGreatDate();
            }
            else
            {
                if (type == "string") new_expression = new ExpNoContains();
                else if (type == "int") new_expression = new ExpLT();
                else new_expression = new ExpLessDate();
            }

            filters.AddFilter(new Filter(new_expression, field_name, value));
        }

        public LogExpEnum get_filters()
        {
            return filters;
        }



        public LogExpFactory()
        {
            filters = new LogExpEnum();
        }
    }
}