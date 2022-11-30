using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandidateDetailsWebApp.Models
{
    public class Candidate
    {
        [Key]
        [Required]
        public int CandidateId { get; set; }

        [Required]
        public string Name { get; set;}

        [Required]
        public string Address { get; set;}

        [Required]
        public int Phone { get; set;}

        [Required]
        public string Qualification { get; set;}
    }
}