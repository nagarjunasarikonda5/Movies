using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Review
    {
        public string ReviewText { get; set; }
        public string ReviewerName { get; set; }
        public double Rating { get; set; }

        public override string ToString()
        {
            return ReviewText+" by " + ReviewerName+ " - " + Rating.ToString();
        }



    }
}
