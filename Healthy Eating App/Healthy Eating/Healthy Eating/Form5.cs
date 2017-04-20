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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //redirects user to new form/page
        private void healthyFoodPage_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form2 goToHealthyFoodPage = new Form2();

            //display new form/page
            goToHealthyFoodPage.Show();
        }

        //redirects user to new form/page
        private void homeButton_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form1 goToHome = new Form1();

            //display new form/page
            goToHome.Show();
        }

        //redirects user to new form/page
        private void exerciseButton_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form3 goToExercisePage = new Form3();

            //display new form/page
            goToExercisePage.Show();
        }

        //redirects user to new form/page
        private void quizButton_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form4 goToQuizPage = new Form4();

            //display new form/page
            goToQuizPage.Show();
        }

        //activates when picture is clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            //local variable that reads in the data inside the textbox and stores it in a integer value
            int waterValue;
            waterValue = Convert.ToInt32(waterBox.Text);
            waterValue = int.Parse(waterBox.Text);

            //if statement comparing the waterValue variable to see if it is less than 2000
            if (waterValue < 2000)
            {
                //displays message
                MessageBox.Show("You have not took in enough water for the day you still need to drink : " + (2000 - waterValue) + "ml's of water");
            }
            else
            {
                //displays message
                MessageBox.Show("Well done you have consumed enough water for the day");
            }
        }

        //activates when picture is clicked
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            //local variable that reads in the data inside the textbox and stores it in a integer value
            int textboxValue;
            textboxValue = Convert.ToInt32(textBox1.Text);
            textboxValue = int.Parse(textBox1.Text);
            
                
          
            //checks if checkbox is clicked
            if (checkBox1.Checked == true)

            {
                //local variable and sets it to 2500
                int calorie = 2500;
                

                //local variable made from data in previous variables
               int calorieIntake = calorie - textboxValue;

               //if statement comparing the calorieIntake variable is less than 0
                if (calorieIntake < 0 )
                {
                    //displays message
                    MessageBox.Show("You have eaten " + (-1 * calorieIntake) + " too many calories");
                }
                else
                {
                    //displays message
                    MessageBox.Show("Well done you ate enough calories");
                }

              }
            //checks if checkbox is clicked
            else if (checkBox2.Checked == true)
            {
                //local variable that is set to 2000
                int calorie = 2000;

                //local variable made from data from previous variables
                int calorieIntake = calorie - textboxValue;

                //if statement comparing the calorieIntake variable is less than 0
                if (calorieIntake < 0)
                {

                    //displays message
                    MessageBox.Show("You have eaten " + (-1 * calorieIntake) + " too many calories");
                }
                else
                {
                    //displays message
                    MessageBox.Show("Well done you ate enough calories");
                }

            }
            else
            {
                //displays message
                MessageBox.Show("Please select a option.");
                Close();


            }

            


        }
        
        //activates when picture is clicked
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //local variable that reads in the data inside the textbox and stores it in a integer value
            int heightValue;
            heightValue = Convert.ToInt32(heightBox.Text);
            heightValue = int.Parse(heightBox.Text);

            //local variable that reads in the data inside the textbox and stores it in a integer value
            int weightValue;
            weightValue = Convert.ToInt32(weightBox.Text);
            weightValue = int.Parse(weightBox.Text);

            //local variable made from previous data
            Single BMI = weightValue / heightValue;

            //displays message
            MessageBox.Show("Your BMI is : " + BMI);
        }


       
    }
}
