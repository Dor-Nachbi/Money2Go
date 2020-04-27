using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Money2Go.Models
{
    public class Tranzaction
    {
        public int TranzactionId { get; set; }

        public int ProjectId { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [ForeignKey("ProjectId")]
        public Project project { get; set; }

        [Required]
        [Display(Name= "Amount")]
        public int Amount { get; set; }

        public DateTime DateT { get; set; }

    }
}