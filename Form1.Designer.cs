
namespace AMA_Backprop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.makeNeuralNetworksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbSmoke = new System.Windows.Forms.ComboBox();
            this.cmbYellow = new System.Windows.Forms.ComboBox();
            this.cmbAnxiety = new System.Windows.Forms.ComboBox();
            this.cmbPeer = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbDisease = new System.Windows.Forms.ComboBox();
            this.cmbFatigue = new System.Windows.Forms.ComboBox();
            this.cmbAllergy = new System.Windows.Forms.ComboBox();
            this.cmbWheezing = new System.Windows.Forms.ComboBox();
            this.cmbAlcohol = new System.Windows.Forms.ComboBox();
            this.cmbCoughs = new System.Windows.Forms.ComboBox();
            this.cmbShort = new System.Windows.Forms.ComboBox();
            this.cmbChestPains = new System.Windows.Forms.ComboBox();
            this.cmbDifficult = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.weightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMA Lung Cancer Detector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Smoking: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yellow Fingers: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Anxiety: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Peer Pressure:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chronic Disease: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fatigue: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Allergy: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(360, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Wheezing: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Alcohol Consuming: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(365, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Coughs: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(631, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Shortness of Breath: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(631, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Shallowing Difficulty: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(677, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Chess Pains: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeNeuralNetworksToolStripMenuItem,
            this.trainToolStripMenuItem,
            this.weightsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // makeNeuralNetworksToolStripMenuItem
            // 
            this.makeNeuralNetworksToolStripMenuItem.Name = "makeNeuralNetworksToolStripMenuItem";
            this.makeNeuralNetworksToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.makeNeuralNetworksToolStripMenuItem.Text = "Make Neural";
            this.makeNeuralNetworksToolStripMenuItem.Click += new System.EventHandler(this.makeNeuralNetworksToolStripMenuItem_Click);
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.trainToolStripMenuItem.Text = "Train";
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(310, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "Answer YES or NO if you are experiencing one: ";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(156, 93);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(124, 24);
            this.cmbGender.TabIndex = 18;
            // 
            // cmbSmoke
            // 
            this.cmbSmoke.DisplayMember = "1,2";
            this.cmbSmoke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmoke.FormattingEnabled = true;
            this.cmbSmoke.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbSmoke.Location = new System.Drawing.Point(156, 245);
            this.cmbSmoke.Name = "cmbSmoke";
            this.cmbSmoke.Size = new System.Drawing.Size(124, 24);
            this.cmbSmoke.TabIndex = 19;
            // 
            // cmbYellow
            // 
            this.cmbYellow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYellow.FormattingEnabled = true;
            this.cmbYellow.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbYellow.Location = new System.Drawing.Point(156, 284);
            this.cmbYellow.Name = "cmbYellow";
            this.cmbYellow.Size = new System.Drawing.Size(124, 24);
            this.cmbYellow.TabIndex = 20;
            // 
            // cmbAnxiety
            // 
            this.cmbAnxiety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnxiety.FormattingEnabled = true;
            this.cmbAnxiety.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbAnxiety.Location = new System.Drawing.Point(156, 321);
            this.cmbAnxiety.Name = "cmbAnxiety";
            this.cmbAnxiety.Size = new System.Drawing.Size(124, 24);
            this.cmbAnxiety.TabIndex = 21;
            // 
            // cmbPeer
            // 
            this.cmbPeer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeer.FormattingEnabled = true;
            this.cmbPeer.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbPeer.Location = new System.Drawing.Point(156, 360);
            this.cmbPeer.Name = "cmbPeer";
            this.cmbPeer.Size = new System.Drawing.Size(124, 24);
            this.cmbPeer.TabIndex = 22;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(156, 138);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(124, 22);
            this.txtAge.TabIndex = 23;
            // 
            // cmbDisease
            // 
            this.cmbDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisease.FormattingEnabled = true;
            this.cmbDisease.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbDisease.Location = new System.Drawing.Point(156, 398);
            this.cmbDisease.Name = "cmbDisease";
            this.cmbDisease.Size = new System.Drawing.Size(124, 24);
            this.cmbDisease.TabIndex = 24;
            // 
            // cmbFatigue
            // 
            this.cmbFatigue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFatigue.FormattingEnabled = true;
            this.cmbFatigue.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbFatigue.Location = new System.Drawing.Point(470, 241);
            this.cmbFatigue.Name = "cmbFatigue";
            this.cmbFatigue.Size = new System.Drawing.Size(124, 24);
            this.cmbFatigue.TabIndex = 29;
            // 
            // cmbAllergy
            // 
            this.cmbAllergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllergy.FormattingEnabled = true;
            this.cmbAllergy.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbAllergy.Location = new System.Drawing.Point(470, 283);
            this.cmbAllergy.Name = "cmbAllergy";
            this.cmbAllergy.Size = new System.Drawing.Size(124, 24);
            this.cmbAllergy.TabIndex = 28;
            // 
            // cmbWheezing
            // 
            this.cmbWheezing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWheezing.FormattingEnabled = true;
            this.cmbWheezing.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbWheezing.Location = new System.Drawing.Point(470, 320);
            this.cmbWheezing.Name = "cmbWheezing";
            this.cmbWheezing.Size = new System.Drawing.Size(124, 24);
            this.cmbWheezing.TabIndex = 27;
            // 
            // cmbAlcohol
            // 
            this.cmbAlcohol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlcohol.FormattingEnabled = true;
            this.cmbAlcohol.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbAlcohol.Location = new System.Drawing.Point(470, 359);
            this.cmbAlcohol.Name = "cmbAlcohol";
            this.cmbAlcohol.Size = new System.Drawing.Size(124, 24);
            this.cmbAlcohol.TabIndex = 26;
            // 
            // cmbCoughs
            // 
            this.cmbCoughs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoughs.FormattingEnabled = true;
            this.cmbCoughs.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbCoughs.Location = new System.Drawing.Point(470, 394);
            this.cmbCoughs.Name = "cmbCoughs";
            this.cmbCoughs.Size = new System.Drawing.Size(124, 24);
            this.cmbCoughs.TabIndex = 25;
            // 
            // cmbShort
            // 
            this.cmbShort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShort.FormattingEnabled = true;
            this.cmbShort.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbShort.Location = new System.Drawing.Point(800, 241);
            this.cmbShort.Name = "cmbShort";
            this.cmbShort.Size = new System.Drawing.Size(124, 24);
            this.cmbShort.TabIndex = 32;
            // 
            // cmbChestPains
            // 
            this.cmbChestPains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChestPains.FormattingEnabled = true;
            this.cmbChestPains.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbChestPains.Location = new System.Drawing.Point(800, 283);
            this.cmbChestPains.Name = "cmbChestPains";
            this.cmbChestPains.Size = new System.Drawing.Size(124, 24);
            this.cmbChestPains.TabIndex = 31;
            // 
            // cmbDifficult
            // 
            this.cmbDifficult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficult.FormattingEnabled = true;
            this.cmbDifficult.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbDifficult.Location = new System.Drawing.Point(800, 327);
            this.cmbDifficult.Name = "cmbDifficult";
            this.cmbDifficult.Size = new System.Drawing.Size(124, 24);
            this.cmbDifficult.TabIndex = 30;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(800, 387);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(124, 28);
            this.btnCheck.TabIndex = 33;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(531, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 17);
            this.label18.TabIndex = 34;
            this.label18.Text = "Results: ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(622, 90);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(124, 22);
            this.txtResult.TabIndex = 35;
            // 
            // weightsToolStripMenuItem
            // 
            this.weightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWeightsToolStripMenuItem,
            this.saveWeightsToolStripMenuItem});
            this.weightsToolStripMenuItem.Name = "weightsToolStripMenuItem";
            this.weightsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.weightsToolStripMenuItem.Text = "Weights";
            // 
            // loadWeightsToolStripMenuItem
            // 
            this.loadWeightsToolStripMenuItem.Name = "loadWeightsToolStripMenuItem";
            this.loadWeightsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadWeightsToolStripMenuItem.Text = "Load Weights";
            this.loadWeightsToolStripMenuItem.Click += new System.EventHandler(this.loadWeightsToolStripMenuItem_Click);
            // 
            // saveWeightsToolStripMenuItem
            // 
            this.saveWeightsToolStripMenuItem.Name = "saveWeightsToolStripMenuItem";
            this.saveWeightsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveWeightsToolStripMenuItem.Text = "Save Weights";
            this.saveWeightsToolStripMenuItem.Click += new System.EventHandler(this.saveWeightsToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 487);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cmbShort);
            this.Controls.Add(this.cmbChestPains);
            this.Controls.Add(this.cmbDifficult);
            this.Controls.Add(this.cmbFatigue);
            this.Controls.Add(this.cmbAllergy);
            this.Controls.Add(this.cmbWheezing);
            this.Controls.Add(this.cmbAlcohol);
            this.Controls.Add(this.cmbCoughs);
            this.Controls.Add(this.cmbDisease);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.cmbPeer);
            this.Controls.Add(this.cmbAnxiety);
            this.Controls.Add(this.cmbYellow);
            this.Controls.Add(this.cmbSmoke);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lung Cancer Detector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeNeuralNetworksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbSmoke;
        private System.Windows.Forms.ComboBox cmbYellow;
        private System.Windows.Forms.ComboBox cmbAnxiety;
        private System.Windows.Forms.ComboBox cmbPeer;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbDisease;
        private System.Windows.Forms.ComboBox cmbFatigue;
        private System.Windows.Forms.ComboBox cmbAllergy;
        private System.Windows.Forms.ComboBox cmbWheezing;
        private System.Windows.Forms.ComboBox cmbAlcohol;
        private System.Windows.Forms.ComboBox cmbCoughs;
        private System.Windows.Forms.ComboBox cmbShort;
        private System.Windows.Forms.ComboBox cmbChestPains;
        private System.Windows.Forms.ComboBox cmbDifficult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ToolStripMenuItem weightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWeightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWeightsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

