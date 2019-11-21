using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    class StarWarsRobot : Robot
    {
        int InNumberOfMovies { get; set; }

        public StarWarsRobot(int inNumberOfMovies, int numLegs, double strideLength)
        {
            this.InNumberOfMovies = inNumberOfMovies;
            this.StrideLength = strideLength;
            this.NumLegs = numLegs;
 
        }


    }
}
