using System;
using System.Collections.Generic;

namespace OnlineAdz.Models
{
    public partial class CategoryAd
    {
        /*public CategoryAd()
        {
            UserAds = new HashSet<UserAd>();
        }
        */
        public string CategoryId { get; set; } = null!;
        public string CategoryName { get; set; } = null!;

        //public virtual ICollection<UserAd> UserAds { get; set; }
    }
}
