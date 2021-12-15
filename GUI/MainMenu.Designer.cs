
namespace GUI
{
    partial class MainMenu
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
            this.cMenu = new System.Windows.Forms.Button();
            this.bMenu = new System.Windows.Forms.Button();
            this.fMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cMenu
            // 
            this.cMenu.BackColor = System.Drawing.Color.Lavender;
            this.cMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMenu.Location = new System.Drawing.Point(336, 248);
            this.cMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cMenu.Name = "cMenu";
            this.cMenu.Size = new System.Drawing.Size(199, 89);
            this.cMenu.TabIndex = 11;
            this.cMenu.Text = "Customer Menu";
            this.cMenu.UseVisualStyleBackColor = false;
            this.cMenu.Click += new System.EventHandler(this.cMenu_Click);
            // 
            // bMenu
            // 
            this.bMenu.BackColor = System.Drawing.Color.Lavender;
            this.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMenu.Location = new System.Drawing.Point(571, 248);
            this.bMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(199, 89);
            this.bMenu.TabIndex = 10;
            this.bMenu.Text = "Booking Menu";
            this.bMenu.UseVisualStyleBackColor = false;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // fMenu
            // 
            this.fMenu.BackColor = System.Drawing.Color.Lavender;
            this.fMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMenu.Location = new System.Drawing.Point(92, 248);
            this.fMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fMenu.Name = "fMenu";
            this.fMenu.Size = new System.Drawing.Size(199, 89);
            this.fMenu.TabIndex = 9;
            this.fMenu.Text = "Flight Menu";
            this.fMenu.UseVisualStyleBackColor = false;
            this.fMenu.Click += new System.EventHandler(this.fMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to XYZ Flight Limited";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(901, 97);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(745, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 43);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(888, 559);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cMenu);
            this.Controls.Add(this.bMenu);
            this.Controls.Add(this.fMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cMenu;
        private System.Windows.Forms.Button bMenu;
        private System.Windows.Forms.Button fMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}