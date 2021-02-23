using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Aeroport.NewFolder1
{
    public class Passenger2
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Middlename { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Document { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Citizenship { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Class { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string ContryCityFrom { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string DateTimeFrom { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string ContryCityTo { get; set; }
    }

    public class Passenger2DBContext : DbContext
    {
        public DbSet<Passenger2> Passengers { get; set; }
    }
}
