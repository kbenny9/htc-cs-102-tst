using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    public class Duck : Animal
    {
        private int v1;
        private string v2;
        private int v3;
        private double v4;

        public override void Speak()
        {
            MessageBox.Show("Quack");
        }

        public Duck() { }

        public Duck(int height, string name, int weight, int numLegs, double strideLength)
        {
            this.Height = height;
            this.Name = name;
            this.Weight = weight;
            this.Type = "Duck";
            this.NumLegs = numLegs;
            this.StrideLength = strideLength;
        }


    }
}