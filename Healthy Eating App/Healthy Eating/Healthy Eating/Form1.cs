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


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //redirects user to another form/page
        private void secondPage_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form2 goToHealthyFoodPage = new Form2();
             
            //shows new form/page
            goToHealthyFoodPage.Show();

        }

        //redirects user to another form/page
        private void button3_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form3 goToExercisePage = new Form3();

            //shows new form/page
            goToExercisePage.Show();

        }

        //redirects user to another form/page
        private void button2_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form4 goToQuizPage = new Form4();

            //shows new form/page
            goToQuizPage.Show();

        }

        //redirects user to another form/page
        private void button1_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form5 goToToolsPage = new Form5();

            //shows new form/page
            goToToolsPage.Show();

        }

        //activates when picture is clicked
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           //Displays message
            MessageBox.Show("Welcome to the app! Please feel free to explore the application and click on the images to find out more.");

        }

       
      

       
    }
}
