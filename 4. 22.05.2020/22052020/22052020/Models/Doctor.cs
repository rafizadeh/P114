using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _22052020.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Fullname { get; set; }

        [Required, MinLength(400)]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Photo { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Facebook { get; set; }

        [StringLength(100)]
        public string Linkedin { get; set; }

        [StringLength(200)]
        public string Speciality { get; set; }

        [StringLength(200)]
        public string ExpertIn { get; set; }

        [StringLength(200)]
        public string Degree { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }


    }
}