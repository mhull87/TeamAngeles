using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }
        public int BulletinID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string LastName { get; set; }

        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string Topic { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [NotMapped]
        public bool CheckSpeaker { get; set; }

        public bool BeforeHymn { get; set; }
    }
}
