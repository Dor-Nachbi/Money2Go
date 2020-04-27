using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Money2Go.Models
{
    public class Comment
    {

        public int commentId { get; set; }

        public string OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public ApplicationUser owner { get; set; }

        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public Project project { get; set; }

        [Required]
        [Display(Name = "Comment")]
        public string theComment { get; set; }

        public Boolean RudeComment { get; set; }

        public DateTime dateSubmit { get; set; }
    }


}