using System;
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
    public partial class Form2 : Form
    {
        string username;
        string password;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ("root" == textBox1.Text && "root" == textBox2.Text)
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            try
            {
                var sr = new System.IO.StreamReader("C:\\" + textBox1.Text + "\\login.ID");
                username = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();
                
                if(username == textBox1.Text && password == textBox2.Text)
                {
                    this.Hide();
                    Form1 main = new Form1();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("ERROR ! Username or Password is WRONG !");
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show("The user dosen-t exist ! ", "Error");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 register = new Form3();
            register.Show();
        }
    }
}
