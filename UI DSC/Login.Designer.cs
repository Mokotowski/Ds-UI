namespace UI_DSC
{
    partial class LoginForm
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
            this.loginlbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.logintxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.wrongdata = new System.Windows.Forms.Label();
            this.hidepassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Location = new System.Drawing.Point(26, 104);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(33, 13);
            this.loginlbl.TabIndex = 2;
            this.loginlbl.Text = "Login";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(26, 142);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(36, 13);
            this.passwordlbl.TabIndex = 3;
            this.passwordlbl.Text = "Hasło";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(123, 189);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(117, 39);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Zaloguj";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // logintxt
            // 
            this.logintxt.Location = new System.Drawing.Point(87, 101);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(220, 20);
            this.logintxt.TabIndex = 5;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(87, 139);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(220, 20);
            this.passwordtxt.TabIndex = 6;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // wrongdata
            // 
            this.wrongdata.AutoSize = true;
            this.wrongdata.ForeColor = System.Drawing.Color.Red;
            this.wrongdata.Location = new System.Drawing.Point(120, 250);
            this.wrongdata.Name = "wrongdata";
            this.wrongdata.Size = new System.Drawing.Size(123, 13);
            this.wrongdata.TabIndex = 7;
            this.wrongdata.Text = "Błedne dane logowania!";
            this.wrongdata.Visible = false;
            // 
            // hidepassword
            // 
            this.hidepassword.AutoSize = true;
            this.hidepassword.Location = new System.Drawing.Point(221, 165);
            this.hidepassword.Name = "hidepassword";
            this.hidepassword.Size = new System.Drawing.Size(86, 17);
            this.hidepassword.TabIndex = 8;
            this.hidepassword.Text = "Pokaż hasło";
            this.hidepassword.UseVisualStyleBackColor = true;
            this.hidepassword.Click += new System.EventHandler(this.hidepassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(353, 340);
            this.Controls.Add(this.hidepassword);
            this.Controls.Add(this.wrongdata);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.logintxt);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.loginlbl);
            this.Name = "LoginForm";
            this.Text = "Discorrd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox logintxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label wrongdata;
        private System.Windows.Forms.CheckBox hidepassword;
    }
}