using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JopWebsite.Models
{
    public class About
    {
        public string Name { get; set; }
        public string Discraption { get; set; }
        public string Image { get; set; }

        internal object ToList()
        {
            throw new NotImplementedException();
        }
    }
}