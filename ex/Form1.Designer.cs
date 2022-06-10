namespace ex
{
    partial class COCOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COCOA));
            this.firstname = new System.Windows.Forms.Label();
            this.txtbxFirstname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.BackColor = System.Drawing.Color.Transparent;
            this.firstname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.firstname.Location = new System.Drawing.Point(172, 274);
            this.firstname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(116, 26);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "First Name:";
            // 
            // txtbxFirstname
            // 
            this.txtbxFirstname.AccessibleName = "";
            this.txtbxFirstname.Location = new System.Drawing.Point(297, 271);
            this.txtbxFirstname.Margin = new System.Windows.Forms.Padding(6);
            this.txtbxFirstname.Name = "txtbxFirstname";
            this.txtbxFirstname.Size = new System.Drawing.Size(460, 33);
            this.txtbxFirstname.TabIndex = 1;
            this.txtbxFirstname.TextChanged += new System.EventHandler(this.txtbxFirstname_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(690, 619);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next -->";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtlast
            // 
            this.txtlast.AccessibleName = "";
            this.txtlast.Location = new System.Drawing.Point(297, 341);
            this.txtlast.Margin = new System.Windows.Forms.Padding(6);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(460, 33);
            this.txtlast.TabIndex = 3;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.BackColor = System.Drawing.Color.Transparent;
            this.lastname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lastname.Location = new System.Drawing.Point(172, 344);
            this.lastname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(113, 26);
            this.lastname.TabIndex = 4;
            this.lastname.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(118, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact Number:";
            // 
            // txtcontact
            // 
            this.txtcontact.AccessibleName = "";
            this.txtcontact.Location = new System.Drawing.Point(297, 415);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(6);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(460, 33);
            this.txtcontact.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.AccessibleName = "";
            this.txtemail.Location = new System.Drawing.Point(297, 491);
            this.txtemail.Margin = new System.Windows.Forms.Padding(6);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(460, 33);
            this.txtemail.TabIndex = 7;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(133, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(54, 559);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Town/ City of Residence";
            // 
            // txtcity
            // 
            this.txtcity.AccessibleName = "";
            this.txtcity.Location = new System.Drawing.Point(297, 556);
            this.txtcity.Margin = new System.Windows.Forms.Padding(6);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(460, 33);
            this.txtcity.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // COCOA
            // 
            this.AccessibleName = "fullname";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(896, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.txtlast);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbxFirstname);
            this.Controls.Add(this.firstname);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "COCOA";
            this.Text = "COCOA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox txtbxFirstname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

