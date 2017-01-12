using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace syseng.Web.Models
{
    public class Article
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public int CountView { get; set; }
    }
}