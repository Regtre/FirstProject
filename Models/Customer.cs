using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Is Subscribe to newsletter")]
        public bool IsSubscribeToNewsletter { get; set; }

        //[Display(Name = "Membership Type")]

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }

        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Email{ get; set; }

        [Display(Name = "Date of Birth") ]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateOnly? BirthDate { get; set; }
    }
}