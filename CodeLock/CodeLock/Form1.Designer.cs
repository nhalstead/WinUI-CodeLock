namespace CodeLock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Code2 = new System.Windows.Forms.TextBox();
            this.Code3 = new System.Windows.Forms.TextBox();
            this.Code4 = new System.Windows.Forms.TextBox();
            this.Code5 = new System.Windows.Forms.TextBox();
            this.Code6 = new System.Windows.Forms.TextBox();
            this.Code7 = new System.Windows.Forms.TextBox();
            this.Code8 = new System.Windows.Forms.TextBox();
            this.Code1 = new System.Windows.Forms.TextBox();
            this.Code9 = new System.Windows.Forms.TextBox();
            this.Codelabel = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Unsecure = new System.Windows.Forms.Label();
            this.Secure = new System.Windows.Forms.Label();
            this.AutoLock = new System.Windows.Forms.Timer(this.components);
            this.LockOutReset = new System.Windows.Forms.Timer(this.components);
            this.LockedOut = new System.Windows.Forms.Label();
            this.HelpProvider = new System.Windows.Forms.HelpProvider();
            this.CC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Code2
            // 
            this.Code2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Code2.Location = new System.Drawing.Point(58, 118);
            this.Code2.MaxLength = 1;
            this.Code2.Name = "Code2";
            this.Code2.PasswordChar = '^';
            this.Code2.ShortcutsEnabled = false;
            this.Code2.Size = new System.Drawing.Size(40, 38);
            this.Code2.TabIndex = 2;
            this.Code2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code2.UseSystemPasswordChar = true;
            this.Code2.TextChanged += new System.EventHandler(this.Code2_TextChanged);
            this.Code2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code2_KeyPress);
            // 
            // Code3
            // 
            this.Code3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Code3.Location = new System.Drawing.Point(104, 118);
            this.Code3.MaxLength = 1;
            this.Code3.Name = "Code3";
            this.Code3.PasswordChar = '^';
            this.Code3.ShortcutsEnabled = false;
            this.Code3.Size = new System.Drawing.Size(40, 38);
            this.Code3.TabIndex = 3;
            this.Code3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code3.UseSystemPasswordChar = true;
            this.Code3.TextChanged += new System.EventHandler(this.Code3_TextChanged);
            this.Code3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code3_KeyPress);
            // 
            // Code4
            // 
            this.Code4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Code4.Location = new System.Drawing.Point(150, 118);
            this.Code4.MaxLength = 1;
            this.Code4.Name = "Code4";
            this.Code4.PasswordChar = '^';
            this.Code4.ShortcutsEnabled = false;
            this.Code4.Size = new System.Drawing.Size(40, 38);
            this.Code4.TabIndex = 4;
            this.Code4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code4.UseSystemPasswordChar = true;
            this.Code4.TextChanged += new System.EventHandler(this.Code4_TextChanged);
            this.Code4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code4_KeyPress);
            // 
            // Code5
            // 
            this.Code5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Code5.Location = new System.Drawing.Point(196, 118);
            this.Code5.MaxLength = 1;
            this.Code5.Name = "Code5";
            this.Code5.PasswordChar = '^';
            this.Code5.ShortcutsEnabled = false;
            this.Code5.Size = new System.Drawing.Size(40, 38);
            this.Code5.TabIndex = 5;
            this.Code5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code5.UseSystemPasswordChar = true;
            this.Code5.TextChanged += new System.EventHandler(this.Code5_TextChanged);
            this.Code5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code5_KeyPress);
            // 
            // Code6
            // 
            this.Code6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Code6.Location = new System.Drawing.Point(242, 118);
            this.Code6.MaxLength = 1;
            this.Code6.Name = "Code6";
            this.Code6.PasswordChar = '^';
            this.Code6.ShortcutsEnabled = false;
            this.Code6.Size = new System.Drawing.Size(40, 38);
            this.Code6.TabIndex = 6;
            this.Code6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code6.UseSystemPasswordChar = true;
            this.Code6.TextChanged += new System.EventHandler(this.Code6_TextChanged);
            this.Code6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code6_KeyPress);
            // 
            // Code7
            // 
            this.Code7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Code7.Location = new System.Drawing.Point(288, 118);
            this.Code7.MaxLength = 1;
            this.Code7.Name = "Code7";
            this.Code7.PasswordChar = '^';
            this.Code7.ShortcutsEnabled = false;
            this.Code7.Size = new System.Drawing.Size(40, 38);
            this.Code7.TabIndex = 7;
            this.Code7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code7.UseSystemPasswordChar = true;
            this.Code7.TextChanged += new System.EventHandler(this.Code7_TextChanged);
            this.Code7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code7_KeyPress);
            // 
            // Code8
            // 
            this.Code8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Code8.Location = new System.Drawing.Point(334, 118);
            this.Code8.MaxLength = 1;
            this.Code8.Name = "Code8";
            this.Code8.PasswordChar = '^';
            this.Code8.ShortcutsEnabled = false;
            this.Code8.Size = new System.Drawing.Size(40, 38);
            this.Code8.TabIndex = 8;
            this.Code8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code8.UseSystemPasswordChar = true;
            this.Code8.TextChanged += new System.EventHandler(this.Code8_TextChanged);
            this.Code8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code8_KeyPress);
            // 
            // Code1
            // 
            this.Code1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Code1.Location = new System.Drawing.Point(12, 118);
            this.Code1.MaxLength = 1;
            this.Code1.Name = "Code1";
            this.Code1.PasswordChar = '^';
            this.Code1.ShortcutsEnabled = false;
            this.Code1.Size = new System.Drawing.Size(40, 38);
            this.Code1.TabIndex = 1;
            this.Code1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code1.UseSystemPasswordChar = true;
            this.Code1.TextChanged += new System.EventHandler(this.Code1_TextChanged);
            this.Code1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code1_KeyPress);
            // 
            // Code9
            // 
            this.Code9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Code9.Location = new System.Drawing.Point(380, 118);
            this.Code9.MaxLength = 1;
            this.Code9.Name = "Code9";
            this.Code9.PasswordChar = '^';
            this.Code9.ShortcutsEnabled = false;
            this.Code9.Size = new System.Drawing.Size(40, 38);
            this.Code9.TabIndex = 9;
            this.Code9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code9.UseSystemPasswordChar = true;
            this.Code9.TextChanged += new System.EventHandler(this.Code9_TextChanged);
            this.Code9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code9_KeyPress);
            // 
            // Codelabel
            // 
            this.Codelabel.AutoSize = true;
            this.Codelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Codelabel.Location = new System.Drawing.Point(73, 55);
            this.Codelabel.Name = "Codelabel";
            this.Codelabel.Size = new System.Drawing.Size(291, 31);
            this.Codelabel.TabIndex = 11;
            this.Codelabel.Text = "Please Enter your Key!";
            this.Codelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.OrangeRed;
            this.ActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ActionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActionButton.Location = new System.Drawing.Point(12, 195);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(323, 85);
            this.ActionButton.TabIndex = 10;
            this.ActionButton.Text = "Click here!";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Visible = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.CadetBlue;
            this.CancelButton.Location = new System.Drawing.Point(345, 195);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 85);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Unsecure
            // 
            this.Unsecure.AutoSize = true;
            this.Unsecure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.Unsecure.ForeColor = System.Drawing.Color.Red;
            this.Unsecure.Location = new System.Drawing.Point(367, 295);
            this.Unsecure.Name = "Unsecure";
            this.Unsecure.Size = new System.Drawing.Size(60, 15);
            this.Unsecure.TabIndex = 13;
            this.Unsecure.Text = "Unsecure";
            this.Unsecure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Unsecure.Visible = false;
            // 
            // Secure
            // 
            this.Secure.AutoSize = true;
            this.Secure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.Secure.ForeColor = System.Drawing.Color.Green;
            this.Secure.Location = new System.Drawing.Point(377, 295);
            this.Secure.Name = "Secure";
            this.Secure.Size = new System.Drawing.Size(53, 15);
            this.Secure.TabIndex = 14;
            this.Secure.Text = "Secured";
            this.Secure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Secure.Visible = false;
            // 
            // AutoLock
            // 
            this.AutoLock.Interval = 10000;
            this.AutoLock.Tick += new System.EventHandler(this.AutoLock_Tick);
            // 
            // LockOutReset
            // 
            this.LockOutReset.Interval = 30000;
            this.LockOutReset.Tick += new System.EventHandler(this.LockOut_Tick);
            // 
            // LockedOut
            // 
            this.LockedOut.AutoSize = true;
            this.LockedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.LockedOut.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.LockedOut.Location = new System.Drawing.Point(358, 295);
            this.LockedOut.Name = "LockedOut";
            this.LockedOut.Size = new System.Drawing.Size(69, 15);
            this.LockedOut.TabIndex = 15;
            this.LockedOut.Text = "Locked Out";
            this.LockedOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LockedOut.Visible = false;
            // 
            // HelpProvider
            // 
            this.HelpProvider.HelpNamespace = "C:\\Users\\Noah Halstead\\Programming\\Windows\\Visual Studio 2013\\CodeLock\\Help.html";
            // 
            // CC
            // 
            this.CC.AutoSize = true;
            this.CC.Location = new System.Drawing.Point(2, 296);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(21, 13);
            this.CC.TabIndex = 16;
            this.CC.Text = "CC";
            this.CC.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 311);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.Secure);
            this.Controls.Add(this.Unsecure);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.Codelabel);
            this.Controls.Add(this.Code9);
            this.Controls.Add(this.Code1);
            this.Controls.Add(this.Code8);
            this.Controls.Add(this.Code7);
            this.Controls.Add(this.Code6);
            this.Controls.Add(this.Code5);
            this.Controls.Add(this.Code4);
            this.Controls.Add(this.Code3);
            this.Controls.Add(this.Code2);
            this.Controls.Add(this.LockedOut);
            this.HelpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Index);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(448, 350);
            this.Name = "Form1";
            this.HelpProvider.SetShowHelp(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Lock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Code2;
        private System.Windows.Forms.TextBox Code3;
        private System.Windows.Forms.TextBox Code4;
        private System.Windows.Forms.TextBox Code5;
        private System.Windows.Forms.TextBox Code6;
        private System.Windows.Forms.TextBox Code7;
        private System.Windows.Forms.TextBox Code8;
        private System.Windows.Forms.TextBox Code1;
        private System.Windows.Forms.TextBox Code9;
        private System.Windows.Forms.Label Codelabel;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label Unsecure;
        private System.Windows.Forms.Label Secure;
        private System.Windows.Forms.Timer AutoLock;
        private System.Windows.Forms.Timer LockOutReset;
        private System.Windows.Forms.Label LockedOut;
        private System.Windows.Forms.HelpProvider HelpProvider;
        private System.Windows.Forms.Label CC;
    }
}

