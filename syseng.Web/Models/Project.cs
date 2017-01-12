using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace syseng.Web.Models
{
    public class Project
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Customer { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int TypeId { get; set; }
    }
}