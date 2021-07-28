using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int yPos = 44;
        private int Nr = 1;

        private void CmdErzeugen_Click(object sender, EventArgs e)
        {
            Button neuerButton = new Button()
            {
                Location = new Point(12, yPos),
                Size = new Size(75, 26),
                Text = Nr + ""
            };

            neuerButton.Click += new EventHandler(NeuerButton_Click); // dem Ereignis "Click" wird ein neues Objekt vom Typ "EventHandler" zugeordnet
            Controls.Add(neuerButton); //fügt den neuen button hinzu;
            yPos = yPos + 32;
            Nr = Nr + 1;
        }

        private void NeuerButton_Click(object sender, EventArgs e)
        {
            Button cmd = sender as Button; //liefert die Info darüber welcher button gelöscht wurde an "cmd.text". Der operator "as" ermöglicht die Umwandlung von einem ungenauen typ (hier "object") in einen passenden typ (hier "Button");
            Controls.Remove(cmd);
            MessageBox.Show("Button" + cmd.Text + " wurde gelöscht");
        }
    }
}
