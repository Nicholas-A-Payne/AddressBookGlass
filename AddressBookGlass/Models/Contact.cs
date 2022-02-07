﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBookGlass.Models
{
    public class Contact
    {
        //Primary Key
        public int Id { get; set; }

        // Foreign Key
        public string? UserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long", MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long", MinimumLength = 2)]
        public string? LastName { get; set; }


        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }

        [Required]
        public string? AddressOne { get; set; }
        public string? AdressTwo { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? State { get; set; }

        public int ZipCode { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Contact Image")]
        public IFormFile? ImageFile { get; set; }

        public byte[]? ImageData { get; set; }
        public string? ImageType { get; set; }

        // Navigation Properties
        public virtual AppUser? User { get; set; }
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    }
}
