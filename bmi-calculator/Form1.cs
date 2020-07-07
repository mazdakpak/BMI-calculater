using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
namespace bmi_calculator
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
         
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string h = materialSingleLineTextField2.Text;
            float hn = float.Parse(h) ;
            string w = materialSingleLineTextField1.Text;
            float wn = float.Parse(w);
            hn = hn * hn;
            float r = wn / hn;
            materialLabel4.Text = r.ToString();


        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
