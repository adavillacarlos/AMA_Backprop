using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop; 

namespace AMA_Backprop
{
    public partial class Form1 : Form
    {
        NeuralNet bp; 
        public Form1()
        {
            InitializeComponent();
        }

        private void makeNeuralNetworksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bp = new NeuralNet(15,11,1); //15 inputs, 11 hiddens, 1 output 
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Index for the combo box: 
            //Male = 0; Female = 1 
            //Yes = 0; No = 1

            txtResult.Text = cmbSmoke.SelectedIndex.ToString();  
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
