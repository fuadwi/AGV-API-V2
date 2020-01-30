using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatching_API
{
    public partial class configForm : Form
    {

       
        public configForm()
        {
            InitializeComponent();
        }

        Form testPageVar = new testPage();        

        [Obsolete]
      
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            textBox7.Focus();
            ScanPort();
            LoadConfiguration();
        }

        [Obsolete]
        private void LoadConfiguration()
        {
            comboBox1.Text = System.Configuration.ConfigurationSettings.AppSettings["comPort"]; 
            textBox1.Text = System.Configuration.ConfigurationSettings.AppSettings["comBaud"];
            textBox2.Text = System.Configuration.ConfigurationSettings.AppSettings["listenHost"];
            textBox3.Text = System.Configuration.ConfigurationSettings.AppSettings["listenPort"];
            textBox4.Text = System.Configuration.ConfigurationSettings.AppSettings["uname"];
            textBox5.PasswordChar = '*';
            textBox6.PasswordChar = '*';
            textBox5.Text = System.Configuration.ConfigurationSettings.AppSettings["passwd"];
            //checkBox1.Checked = Convert.ToBoolean(System.Configuration.ConfigurationSettings.AppSettings["autoStart"]);
           // checkBox2.Checked = Convert.ToBoolean(System.Configuration.ConfigurationSettings.AppSettings["autoMinimize"]);
            textBox7.Focus();
        }
        [Obsolete]
        private void saveConfiguration()
        {
            System.Configuration.ConfigurationSettings.AppSettings["comPort"] = comboBox1.Text;
            System.Configuration.ConfigurationSettings.AppSettings["comBaud"] = textBox1.Text;
            System.Configuration.ConfigurationSettings.AppSettings["listenHost"] = textBox2.Text;
            System.Configuration.ConfigurationSettings.AppSettings["listenPort"] = textBox3.Text;
            System.Configuration.ConfigurationSettings.AppSettings["uname"] = textBox4.Text;
            System.Configuration.ConfigurationSettings.AppSettings["passwd"] = textBox5.Text;
           
        }
        private void saveProgram()
        {
            
        }
        private void restartProgram()
        {
            
        }
        private void ScanPort()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();

               
                foreach (string port in ports)
                {
                    comboBox1.Items.Add(port);
                }
            }
            catch
            {

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ScanPort();
        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            restartProgram();
            //mainFormVar.Visible = true;
            mainForm mf = new mainForm();
            mf.Show();

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
       
        private void Button5_Click(object sender, EventArgs e)
        {
            if(textBox7.Text == textBox4.Text && textBox6.Text == textBox5.Text)
            {
                
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong Username / Password!", "!! Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mff = new mainForm();
            mff.Show();
          
        }
        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            saveConfiguration();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            restartProgram();
            //mainFormVar.Visible = true;
            mainForm mf = new mainForm();
            mf.Show();
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();

            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            testPage tp = new testPage();
            mainForm mff = new mainForm();
            tp.Show();
            mff.Show();
        
            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
