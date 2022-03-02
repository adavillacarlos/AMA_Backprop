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

namespace AMA_Backprop
{
    public partial class Form1 : Form
    {
        NeuralNet bp;


        List<string> gender = new List<string>();
        List<string> age = new List<string>();
        List<string> smoking = new List<string>();
        List<string> yellow_fingers = new List<string>();
        List<string> anxiety = new List<string>();
        List<string> peer_presssure = new List<string>();
        List<string> chronic_disease = new List<string>();
        List<string> fatigue = new List<string>();
        List<string> allergy = new List<string>();
        List<string> wheezing = new List<string>();
        List<string> alcohol_consuming = new List<string>();
        List<string> coughing = new List<string>();
        List<string> shortness_of_breath = new List<string>();
        List<string> swallong_difficulty = new List<string>();
        List<string> chest_pain = new List<string>();

        List<int> genderList = new List<int>();
        List<int> ageList = new List<int>();
        List<int> smokingList = new List<int>();
        List<int> yellow_fingers_List = new List<int>();
        List<int> anxietyList = new List<int>();
        List<int> peer_pressure_List = new List<int>();
        List<int> chronic_disease_List = new List<int>();
        List<int> fatigueList = new List<int>();
        List<int> allergyList = new List<int>();
        List<int> wheezing_List = new List<int>();
        List<int> alcohol_consuming_List = new List<int>();
        List<int> coughingList = new List<int>();
        List<int> shortness_of_breath_List = new List<int>();
        List<int> swallowing_difficulty_List = new List<int>();
        List<int> chest_pain_List = new List<int>();

        int[] yf = new int[100]; //yellow fingers
        int[] g = new int[100];  //gender

        public Form1()
        {
            InitializeComponent();
        }

        private void makeNeuralNetworksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Calculation of hidden neurons: 
             * int inputNeurons = 15; // Number of Features
	         * int outputNeurons = 1;
	         * float twoThirds = (float) 2 / 3;
	         * float hiddenLayer = twoThirds * inputNeurons + outputNeurons;
	         * int hiddenNeurons = (int) hiddenLayer;
             * 
             */

            bp = new NeuralNet(15,11,1); //15 inputs, 11 hidden, 1 output 

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Index for the combo box: 
            //Male = 0; Female = 1 
            //Yes = 0; No = 1
            //Console.WriteLine(gender[1]);
             for (int i = 1; i < 101; i++)
            {
                Console.Write(genderList[i] + "\n");
            }
             
        }

        public void learn()
        {
            int train_data = 200;
            for (int i = 0; i < train_data; i++)
            {
                
            }
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Legend: 
             *  Yes = 2; No = 1
             *  Male = 1; Female = 0
             * 
             */ 
            int train_data = 200;
            for (int i = 0; i < train_data; i++)
            {
               
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
            using (var reader = new StreamReader(@"C:\Users\adavi\Downloads\lung-cancer.csv"))
            {

                var firstLine = reader.ReadLine();

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    gender.Add(values[0]);
                    genderList = gender.Select(int.Parse).ToList();
                    g = genderList.ToArray();

                    age.Add(values[1]);
                    ageList = age.Select(int.Parse).ToList();

                    smoking.Add(values[2]);

                    yellow_fingers.Add(values[3]);

                    anxiety.Add(values[4]);

                    peer_presssure.Add(values[5]);

                    chronic_disease.Add(values[6]);

                    fatigue.Add(values[7]);

                    allergy.Add(values[8]);

                    wheezing.Add(values[9]);

                    alcohol_consuming.Add(values[10]);

                    coughing.Add(values[11]);

                    shortness_of_breath.Add(values[12]);

                    swallong_difficulty.Add(values[13]);

                    chest_pain.Add(values[14]);


                }

            }
        }
    }
}
