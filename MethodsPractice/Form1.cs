﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            /// TODO - Place method calls here

            PrintSignature();
            RectangleArea();
            AddNumber();
            CircleArea();
            MaxVal();
        }

        /// 1. Print a signature to the screen

        public void PrintSignature()
        {
            q1Output.Text = "Your's truly, \n\nGrace Hopper.";
        }

        /// 2. Create a method to calculate the area of a rectangle with
        /// dimensions 5x7, and then use the variables to display:
        /// 
        /// The area of a 5 x 7 rectangle is 35 units squared

        public void RectangleArea()
        {
            int width = 5;
            int height = 7;
            int area;

            area = width * height;

            q2Output.Text = $"The area of a {width} X {height} is {area} units squared";
        }

        /// 3. Create a method to get numbers from q3Num1Input and q3Num2Input,
        /// add them together, and then display output as follows:
        /// 
        /// 5 + 4 = 9 
        public void AddNumber()
        {
            int num1 = Convert.ToInt16(q3Num1Input.Text);
            int num2 = Convert.ToInt16(q3Num2Input.Text);

            int sum = num1 + num2;
            q3Output.Text = $"{num1} + {num2} = {sum}";
        }


        /// 4. Create a method to calculate the area of a circle based on  
        /// the radius entered in radiusInput, then display output as follows:
        /// 
        /// The area of a circle with radius of 4 is 50.24 units squared
        public void CircleArea()
        {
            int radius = Convert.ToInt32(radiusInput.Text);
            int pi = Convert.ToInt32(Math.PI);

            int area = pi * radius * radius;

            q4Output.Text = $"The area of circle with  radius of {radius} is {area} units squared";
        }


        /// 5. 3U Only - Create a method that will determine and display
        /// the maximum of 3 values entered into q5Num1Input, q5Num2Input,
        /// and q5Num3Input. Sample input and output is shown below:
        /// 
        /// Inputs: 5, 7, 2
        /// he largest value is 7
        public void MaxVal()
        {
            double num1 = Convert.ToDouble(q5Num1Input.Text);
            double num2 = Convert.ToDouble(q5Num2Input.Text);
            double num3 = Convert.ToDouble(q5Num3Input.Text);

            double maxval;

            if ((num1 > num2) && (num2 > num3))
            {
                maxval = num1;
            }
            else if ((num1 < num2) && (num2 < num3))
            {
                maxval = num3;
            }
            else
            {
                maxval = num2;
            }

            q5Output.Text = $"Inputs: {num1}, {num2}, {num3}\nThe largest value is {maxval}";
        }
    }
}