using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDashboard.CrossCutting.Models
{
    public class Quote
    {
        public string id { get; set; }

        public string content { get; set; }

        public string author { get; set; }

        public string authorSlug { get; set; }

        public int length { get; set; }

        public string[] tags { get; set; }
    }
}
