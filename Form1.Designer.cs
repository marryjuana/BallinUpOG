
namespace Balling_up
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBallUp = new System.Windows.Forms.Label();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUpBall = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBallUp
            // 
            this.lblBallUp.AutoSize = true;
            this.lblBallUp.Location = new System.Drawing.Point(11, 5);
            this.lblBallUp.Name = "lblBallUp";
            this.lblBallUp.Size = new System.Drawing.Size(141, 20);
            this.lblBallUp.TabIndex = 0;
            this.lblBallUp.Text = "Do you ball up bro?";
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(11, 42);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(48, 24);
            this.radYes.TabIndex = 1;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(11, 73);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(71, 24);
            this.radNo.TabIndex = 2;
            this.radNo.TabStop = true;
            this.radNo.Text = "no bro";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(11, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Answer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUpBall
            // 
            this.lblUpBall.AutoSize = true;
            this.lblUpBall.Location = new System.Drawing.Point(11, 154);
            this.lblUpBall.Name = "lblUpBall";
            this.lblUpBall.Size = new System.Drawing.Size(0, 20);
            this.lblUpBall.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(107, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblUpBall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radNo);
            this.Controls.Add(this.radYes);
            this.Controls.Add(this.lblBallUp);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Balling up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBallUp;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUpBall;
        private System.Windows.Forms.Button button2;
    }
}

