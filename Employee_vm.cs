﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class EmployeeBase : EmployeeAdd
    {
        [Key]
        public int EmployeeId { get; set; }
    }

    public class EmployeeAdd
    {
        public EmployeeAdd()
        {
            //LastName = "";
            //FirstName = "";
            BirthDate = DateTime.Now.AddYears(-25);
            HireDate = DateTime.Now.AddYears(-25);

        }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        [StringLength(70)]
        public string Address { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(40)]
        public string State { get; set; }

        [StringLength(40)]
        public string Country { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

    }


    public class EmployeeEditContactInfo
    {
        public EmployeeEditContactInfo()
        {

        }

        [Key]
        public int EmployeeId { get; set; }

        [StringLength(70)]
        public string Address { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(40)]
        public string State { get; set; }

        [StringLength(40)]
        public string Country { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(60)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
        [Range(2,6,ErrorMessage = "Selected number must range from 2 to 6")]
        public int NumberOfWeeksVacation { get; set; }

    }
    public class EmployeeEditContactInfoForm : EmployeeEditContactInfo
    {

        public EmployeeEditContactInfoForm()
        {
            
        }
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

    }
}
