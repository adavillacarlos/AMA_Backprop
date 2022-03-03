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
using Backprop;
using static AMA_Backprop.CsvHelper;

namespace AMA_Backprop
{
    public partial class Form1 : Form
    {
        NeuralNet bp;
        CsvHelper csvHelper;
        public Form1()
        {
            InitializeComponent();
            csvHelper = new CsvHelper();
        }

        private void makeNeuralNetworksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int inputNeurons = 9; // Number of Features
            int outputNeurons = 1;
            float twoThirds = (float)2 / 3;
            float hiddenLayer = twoThirds * inputNeurons + outputNeurons;
            int hiddenNeurons = (int)hiddenLayer;

            bp = new NeuralNet(inputNeurons, 11, outputNeurons);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            /*Legend: 
             * ComboBox --------------- Data 
             * Male = 0; Female = 1 --> Male = 1; Female = 0 
             * Yes = 0; No = 1 ---> Yes = 2; No = 1; 
             */
  
            int iSmoke = cmbSmoke.Text == "Yes" ? 1 : 0;
            int iYellow = cmbYellow.Text == "Yes" ? 1 : 0;
            int iChronic = cmbDisease.Text == "Yes" ? 1 : 0;
            int iFatigue = cmbFatigue.Text == "Yes" ? 1 : 0;
            int iWheezing = cmbWheezing.Text == "Yes" ? 1 : 0;
            int iCoughing = cmbCoughs.Text == "Yes" ? 1 : 0;
            int iShortness = cmbShort.Text == "Yes" ? 1 : 0;
            int iSwallowing = cmbDifficult.Text == "Yes" ? 1 : 0;
            int iChest = cmbChestPains.Text == "Yes" ? 1 : 0;
            Console.WriteLine(iChest); 
            //extract feature from the dataset (8-10) 
            //minimize features, lessen the hidden neurons 
         
            bp.setInputs(0, (double)iSmoke);
            bp.setInputs(1, (double)iYellow);
            bp.setInputs(2, (double)iChronic);
            bp.setInputs(3, (double)iFatigue);
            bp.setInputs(4, (double)iWheezing);
            bp.setInputs(5, (double)iCoughing);
            bp.setInputs(6, (double)iShortness);
            bp.setInputs(7, (double)iSwallowing);
            bp.setInputs(8, (double)iChest);
            bp.run();

            txtResult.Text = "" + bp.getOuputData(0).ToString("0.00000");
        }


        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Legend: 
             *  Yes = 2; No = 1 --> Yes = 1; No = 0
             *  Male = 1; Female = 0 --> Male = 1; Female =  0 
             * 
             */
            int lung_cancer = 0;
            List<LungCancerData> data = csvHelper.getRecords();
            // increase the epoch 
            for (int i = 0; i < 10000; i++)
            {
                foreach (var d in data)
                {
                    bp.setInputs(0, (double)d.Smoking == 2 ? 1 : 0);
                    bp.setInputs(1, (double)d.Yellow_Fingers == 2 ? 1 : 0);
                    bp.setInputs(2, (double)d.Chronic_Disease == 2 ? 1 : 0);
                    bp.setInputs(3, (double)d.Fatigue == 2 ? 1 : 0);
                    bp.setInputs(4, (double)d.Wheezing == 2 ? 1 : 0);
                    bp.setInputs(5, (double)d.Coughing == 2 ? 1 : 0);
                    bp.setInputs(6, (double)d.Shortness_Of_Breath == 2 ? 1 : 0);
                    bp.setInputs(7, (double)d.Swallowing_Difficulty == 2 ? 1 : 0);
                    bp.setInputs(8, (double)d.Chest_Pain == 2 ? 1 : 0);
                    lung_cancer = d.Lung_Cancer == 2 ? 1 : 0;
                    Console.WriteLine(lung_cancer); 
                    bp.setDesiredOutput(0, (double)lung_cancer);
                    bp.learn();


                }
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
