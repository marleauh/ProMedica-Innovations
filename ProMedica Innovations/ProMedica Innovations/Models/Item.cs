using System;

namespace ProMedica_Innovations.Models
{
    public class Idea
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Description { get; set; }

        public string Availability { get; set; }

        public string Referral { get; set; }

        public bool Employee { get; set; }
    }
}