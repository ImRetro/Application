using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthy_Eating
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //redirects user to another form/page
        private void homebutton_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form1 goToHome = new Form1();

            //displays new form/page
            goToHome.Show();
        }

        //redirects user to another form/page
        private void exerciseButton_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form3 goToExercisePage = new Form3();

            //displays new form/page
            goToExercisePage.Show();
        }

        //redirects user to another form/page
        private void toolButton_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form5 goToToolsPage = new Form5();

            //displays new form/page
            goToToolsPage.Show();
        }

        //redirects user to another form/page
        private void healthyEatingButton_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form2 goToHealthyFoodPage = new Form2();

            //displays new form/page
            goToHealthyFoodPage.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //local variable
            int score = 0;

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 1 - Is Breakfast, lunch and dinner essential to a healthy lifestyle?", "" , MessageBoxButtons.YesNo) == DialogResult.Yes)    
            {
                //adds one to score
                score = score + 1;
            }
             else
            {
            }

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 2 - Is it recomeded to have 5 portions of fruit and veg nowadays?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //adds one to score
                score = score + 1;
            }
            else
            {
            }

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 3 - Does fat weigh more than muscle?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //adds one to score
                score = score + 1;
            }
            else
            {
            }

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 4 - Is water the healthiest drink?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //adds one to score
                score = score + 1;
            }
            else
            {
            }

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 5 - Can stress be relieved by exercise?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //adds one to score
                score = score + 1;
            }
            else
            {
            }

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 6 - Do you need at least half an hour of exercise per day?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //adds one to score
                score = score + 1;
            }
            else
            {
            }

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 7 - Is a BMI of 30 is considered underweight?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //adds one to score
                score = score + 1;
            }
            else
            {
            }

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 8 - Are vitamins found in both fruit and vegetables?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //adds one to score
                score = score + 1;
            }
            else
            {
            }

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 9 - Is obesity at an all time low?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //adds one to score
                score = score + 1;
            }
            else
            {
            }

            //asks user a question through a messagebox and gives the use a yes or no option
            if (MessageBox.Show("Question 10 - Is the UK the healthiest country?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //adds one to score
                score = score + 1;               
            }
            else
            {
            }

            //displays the users score in the quiz
            MessageBox.Show("You got " + score + "/10");

        }

       
    }
}
