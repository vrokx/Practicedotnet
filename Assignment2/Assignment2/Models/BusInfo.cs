//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class BusInfo
    {
        [Key]
        [Required]
        public int BusID { get; set; }
        
        [Required]
        public string BoardingPoint { get; set; }

        [Required]
        public System.DateTime TravelDate { get; set; }
        
        [Required]
        public double Amount { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}