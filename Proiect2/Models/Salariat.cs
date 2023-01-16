﻿using Microsoft.Build.Evaluation;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proiect2.Models
{
    public class Salariat
    {
        
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


    }
}
