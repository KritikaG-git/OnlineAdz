using System;
using System.Collections.Generic;

namespace OnlineAdz.Models
{
    public partial class UserAd
    {
        public int AdId { get; set; }
        public string CategoryId { get; set; } = null!;
        public string? Email { get; set; }
        public string AdName { get; set; } = null!;
        public string AdStatus { get; set; } = null!;
        public string UserInterest { get; set; } = null!;

        //public virtual CategoryAd Category { get; set; } = null!;
    }
}
