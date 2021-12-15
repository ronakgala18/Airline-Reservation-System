
namespace GUI
{
    partial class FlightMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.addFlight = new System.Windows.Forms.Button();
            this.deleteFlight = new System.Windows.Forms.Button();
            this.viewAllFlight = new System.Windows.Forms.Button();
            this.viewParticularflight = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Flight Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addFlight
            // 
            this.addFlight.BackColor = System.Drawing.Color.Lavender;
            this.addFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFlight.Location = new System.Drawing.Point(174, 223);
            this.addFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addFlight.Name = "addFlight";
            this.addFlight.Size = new System.Drawing.Size(225, 72);
            this.addFlight.TabIndex = 9;
            this.addFlight.Text = " Add Flight";
            this.addFlight.UseVisualStyleBackColor = false;
            this.addFlight.Click += new System.EventHandler(this.addFlight_Click);
            // 
            // deleteFlight
            // 
            this.deleteFlight.BackColor = System.Drawing.Color.Lavender;
            this.deleteFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFlight.Location = new System.Drawing.Point(174, 318);
            this.deleteFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteFlight.Name = "deleteFlight";
            this.deleteFlight.Size = new System.Drawing.Size(225, 72);
            this.deleteFlight.TabIndex = 10;
            this.deleteFlight.Text = "Delete Flight";
            this.deleteFlight.UseVisualStyleBackColor = false;
            this.deleteFlight.Click += new System.EventHandler(this.deleteFlight_Click);
            // 
            // viewAllFlight
            // 
            this.viewAllFlight.BackColor = System.Drawing.Color.Lavender;
            this.viewAllFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllFlight.Location = new System.Drawing.Point(494, 223);
            this.viewAllFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewAllFlight.Name = "viewAllFlight";
            this.viewAllFlight.Size = new System.Drawing.Size(225, 72);
            this.viewAllFlight.TabIndex = 11;
            this.viewAllFlight.Text = "View All Flight";
            this.viewAllFlight.UseVisualStyleBackColor = false;
            this.viewAllFlight.Click += new System.EventHandler(this.viewAllFlight_Click);
            // 
            // viewParticularflight
            // 
            this.viewParticularflight.BackColor = System.Drawing.Color.Lavender;
            this.viewParticularflight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewParticularflight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewParticularflight.Location = new System.Drawing.Point(494, 317);
            this.viewParticularflight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewParticularflight.Name = "viewParticularflight";
            this.viewParticularflight.Size = new System.Drawing.Size(225, 73);
            this.viewParticularflight.TabIndex = 12;
            this.viewParticularflight.Text = "View\r\nParticular Flight";
            this.viewParticularflight.UseVisualStyleBackColor = false;
            this.viewParticularflight.Click += new System.EventHandler(this.viewParticularflight_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(588, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 43);
            this.button2.TabIndex = 43;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(731, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 43);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 97);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // FlightMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(892, 585);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.viewParticularflight);
            this.Controls.Add(this.viewAllFlight);
            this.Controls.Add(this.deleteFlight);
            this.Controls.Add(this.addFlight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FlightMenu";
            this.Text = "Flight Menu";
            this.Load += new System.EventHandler(this.FlightMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addFlight;
        private System.Windows.Forms.Button deleteFlight;
        private System.Windows.Forms.Button viewAllFlight;
        private System.Windows.Forms.Button viewParticularflight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}