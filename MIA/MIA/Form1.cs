using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace MIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filledata()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var dataform = new
            {
                name =" textbox1.Text",
                CIN = "textBox2.Text",
             
            };


            var formjson = JsonConvert.SerializeObject(dataform);
            var filepath = "Form.json";
            File.AppendAllText(filepath, formjson);
            MessageBox.Show("les donnees ont eté enregistrer");



        }
    }
}
