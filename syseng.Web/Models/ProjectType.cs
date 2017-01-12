using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace syseng.Web.Models
{
    public class ProjectType
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}