using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    public class Passenger
    {
        public List<Field> fields;
        public Passenger()
        {
            fields = FieldTypeCol.get_value();
        }
    }


}