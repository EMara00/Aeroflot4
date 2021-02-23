using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    public class FieldTypeCol
    {
        static private List<Field> field;

        static public List<Field> get_value()
        {
            List<Field> newField = new List<Field>();

            newField.Add(new SurnameField());
            newField.Add(new NameField());
            newField.Add(new FamilyField());
            newField.Add(new DocumentField());
            newField.Add(new CitizenshipField());
            newField.Add(new CompanyField());
            newField.Add(new ClassField());
            newField.Add(new DateFromField());
            newField.Add(new CountryFromField());
            newField.Add(new CountryToField());

            return newField;
        }
        static public int GetSize()
        {
            return field.Count;
        }


        static FieldTypeCol()
        {
            field = get_value();
        }
    }
}