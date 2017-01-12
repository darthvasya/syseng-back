using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace syseng.Web.Models
{
    public class Feedback
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }

        public string Telephone { get; set; }

        [Required]
        public string Body { get; set; }

        [DefaultValue(false)]
        public bool Viewed { get; set; }
    }
}