﻿using _2080600088_TruongMinhHuu_BigSchool_T1_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2080600088_TruongMinhHuu_BigSchool_T1_.ViewModels
{
    public class CourseViewModel
    {
        [Required] 
        public string Place { get; set; }
        [Required]
        public string Date { get; set;}
        [Required]
        [FutureDate]
        public string Time { get; set;}
        [Required]
        public byte Category { get; set;}
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime() { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }
    }
}