using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please complete the field", "Error");

                }
                else
                {
                    var sw = new System.IO.StreamWriter("C:\\" + textBox1.Text + "\\login.ID");
                    sw.Write(textBox1.Text + "\n" + textBox2.Text);
                    sw.Close();
                    this.Hide();
                    Form2 login = new Form2();
                    login.Show();
                }
                
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please complete the field", "Error");

                }
                else
                {
                    System.IO.Directory.CreateDirectory("C:\\" + textBox1.Text);
                    var sw = new System.IO.StreamWriter("C:\\" + textBox1.Text + "\\login.ID");
                    sw.Write(textBox1.Text + "\n" + textBox2.Text);
                    sw.Close();
                    this.Hide();
                    Form2 login = new Form2();
                    login.Show();
                }
            }
        }
    }
}
