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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        //activates when picture is clicked
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //displays message
            MessageBox.Show("Exercise is shown to help with stress");
        }

        //activates when picture is clicked
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //displays message
            MessageBox.Show("You only need to exercise for 30 mins a day to have a healthy lifestyle.");
        }

        //activates when picture is clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //displays message
            MessageBox.Show("Fat is shown to weigh less than muscle.");
        }

        
    }
}
