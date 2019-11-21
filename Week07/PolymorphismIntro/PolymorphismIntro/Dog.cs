using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Dog : Animal, IMammal
    {
        public string Breed;

        public string HairColor { get; set; }

        public  override void Speak()
        {
            MessageBox.Show("Bark");
        }

        public Dog() { }

        public Dog(string breed, int height, string name, int weight)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
            this.Weight = weight;
            this.Type = "Dog";
        }
    }
}