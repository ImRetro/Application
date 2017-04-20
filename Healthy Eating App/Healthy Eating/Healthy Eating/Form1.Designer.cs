namespace Healthy_Eating
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.healthyFoodPage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quizButton = new System.Windows.Forms.Button();
            this.exerciseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // healthyFoodPage
            // 
            this.healthyFoodPage.Location = new System.Drawing.Point(58, 220);
            this.healthyFoodPage.Name = "healthyFoodPage";
            this.healthyFoodPage.Size = new System.Drawing.Size(99, 49);
            this.healthyFoodPage.TabIndex = 2;
            this.healthyFoodPage.Text = "Healthy Food";
            this.healthyFoodPage.UseVisualStyleBackColor = true;
            this.healthyFoodPage.Click += new System.EventHandler(this.secondPage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(181, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 104);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // quizButton
            // 
            this.quizButton.Location = new System.Drawing.Point(58, 302);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(99, 49);
            this.quizButton.TabIndex = 5;
            this.quizButton.Text = "Quiz";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exerciseButton
            // 
            this.exerciseButton.Location = new System.Drawing.Point(326, 220);
            this.exerciseButton.Name = "exerciseButton";
            this.exerciseButton.Size = new System.Drawing.Size(99, 49);
            this.exerciseButton.TabIndex = 6;
            this.exerciseButton.Text = "Exercise Plan";
            this.exerciseButton.UseVisualStyleBackColor = true;
            this.exerciseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Home";
            // 
            // toolButton
            // 
            this.toolButton.Location = new System.Drawing.Point(326, 302);
            this.toolButton.Name = "toolButton";
            this.toolButton.Size = new System.Drawing.Size(99, 49);
            this.toolButton.TabIndex = 4;
            this.toolButton.Text = "Useful Tools";
            this.toolButton.UseVisualStyleBackColor = true;
            this.toolButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(497, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exerciseButton);
            this.Controls.Add(this.quizButton);
            this.Controls.Add(this.toolButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.healthyFoodPage);
            this.Name = "Form1";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button healthyFoodPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Button exerciseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toolButton;

       
    }
}

