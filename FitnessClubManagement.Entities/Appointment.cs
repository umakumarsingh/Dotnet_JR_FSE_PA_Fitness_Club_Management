using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessClubManagement.Entities
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Current Weight")]
        public int CurrentWeight { get; set; }
        public float Height { get; set; }
        public int Age { get; set; }
        [Display(Name = "Goal Weight")]
        public int GoalWeight { get; set; }
        public string Address { get; set; }
        [Display(Name = "Phone")]
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Remark { get; set; }

    }
}
