using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Bulletin
    {
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime BulletinDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
        [Required]
        public string Conducting { get; set; }

        [Display(Name = "Opening Hymn")]
        [RegularExpression(@"^[A-Z0-9#]+[a-zA-Z0-9 ,';!?#]*$")]
        [Required]
        public string OpeningSong { get; set; } //needs a song #

        [RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
        public string Invocation { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [RegularExpression(@"^[A-Z0-9#]+[a-zA-Z0-9 ,';!?#]*$")]
        [Required]
        public string SacramentSong { get; set; } //needs a song #

        //[RegularExpression(@"^[A-Z]+[a-zA-Z] *$")]
        //public string Speaker { get; set; } //needs a topic, will be shown in display all bulletins view but maybe not in printable bulletin

        public string Topic { get; set; }

        [Display(Name = "Intermediate Hymn")]
        [RegularExpression(@"^[A-Z0-9#]+[a-zA-Z0-9 ,';!?#]*$")]
        public string IntermediateSong { get; set; } //needs a song # or who is performing

        [Display(Name = "Closing Hymn")]
        [RegularExpression(@"^[A-Z0-9#]+[a-zA-Z0-9 ,';!?#]*$")]
        [Required]
        public string ClosingSong { get; set; } //needs a song #

        [RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
        public string Benediction { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
        public string Speaker { get; internal set; }

        [NotMapped]
        public bool CheckSpeaker { get; set; }
    }
}
