﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter valid email adres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Please specify whether that you need")]
        public bool? WillAttend { get; set; }
    }
}
