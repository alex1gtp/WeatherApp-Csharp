using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherLib;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            var location = new Location(textBox1.Text);
                OpenWeatherMapService.SetKey("7a27417787c2bea7d429df742eaf139d");
                var service =
                    WeatherDataServiceFactory.GetWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP);
                 var history = textBox1.Text;
                var data = service.GetWeatherData(location);
                var dataText = data;
                //Convert.ToString(dataText);
                richTextBox1.AppendText(Convert.ToString(dataText));
                richTextBox2.AppendText("\n" + history);
                //richTextBox1.AppendText = data.ToString();
                Console.Write(data.ToString());
               /*
                var c = Console.ReadKey();
                Console.Clear();
                if (c.KeyChar == 'n')
                {
                    Console.WriteLine("Bye Bye!");
                    break;
                }*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        [STAThread]
        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveFileDialog1.FileName;
            File.WriteAllText(fileName, richTextBox1.Text);
        }
    }
}
