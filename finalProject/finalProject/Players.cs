using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace finalProject
{
    class Quiz
    {
        public string question1;
        public string question2;
        public string question3;
        public string question4;
        public string question5;

        public void Question1()
        {
            MessageBox.Show("Question 1: How many legs does an octopus have?");

        }

        public void Question2()
        {
            MessageBox.Show("Question2: How many legs does a centipede have?");

        }

        public void Question3()
        {
            MessageBox.Show("Question 3: At what height does space start?");
        }

        public void Question4()
        {
            MessageBox.Show("Question 4: What is the average speed of a donkey?");
        }

        public void Question5()
        {
            MessageBox.Show("Question 5: Who is the president of Portugal?");
        }


    }

    
}
