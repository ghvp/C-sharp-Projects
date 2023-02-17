using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class Dogs
    {
        public string Breed { get; set; }
        public string Weight { get; set; }

        public Dogs(string breed, string weight)
        {
            Breed = breed;
            Weight = weight;
        }

        public Dogs(string breed) : this(breed, "large")
        {

        }
    }
}
