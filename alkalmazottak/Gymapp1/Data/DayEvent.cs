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
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string Tel { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int BookingCount { get; set; } = 15;
        public DateTime Erkezes { get; set; } = new DateTime(1900, 1, 1,00,00,00);
        public DateTime tavozas { get; set; } = new DateTime(1900, 1, 1, 00, 00, 00);
    }
}
