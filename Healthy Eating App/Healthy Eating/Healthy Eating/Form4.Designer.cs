namespace Healthy_Eating
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.healthyEatingButton = new System.Windows.Forms.Button();
            this.exerciseButton = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(239, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 135);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // healthyEatingButton
            // 
            this.healthyEatingButton.Location = new System.Drawing.Point(151, 228);
            this.healthyEatingButton.Name = "healthyEatingButton";
            this.healthyEatingButton.Size = new System.Drawing.Size(99, 49);
            this.healthyEatingButton.TabIndex = 28;
            this.healthyEatingButton.Text = "Healthy Eating";
            this.healthyEatingButton.UseVisualStyleBackColor = true;
            this.healthyEatingButton.Click += new System.EventHandler(this.healthyEatingButton_Click);
            // 
            // exerciseButton
            // 
            this.exerciseButton.Location = new System.Drawing.Point(419, 228);
            this.exerciseButton.Name = "exerciseButton";
            this.exerciseButton.Size = new System.Drawing.Size(99, 49);
            this.exerciseButton.TabIndex = 27;
            this.exerciseButton.Text = "Exercise Plan";
            this.exerciseButton.UseVisualStyleBackColor = true;
            this.exerciseButton.Click += new System.EventHandler(this.exerciseButton_Click);
            // 
            // homebutton
            // 
            this.homebutton.Location = new System.Drawing.Point(278, 271);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(99, 49);
            this.homebutton.TabIndex = 25;
            this.homebutton.Text = "Home";
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Quiz";
            // 
            // toolButton
            // 
            this.toolButton.Location = new System.Drawing.Point(419, 336);
            this.toolButton.Name = "toolButton";
            this.toolButton.Size = new System.Drawing.Size(99, 49);
            this.toolButton.TabIndex = 33;
            this.toolButton.Text = "Useful Tools";
            this.toolButton.UseVisualStyleBackColor = true;
            this.toolButton.Click += new System.EventHandler(this.toolButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 434);
            this.Controls.Add(this.toolButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.healthyEatingButton);
            this.Controls.Add(this.exerciseButton);
            this.Controls.Add(this.homebutton);
            this.Name = "Form4";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button healthyEatingButton;
        private System.Windows.Forms.Button exerciseButton;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toolButton;
    }
}