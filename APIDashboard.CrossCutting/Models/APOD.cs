﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDashboard.CrossCutting.Models
{
    public class APOD
    {
        public string Date { get; set; }
        public string Explanation { get; set; }
        public string Hdurl { get; set; }
        public string Media_type { get; set; }
        public string Service_version { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
