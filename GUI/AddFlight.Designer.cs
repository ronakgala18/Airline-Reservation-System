
namespace GUI
{
    partial class AddFlight
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
            this.MainMenu = new System.Windows.Forms.Button();
            this.fMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fNumSeatText = new System.Windows.Forms.TextBox();
            this.fNumSeatsLabel = new System.Windows.Forms.Label();
            this.fNumLabel = new System.Windows.Forms.Label();
            this.fNumText = new System.Windows.Forms.TextBox();
            this.fDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fOriginText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Lavender;
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(589, 27);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(131, 43);
            this.MainMenu.TabIndex = 11;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // fMenu
            // 
            this.fMenu.BackColor = System.Drawing.Color.Lavender;
            this.fMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMenu.Location = new System.Drawing.Point(25, 117);
            this.fMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fMenu.Name = "fMenu";
            this.fMenu.Size = new System.Drawing.Size(233, 49);
            this.fMenu.TabIndex = 9;
            this.fMenu.Text = "Back to Flight Menu";
            this.fMenu.UseVisualStyleBackColor = false;
            this.fMenu.Click += new System.EventHandler(this.fMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(31, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add Flight ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fNumSeatText
            // 
            this.fNumSeatText.BackColor = System.Drawing.Color.Lavender;
            this.fNumSeatText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNumSeatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNumSeatText.Location = new System.Drawing.Point(458, 279);
            this.fNumSeatText.Name = "fNumSeatText";
            this.fNumSeatText.Size = new System.Drawing.Size(253, 38);
            this.fNumSeatText.TabIndex = 16;
            this.fNumSeatText.TextChanged += new System.EventHandler(this.fNumSeatText_TextChanged);
            // 
            // fNumSeatsLabel
            // 
            this.fNumSeatsLabel.AutoSize = true;
            this.fNumSeatsLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.fNumSeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNumSeatsLabel.ForeColor = System.Drawing.Color.Black;
            this.fNumSeatsLabel.Location = new System.Drawing.Point(155, 284);
            this.fNumSeatsLabel.Name = "fNumSeatsLabel";
            this.fNumSeatsLabel.Size = new System.Drawing.Size(247, 31);
            this.fNumSeatsLabel.TabIndex = 15;
            this.fNumSeatsLabel.Text = "Number Of Seats:";
            this.fNumSeatsLabel.Click += new System.EventHandler(this.fNumSeatsLabel_Click);
            // 
            // fNumLabel
            // 
            this.fNumLabel.AutoSize = true;
            this.fNumLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.fNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNumLabel.ForeColor = System.Drawing.Color.Black;
            this.fNumLabel.Location = new System.Drawing.Point(155, 230);
            this.fNumLabel.Name = "fNumLabel";
            this.fNumLabel.Size = new System.Drawing.Size(206, 31);
            this.fNumLabel.TabIndex = 13;
            this.fNumLabel.Text = "Flight Number:";
            this.fNumLabel.Click += new System.EventHandler(this.fNumLabel_Click);
            // 
            // fNumText
            // 
            this.fNumText.BackColor = System.Drawing.Color.Lavender;
            this.fNumText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNumText.Location = new System.Drawing.Point(458, 228);
            this.fNumText.Name = "fNumText";
            this.fNumText.Size = new System.Drawing.Size(253, 38);
            this.fNumText.TabIndex = 14;
            this.fNumText.TextChanged += new System.EventHandler(this.fNumText_TextChanged);
            // 
            // fDestination
            // 
            this.fDestination.BackColor = System.Drawing.Color.Lavender;
            this.fDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDestination.Location = new System.Drawing.Point(458, 389);
            this.fDestination.Name = "fDestination";
            this.fDestination.Size = new System.Drawing.Size(253, 38);
            this.fDestination.TabIndex = 20;
            this.fDestination.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(155, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Port Of Destination:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fOriginText
            // 
            this.fOriginText.BackColor = System.Drawing.Color.Lavender;
            this.fOriginText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fOriginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fOriginText.Location = new System.Drawing.Point(458, 334);
            this.fOriginText.Name = "fOriginText";
            this.fOriginText.Size = new System.Drawing.Size(253, 38);
            this.fOriginText.TabIndex = 18;
            this.fOriginText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(155, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Port Of Origin:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fSubmit
            // 
            this.fSubmit.BackColor = System.Drawing.Color.Lavender;
            this.fSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fSubmit.Location = new System.Drawing.Point(582, 447);
            this.fSubmit.Name = "fSubmit";
            this.fSubmit.Size = new System.Drawing.Size(129, 45);
            this.fSubmit.TabIndex = 21;
            this.fSubmit.Text = "Submit";
            this.fSubmit.UseVisualStyleBackColor = false;
            this.fSubmit.Click += new System.EventHandler(this.fSubmit_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(155, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 51);
            this.label5.TabIndex = 22;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(737, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 43);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(901, 97);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // AddFlight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(889, 568);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fSubmit);
            this.Controls.Add(this.fDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fOriginText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fNumSeatText);
            this.Controls.Add(this.fNumSeatsLabel);
            this.Controls.Add(this.fNumText);
            this.Controls.Add(this.fNumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.fMenu);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddFlight";
            this.Text = "Add Flight";
            this.Load += new System.EventHandler(this.AddFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button fMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fNumSeatText;
        private System.Windows.Forms.Label fNumSeatsLabel;
        private System.Windows.Forms.Label fNumLabel;
        private System.Windows.Forms.TextBox fNumText;
        private System.Windows.Forms.TextBox fDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fOriginText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}