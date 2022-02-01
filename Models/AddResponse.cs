﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission4.Models
{
    public class AddResponse
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string Title { get; set; }

        //Foreign Key
        [Required]
        public int CategoryID { get; set; }
        public Category CategoryName { get; set; }
        [Required(ErrorMessage = ("Enter a valid Year."))]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
