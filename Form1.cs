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
        List<string> genderList = new List<string>();
        List<string> ageList = new List<string>();
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
        List<string> lung_cancer = new List<string>();
        

        int[] gender = new int[200];
        int[] age = new int[200];
        int[] isSmoking = new int[200];
        int[] hasYellowFingers = new int[200];
        int[] isAnxious = new int[200];
        int[] isPeerPressured = new int[200];
        int[] hasChronicDisease = new int[200];
        int[] isFatigued = new int[200];
        int[] hasAllergies = new int[200];
        int[] isWheezing = new int[200];
        int[] drinksAlcohol = new int[200];
        int[] isCoughing = new int[200];
        int[] hasShortnessOfBreath = new int[200];
        int[] hasDifficultySwallowing = new int[200];
        int[] hasChestPain = new int[200];
        int[] hasLungCancer = new int[200];

        public Form1()
        {
            InitializeComponent();
        }

        private void makeNeuralNetworksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int inputNeurons = 14; // Number of Features
            int outputNeurons = 1;
            float twoThirds = (float)2 / 3;
            float hiddenLayer = twoThirds * inputNeurons + outputNeurons;
            int hiddenNeurons = (int)hiddenLayer;

            bp = new NeuralNet(inputNeurons, 15, outputNeurons);  
            //have to change the hidden neurons manually 

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            /*Legend: 
             * ComboBox --------------- Data 
             * Male = 0; Female = 1 --> Male = 1; Female = 0 
             * Yes = 0; No = 1 ---> Yes = 2; No = 1; 
             */

            int iGender = cmbGender.SelectedIndex == 0 ? 1 : 0;
            int iAge = int.Parse(txtAge.Text);
            int iSmoke = cmbSmoke.Text == "Yes" ? 2 : 1;
            int iYellow = cmbYellow.Text == "Yes" ? 2 : 1;
            int iAnxiety = cmbAnxiety.Text == "Yes" ? 2 : 1;
            int iPeer = cmbPeer.Text == "Yes" ? 2 : 1;
            int iChronic = cmbDisease.Text == "Yes" ? 2 : 1;
            int iFatigue = cmbFatigue.Text == "Yes" ? 2 : 1;
            int iAllergy = cmbAllergy.Text == "Yes" ? 2 : 1;
            int iWheezing = cmbWheezing.Text == "Yes" ? 2 : 1;
            int iAlcohol = cmbAlcohol.Text == "Yes" ? 2 : 1;
            int iCoughing = cmbCoughs.Text == "Yes" ? 2 : 1;
            int iShortness = cmbShort.Text == "Yes" ? 2 : 1;
            int iSwallowing = cmbDifficult.Text == "Yes" ? 2 : 1;
            int iChest = cmbChestPains.Text == "Yes" ? 2 : 1;


            bp.setInputs(0, iGender);
           // bp.setInputs(1, iAge);
            bp.setInputs(1, iSmoke);
            bp.setInputs(2, iYellow);
            bp.setInputs(3, iAnxiety);
            bp.setInputs(4, iPeer);
            bp.setInputs(5, iChronic);
            bp.setInputs(6, iFatigue);
            bp.setInputs(7, iAllergy);
            bp.setInputs(8, iWheezing);
            bp.setInputs(9, iAlcohol);
            bp.setInputs(10, iCoughing);
            bp.setInputs(11, iShortness);
            bp.setInputs(12, iSwallowing);
            bp.setInputs(13, iChest);
            bp.run();

            txtResult.Text = "" + bp.getOuputData(0); 
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
            int lung_cancer = 0; 
            //int features = 15;
            for (int i = 0; i < 1000; i++) // 1000 Epoch
            {
                for (int j = 1; j < train_data; j++)
                {
                    bp.setInputs(0, gender[j]);
                   // bp.setInputs(1, age[j]);
                   //remove age since it is messing with the data. 
                    bp.setInputs(1, isSmoking[j]);
                    bp.setInputs(2, hasYellowFingers[j]);
                    bp.setInputs(3, isAnxious[j]);
                    bp.setInputs(4, isPeerPressured[j]);
                    bp.setInputs(5, hasChronicDisease[j]);
                    bp.setInputs(6, isFatigued[j]);
                    bp.setInputs(7, hasAllergies[j]);
                    bp.setInputs(8, isWheezing[j]);
                    bp.setInputs(9, drinksAlcohol[j]);
                    bp.setInputs(10, isCoughing[j]);
                    bp.setInputs(11, hasShortnessOfBreath[j]);
                    bp.setInputs(12, hasDifficultySwallowing[j]);
                    bp.setInputs(13, hasChestPain[j]);
                    lung_cancer = hasLungCancer[j] == 2 ? 1 : 0;
                    bp.setDesiredOutput(0, lung_cancer);
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
            using (var reader = new StreamReader(@"C:\Users\adavi\Downloads\lung-cancer.csv"))
            {

                var firstLine = reader.ReadLine();

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    genderList.Add(values[0]);
                    gender = genderList.Select(int.Parse).ToList().ToArray();

                    ageList.Add(values[1]);
                    age = ageList.Select(int.Parse).ToList().ToArray();

                    smoking.Add(values[2]);
                    isSmoking = smoking.Select(int.Parse).ToList().ToArray();

                    yellow_fingers.Add(values[3]);
                    hasYellowFingers = yellow_fingers.Select(int.Parse).ToList().ToArray();

                    anxiety.Add(values[4]);
                    isAnxious = anxiety.Select(int.Parse).ToList().ToArray();

                    peer_presssure.Add(values[5]);
                    isPeerPressured = peer_presssure.Select(int.Parse).ToList().ToArray();

                    chronic_disease.Add(values[6]);
                    hasChronicDisease = chronic_disease.Select(int.Parse).ToList().ToArray();

                    fatigue.Add(values[7]);
                    isFatigued = fatigue.Select(int.Parse).ToList().ToArray();

                    allergy.Add(values[8]);
                    hasAllergies = allergy.Select(int.Parse).ToList().ToArray();

                    wheezing.Add(values[9]);
                    isWheezing = wheezing.Select(int.Parse).ToList().ToArray();

                    alcohol_consuming.Add(values[10]);
                    drinksAlcohol = alcohol_consuming.Select(int.Parse).ToList().ToArray();

                    coughing.Add(values[11]);
                    isCoughing = coughing.Select(int.Parse).ToList().ToArray();

                    shortness_of_breath.Add(values[12]);
                    hasShortnessOfBreath = shortness_of_breath.Select(int.Parse).ToList().ToArray();

                    swallong_difficulty.Add(values[13]);
                    hasDifficultySwallowing = shortness_of_breath.Select(int.Parse).ToList().ToArray();

                    chest_pain.Add(values[14]);
                    hasChestPain = chest_pain.Select(int.Parse).ToList().ToArray();

                    lung_cancer.Add(values[15]);
                    hasLungCancer = lung_cancer.Select(int.Parse).ToList().ToArray();

                }
            }
        }
    }
}
