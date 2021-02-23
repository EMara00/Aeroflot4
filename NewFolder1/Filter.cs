using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    public class Filter
    {
        ILogExp expression;
        string name_field;
        string filter_value;

        public bool check(Passenger firm)
        {
            for (int i = 0; i < firm.fields.Count; ++i)
            {
                if (firm.fields[i].GetName() == name_field)
                    return expression.check(filter_value, firm.fields[i].GetValue());
            }
            return false;
        }

        public Filter(ILogExp new_expression, string new_name_field, string new_filter_value)
        {
            expression = new_expression;
            name_field = new_name_field;
            filter_value = new_filter_value;
        }
    }
}