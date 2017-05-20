using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace CodeLock
{
    public partial class Form1 : Form
    {
        static string XMLFileFullDir = Environment.CurrentDirectory + "/setup.xml";
        static string XMLFileFullCD = "setup.xml";

        int TryCount = 0;
        int MaxTry = 2;
        int LockOutTime = 10; //In Seconds
        Boolean ResetOnLockOut = false;
        string UnlockKey = "";
        XmlDocument XMLDOC = new XmlDocument();
        static string CASTEDVAIRIBLES = "CodeLock/";

    #region Root of the code
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(XMLFileFullCD) == true)
            {
                XMLDOC.Load(XMLFileFullCD);

                try {
                    UnlockKey = "";
                    UnlockKey = Convert.ToString(XMLDOC.SelectSingleNode(CASTEDVAIRIBLES + "Key").InnerText); 
                } catch { }

                try { 
                    MaxTry = Convert.ToInt32(XMLDOC.SelectSingleNode(CASTEDVAIRIBLES + "MaxTry").InnerText); 
                } catch { }

                try { 
                    LockOutTime = Convert.ToInt32(XMLDOC.SelectSingleNode(CASTEDVAIRIBLES + "LockOutTime").InnerText); 
                } catch { }

                try { 
                    ResetOnLockOut = Convert.ToBoolean(XMLDOC.SelectSingleNode(CASTEDVAIRIBLES + "ResetOnLockOut").InnerText); 
                } catch { }

                CC.Visible = true;
            }
            else
            {
                CC.BackColor = Color.IndianRed;
                CC.Visible = true;
            }

            LockOutReset.Interval = LockOutTime * 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void Code1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                Code1.Text = "";
            }
        }

        private void Code2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                Code2.Text = "";
                Code1.Focus();
            }
        }

        private void Code3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                Code3.Text = "";
                Code2.Focus();
            }
        }

        private void Code4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                Code4.Text = "";
                Code3.Focus();
            }
        }

        private void Code5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                Code5.Text = "";
                Code4.Focus();
            }
        }

        private void Code6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                Code6.Text = "";
                Code5.Focus();
            }
        }

        private void Code7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                Code7.Text = "";
                Code6.Focus();
            }
        }

        private void Code8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                Code8.Text = "";
                Code7.Focus();
            }
        }

        private void Code9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                Code9.Text = "";
                Code8.Focus();
            }
        }

        private void Code1_TextChanged(object sender, EventArgs e)
        {
            if (Code1.TextLength >= 1)
            {
                Code2.Focus();
            }
        }

        private void Code2_TextChanged(object sender, EventArgs e)
        {
            if (Code2.TextLength >= 1)
            {
                Code3.Focus();
            }
        }

        private void Code3_TextChanged(object sender, EventArgs e)
        {
            if (Code3.TextLength >= 1)
            {
                Code4.Focus();
            }
        }

        private void Code4_TextChanged(object sender, EventArgs e)
        {
            if (Code4.TextLength >= 1)
            {
                Code5.Focus();
            }
        }

        private void Code5_TextChanged(object sender, EventArgs e)
        {
            if (Code5.TextLength >= 1)
            {
                Code6.Focus();
            }
        }

        private void Code6_TextChanged(object sender, EventArgs e)
        {
            if (Code6.TextLength >= 1)
            {
                Code7.Focus();
            }
        }

        private void Code7_TextChanged(object sender, EventArgs e)
        {
            if (Code7.TextLength >= 1)
            {
                Code8.Focus();
            }
        }

        private void Code8_TextChanged(object sender, EventArgs e)
        {
            if (Code8.TextLength >= 1)
            {
                Code9.Focus();
            }
        }

        private void Code9_TextChanged(object sender, EventArgs e)
        {
            if (Code9.TextLength >= 1)
            {
                string CODE = Code1.Text + Code2.Text + Code3.Text + Code4.Text + Code5.Text + Code6.Text + Code7.Text + Code8.Text + Code9.Text;
                Setup();
                //MessageBox.Show(CODE , "Here is your Key!");
                CheckCode(CODE);
            }
        }

        private void Setup()
        {
            ClearBox();
            ActionButton.Visible = false;
            ActionButton.Enabled = false;
            CancelButton.Visible = false;
            Secure.Visible = true;
            Unsecure.Visible = false;
            LockedOut.Visible = false;
            AutoLock.Stop();
            LockOutReset.Stop();
            Code1.Focus();
        }

        private void ClearBox()
        {
            Code1.Text = "";
            Code2.Text = "";
            Code3.Text = "";
            Code4.Text = "";
            Code5.Text = "";
            Code6.Text = "";
            Code7.Text = "";
            Code8.Text = "";
            Code9.Text = "";
        }

        private void DenyKey()
        {
            Codelabel.Enabled = false;
            Code1.Enabled = false;
            Code2.Enabled = false;
            Code3.Enabled = false;
            Code4.Enabled = false;
            Code5.Enabled = false;
            Code6.Enabled = false;
            Code7.Enabled = false;
            Code8.Enabled = false;
            Code9.Enabled = false;
        }

        private void AllowKey()
        {
            Codelabel.Enabled = true;
            Code1.Enabled = true;
            Code2.Enabled = true;
            Code3.Enabled = true;
            Code4.Enabled = true;
            Code5.Enabled = true;
            Code6.Enabled = true;
            Code7.Enabled = true;
            Code8.Enabled = true;
            Code9.Enabled = true;
        }

        private void AutoLock_Tick(object sender, EventArgs e)
        {
            AllowKey();
            ActionButton.Visible = false;
            ActionButton.Enabled = false;
            CancelButton.Visible = false;
            Secure.Visible = true;
            Unsecure.Visible = false;
            AutoLock.Stop();
            Code1.Focus();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AllowKey();
            ActionButton.Visible = false;
            ActionButton.Enabled = false;
            CancelButton.Visible = false;
            Secure.Visible = true;
            Unsecure.Visible = false;
            AutoLock.Stop();
            Code1.Focus();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            AllowKey();
            ActionButton.Visible = false;
            ActionButton.Enabled = false;
            CancelButton.Visible = false;
            Secure.Visible = true;
            Unsecure.Visible = false;
            AutoLock.Stop();
            Code1.Focus();

            // Action of the Button
            ActionStart();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Escape)
            {
                AllowKey();
                ActionButton.Visible = false;
                ActionButton.Enabled = false;
                CancelButton.Visible = false;
                Secure.Visible = true;
                Unsecure.Visible = false;
                AutoLock.Stop();
                Code1.Focus();
            }

            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                AllowKey();
                ActionButton.Visible = false;
                ActionButton.Enabled = false;
                CancelButton.Visible = false;
                Secure.Visible = true;
                Unsecure.Visible = false;
                AutoLock.Stop();
                Code1.Focus();

                // Action of the Button
                ActionStart();
            }

            if (e.KeyChar == (char)ConsoleKey.Backspace)
            {
                AllowKey();
                ActionButton.Visible = false;
                ActionButton.Enabled = false;
                CancelButton.Visible = false;
                Secure.Visible = true;
                Unsecure.Visible = false;
                AutoLock.Stop();
                Code1.Focus();
            }
        }

        private void LockOut_Tick(object sender, EventArgs e)
        {
            AllowKey();
            ActionButton.Visible = false;
            ActionButton.Enabled = false;
            CancelButton.Visible = false;
            Secure.Visible = true;
            Unsecure.Visible = false;
            LockedOut.Visible = false;

            if (ResetOnLockOut == true)
            {
                TryCount = 0;
            }

            Setup();
            LockOutReset.Stop();
        }

        private void CheckCode(string Key)
        {
            if (Key == UnlockKey)
            {
                DenyKey();
                TryCount = 0;
                ActionButton.Visible = true;
                ActionButton.Enabled = true;
                CancelButton.Visible = true;
                Secure.Visible = false;
                Unsecure.Visible = true;
                AutoLock.Start();
                this.Focus();
            }
            else
            {
                TryCount++;
                if (TryCount >= MaxTry)
                {
                    DenyKey();
                    ActionButton.Visible = false;
                    ActionButton.Enabled = false;
                    CancelButton.Visible = false;
                    Secure.Visible = false;
                    Unsecure.Visible = false;
                    LockedOut.Visible = true;
                    LockOutReset.Start();
                }
            }
        }

    #endregion

        private void ActionStart()
        {
            MessageBox.Show("No action specified!", "Action Undefined");

        }

    }
}
