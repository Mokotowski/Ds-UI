namespace UI_DSC
{
    partial class Registration
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
            this.regbtn = new System.Windows.Forms.Button();
            this.logintxtbox = new System.Windows.Forms.TextBox();
            this.nicktxtbox = new System.Windows.Forms.TextBox();
            this.passtxt2 = new System.Windows.Forms.TextBox();
            this.passtxt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hidepassword = new System.Windows.Forms.CheckBox();
            this.wrongdata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regbtn.Location = new System.Drawing.Point(101, 226);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(117, 39);
            this.regbtn.TabIndex = 0;
            this.regbtn.Text = "Zarejestruj się";
            this.regbtn.UseVisualStyleBackColor = false;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // logintxtbox
            // 
            this.logintxtbox.Location = new System.Drawing.Point(101, 88);
            this.logintxtbox.Name = "logintxtbox";
            this.logintxtbox.Size = new System.Drawing.Size(214, 20);
            this.logintxtbox.TabIndex = 1;
            // 
            // nicktxtbox
            // 
            this.nicktxtbox.Location = new System.Drawing.Point(101, 166);
            this.nicktxtbox.Name = "nicktxtbox";
            this.nicktxtbox.Size = new System.Drawing.Size(214, 20);
            this.nicktxtbox.TabIndex = 2;
            // 
            // passtxt2
            // 
            this.passtxt2.Location = new System.Drawing.Point(101, 140);
            this.passtxt2.Name = "passtxt2";
            this.passtxt2.Size = new System.Drawing.Size(214, 20);
            this.passtxt2.TabIndex = 3;
            this.passtxt2.TextChanged += new System.EventHandler(this.passtxt2_TextChanged);
            // 
            // passtxt1
            // 
            this.passtxt1.Location = new System.Drawing.Point(101, 114);
            this.passtxt1.Name = "passtxt1";
            this.passtxt1.Size = new System.Drawing.Size(214, 20);
            this.passtxt1.TabIndex = 4;
            this.passtxt1.TextChanged += new System.EventHandler(this.passtxt1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Powtórz hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nick";
            // 
            // hidepassword
            // 
            this.hidepassword.AutoSize = true;
            this.hidepassword.Location = new System.Drawing.Point(229, 192);
            this.hidepassword.Name = "hidepassword";
            this.hidepassword.Size = new System.Drawing.Size(86, 17);
            this.hidepassword.TabIndex = 9;
            this.hidepassword.Text = "Pokaż hasło";
            this.hidepassword.UseVisualStyleBackColor = true;
            this.hidepassword.Click += new System.EventHandler(this.hidepassword_Click);
            // 
            // wrongdata
            // 
            this.wrongdata.AutoSize = true;
            this.wrongdata.ForeColor = System.Drawing.Color.Red;
            this.wrongdata.Location = new System.Drawing.Point(87, 283);
            this.wrongdata.Name = "wrongdata";
            this.wrongdata.Size = new System.Drawing.Size(143, 13);
            this.wrongdata.TabIndex = 10;
            this.wrongdata.Text = "Istnieje konto o takim loginie!";
            this.wrongdata.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(353, 340);
            this.Controls.Add(this.wrongdata);
            this.Controls.Add(this.hidepassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtxt1);
            this.Controls.Add(this.passtxt2);
            this.Controls.Add(this.nicktxtbox);
            this.Controls.Add(this.logintxtbox);
            this.Controls.Add(this.regbtn);
            this.Name = "Registration";
            this.Text = "Discorrd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.TextBox logintxtbox;
        private System.Windows.Forms.TextBox nicktxtbox;
        private System.Windows.Forms.TextBox passtxt2;
        private System.Windows.Forms.TextBox passtxt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox hidepassword;
        private System.Windows.Forms.Label wrongdata;
    }
}