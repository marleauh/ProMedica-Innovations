using SQLite;

namespace ProMedica_Innovations.Models
{
    public class Idea
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }                  // primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public string CitizenshipStatus { get; set; }
        public string TargetMarket { get; set; }
        public string InvEmail { get; set; }
        public string Phone { get; set; }
        public string IdeaTitle { get; set; }
        public string Description { get; set; }
        public bool IsNewIdea { get; set; }
        public string Availability { get; set; }
        public string Referral { get; set;}
        public string Branch { get; set; }
        public bool Employee { get; set; }

        
    }
}