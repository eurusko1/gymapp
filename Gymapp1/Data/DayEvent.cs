using System;
using System.ComponentModel.DataAnnotations;

namespace Gymapp1.Data
{
    public class DayEvent
    {
        public int id { get; set; }
        public string Note { get; set; }
        public DateTime EventDate { get; set; } = new DateTime(1900, 1, 1);

        public DateTime FromDate { get; set; } = new DateTime(1900, 1, 1);
        public DateTime ToDate { get; set; } = new DateTime(1900, 1, 1);
        public string DateValue { get; set; }
        public string DayName { get; set; }
        public string Message { get; set; }
        public string idopont { get; set; }
        [Required(ErrorMessage = "A vezetéknév Kötelező!!")]
        [MinLength(1 , ErrorMessage = "A vezetéknév Kötelező!!! ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "A keresztnév Kötelező ")]
        [MinLength(1, ErrorMessage = "A keresztnév Kötelező!! ")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "A telefonszám Kötelező!! ")]
        [Phone]
        [MinLength(1, ErrorMessage = "A telefonszám Kötelező!! ")]
        public string Tel { get; set; }
        [Required(ErrorMessage = "A email Kötelező!! ")]
        [EmailAddress]
        [MinLength(1, ErrorMessage = "Az email Kötelező!! ")]
        public string Email { get; set; }
        public int BookingCount { get; set; } = 15;
        public DateTime Erkezes { get; set; } = new DateTime(1900, 1, 1,00,00,00);
        public DateTime tavozas { get; set; } = new DateTime(1900, 1, 1, 00, 00, 00);

    }
}
