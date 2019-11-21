using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    public class Dog : Animal
    {
        public string Breed;
        private string v1;
        private int v2;
        private string v3;
        private int v4;
        private int v5;

        public override void Speak()
        {
            MessageBox.Show("Bark");
        }

        public Dog() { }

        public Dog(string breed, int height, string name, int weight, int numLegs, double strideLength)

        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
            this.Weight = weight;
            this.Type = "Dog";
            this.NumLegs = numLegs;
            this.StrideLength = strideLength;

        }

   
    }
}