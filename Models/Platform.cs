using System;
using System.Collections.Generic;

namespace OnlineAdz.Models
{
    public partial class Platform
    {
        public string CategoryId { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public string AdDescription { get; set; } = null!;
        public string MainPlatform { get; set; } = null!;
    }
}
