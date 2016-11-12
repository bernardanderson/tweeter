using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweeter.Models
{
    public class Twit
    {
        public int TwitId { get; set; }
        public Twit BaseUser { get; set; }
        public List<Twit> Follows { get; set; }
    }
}