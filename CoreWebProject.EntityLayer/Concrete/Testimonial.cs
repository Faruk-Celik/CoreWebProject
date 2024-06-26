﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebProject.EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
