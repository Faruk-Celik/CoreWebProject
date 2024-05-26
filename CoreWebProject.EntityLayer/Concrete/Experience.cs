using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebProject.EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime SDate { get; set; }
       
    }
}
