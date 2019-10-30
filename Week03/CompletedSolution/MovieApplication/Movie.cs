using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieApplication
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double ReviewScore { get; set; }
        public int Length { get; set;  }
        public string Director { get; set; }
        public string LeadActor { get; set; }


        public List<string> Actors;

        public Movie(string title, string genre, double reviewScore, string director, int length, string leadActor)
        {
            Title = title;
            Genre = genre;
            ReviewScore = reviewScore;
            Director = director;
            Length = length;
            LeadActor = leadActor;

        }


        public void DisplayInformation()
        {
            MessageBox.Show($"Title:{Title} \n Grenre: {Genre} \n ReviewScore: {ReviewScore} \n Director: {Director} \n Length: {Length} \n LeadActor: {LeadActor} ");
        }
    }
}
