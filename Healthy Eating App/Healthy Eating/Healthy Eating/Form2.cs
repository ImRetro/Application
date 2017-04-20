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
    public partial class Form2 : Form
    {  
        public Form2()
        {
            InitializeComponent();
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
        private void quizButton_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form4 goToQuizPage = new Form4();

            //displays new form/page
            goToQuizPage.Show();
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
        private void homebutton_Click(object sender, EventArgs e)
        {
            //hides current form/page
            this.Hide();

            //local variable
            Form1 goToHome = new Form1();

            //displays new form/page
            goToHome.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //activates when picture is clicked
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Displays a message
            MessageBox.Show("Did you know? Originally it was recomended that people should take at least 5 portions of fruit and veg per day. However this has since been changed to 10 a day due to recent studies.");

        }

        //activates when picture is clicked
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Displays a message
            MessageBox.Show("Orange juice only has 8g of sugar while coke has 11g of sugar, showing that water is still the best drink for a healthy lifestyle.");
        }

        //activates when picture is clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Displays a message
            MessageBox.Show("It is always recomended that you should NEVER skip breakfast as this will help start up your digestive system and will not leave you hungry for the rest of the day.");

        }

        

    }
}
