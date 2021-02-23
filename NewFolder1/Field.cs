using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{


    public abstract class Field
    {
        protected string nameField;
        protected string value;
        protected string fieldType;

        public string GetName() { return nameField; }
        public string GetValue() { return value; }
        public void SetValue(string newValue) { value = newValue; }
        public string TypeField() { return fieldType; }
        }
    class SurnameField : Field
    {
        public SurnameField()
        {
           nameField = "Фамилия"; fieldType = "string"; 
        }
    }
    class NameField : Field
    {
        public NameField()
        {
            nameField = "Имя"; fieldType = "string";
        }
        
    }
    class FamilyField : Field
    {
        public FamilyField()
        {
            nameField = "Отчество"; fieldType = "string";
        }
    }
    class DocumentField : Field
    {
        public DocumentField()
        {
            nameField = "Паспорт"; fieldType = "string";
        }
    }
    class CitizenshipField : Field
    {
        public CitizenshipField()
        {
            nameField = "Гражданство"; fieldType = "string";
        }
    }
    class CompanyField : Field
    {
        public CompanyField()
        {
            nameField = "Компания перелета"; fieldType = "string";
        }
    }
    class ClassField : Field
    {
        public ClassField()
        {
            nameField = "Класс"; fieldType = "string";
        }
    }
    class DateFromField : Field
    {
        public DateFromField()
        {
            nameField = "Дата отправления"; fieldType = "date";
        }
    }
    class CountryFromField : Field
    {
        public CountryFromField()
        {
            nameField = "Страна отправления"; fieldType = "string";
        }
    }
    class CountryToField : Field
    {
        public CountryToField()
        {
            nameField = "Страна прибытия"; fieldType = "string";
        }
    }
    
}