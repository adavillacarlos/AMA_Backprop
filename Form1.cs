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

        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); 
        }

        private void saveWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bp.saveWeights(saveFileDialog1.FileName); 
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bp.loadWeights(openFileDialog1.FileName); 
        }
    }
}
