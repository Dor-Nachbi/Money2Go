using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Money2Go.Models
{
    public class Project
    {

        public Project()
        {
            comments = new HashSet<Comment>();
        }
        public int ProjectId { get; set; }

        [Display(Name =" User ")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser user { get; set; }

        [Required]
        [Display(Name = "Project name")]
        public string ProjectName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Picture")]
        public string pic_path { get; set; }

        [Required]
        [Display(Name ="Video")]
        public string vid_path { get; set; }

        [Required]
        [Range(50,5000000,ErrorMessage = "Please enter a valid goal between {0} to {1}")]
        public int goal { get; set; }

        [Required]
        [Display(Name ="Category")]
        public string Category { get; set; }

        [Required]
        [Display(Name = "Comments")]
        public ICollection<Comment> comments { get; set; }


        [Display(Name = "Tranzactions")]
        public ICollection<Tranzaction> tranzaction { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime DateProject { get; set; }
    }
}