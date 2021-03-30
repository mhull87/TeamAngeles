using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Bulletin
    {
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
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
        public string Speaker { get; set; } //needs a topic, will be shown in display all bulletins view but maybe not in printable bulletin

        [Display(Name = "Intermediate Hymn")]
        [RegularExpression(@"^[A-Z0-9#]+[a-zA-Z0-9 ,';!?#]*$")]
        public string IntermediateSong { get; set; } //needs a song # or who is performing

        [Display(Name = "Closing Hymn")]
        [RegularExpression(@"^[A-Z0-9#]+[a-zA-Z0-9 ,';!?#]*$")]
        [Required]
        public string ClosingSong { get; set; } //needs a song #

        [RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
        public string Benediction { get; set; }

    }
}
