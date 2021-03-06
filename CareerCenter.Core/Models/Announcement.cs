using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCenter.Core.Models
{
    public class Announcement : Base
    {
        [Required]
        public string Title { get; set; }

        
        public string Image { get; set; }
 
        [Required]
        public string Description { get; set; }
    }
}
