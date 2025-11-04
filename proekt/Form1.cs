using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using proekt.Controller;
using System.Reflection;

namespace proekt
{
    public partial class Form1 : Form
    {
        private VehicleController controller=new VehicleController();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string brand=textBox1.Text;
            string model=textBox2.Text;
            string problem=textBox3.Text;
            string result;

            if (radioButton1.Checked)
            {
                result = controller.AddCar(brand, model,problem);
            }
            else if (radioButton2.Checked)
            {
                result = controller.AddBus(brand, model, problem);
            }
            else if (radioButton3.Checked)
            {
                result = controller.AddTruck(brand, model, problem);
            }
            else
            {
                result = "Pls choose vehicle";
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();

            listBox1.Items.Add(result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string brand = textBox1.Text;
            string model = textBox2.Text;
            string problem = textBox3.Text;
            string result;
            listBox1.Items.Clear();
            listBox1.Items.Add(controller.Fix(brand, model, problem));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in controller.ShowNotFixed())
            {
                listBox1.Items.Add(item);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in controller.ShowAll())
            {
                listBox1.Items.Add(item);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
