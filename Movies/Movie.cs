using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Movies
{
    public class Movie
    {
        public string MovieTitle { get; set; }
        public string Director { get; set;}
        public List<string> Actors { get; set; }
        public List<Review> Reviews { get; set; }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var review in Reviews)
            {
                sb.AppendLine(review.ToString());
            }
            return "Reviews for '" + MovieTitle + "':\n" + sb;
        }
    }
}
