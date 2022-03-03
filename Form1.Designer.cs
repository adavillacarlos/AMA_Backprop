
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.makeNeuralNetworksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbSmoke = new System.Windows.Forms.ComboBox();
            this.cmbYellow = new System.Windows.Forms.ComboBox();
            this.cmbDisease = new System.Windows.Forms.ComboBox();
            this.cmbFatigue = new System.Windows.Forms.ComboBox();
            this.cmbWheezing = new System.Windows.Forms.ComboBox();
            this.cmbCoughs = new System.Windows.Forms.ComboBox();
            this.cmbShort = new System.Windows.Forms.ComboBox();
            this.cmbChestPains = new System.Windows.Forms.ComboBox();
            this.cmbDifficult = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Smoking: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yellow Fingers: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chronic Disease: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fatigue: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Wheezing: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(407, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Coughs: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(331, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Shortness of Breath: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(331, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Shallowing Difficulty: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(377, 250);
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
            this.menuStrip1.Size = new System.Drawing.Size(699, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // makeNeuralNetworksToolStripMenuItem
            // 
            this.makeNeuralNetworksToolStripMenuItem.Name = "makeNeuralNetworksToolStripMenuItem";
            this.makeNeuralNetworksToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
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
            this.loadWeightsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.loadWeightsToolStripMenuItem.Text = "Load Weights";
            this.loadWeightsToolStripMenuItem.Click += new System.EventHandler(this.loadWeightsToolStripMenuItem_Click);
            // 
            // saveWeightsToolStripMenuItem
            // 
            this.saveWeightsToolStripMenuItem.Name = "saveWeightsToolStripMenuItem";
            this.saveWeightsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saveWeightsToolStripMenuItem.Text = "Save Weights";
            this.saveWeightsToolStripMenuItem.Click += new System.EventHandler(this.saveWeightsToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(310, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "Answer YES or NO if you are experiencing one: ";
            // 
            // cmbSmoke
            // 
            this.cmbSmoke.DisplayMember = "1,2";
            this.cmbSmoke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmoke.FormattingEnabled = true;
            this.cmbSmoke.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbSmoke.Location = new System.Drawing.Point(159, 162);
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
            this.cmbYellow.Location = new System.Drawing.Point(159, 201);
            this.cmbYellow.Name = "cmbYellow";
            this.cmbYellow.Size = new System.Drawing.Size(124, 24);
            this.cmbYellow.TabIndex = 20;
            // 
            // cmbDisease
            // 
            this.cmbDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisease.FormattingEnabled = true;
            this.cmbDisease.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbDisease.Location = new System.Drawing.Point(159, 244);
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
            this.cmbFatigue.Location = new System.Drawing.Point(159, 285);
            this.cmbFatigue.Name = "cmbFatigue";
            this.cmbFatigue.Size = new System.Drawing.Size(124, 24);
            this.cmbFatigue.TabIndex = 29;
            // 
            // cmbWheezing
            // 
            this.cmbWheezing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWheezing.FormattingEnabled = true;
            this.cmbWheezing.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbWheezing.Location = new System.Drawing.Point(159, 324);
            this.cmbWheezing.Name = "cmbWheezing";
            this.cmbWheezing.Size = new System.Drawing.Size(124, 24);
            this.cmbWheezing.TabIndex = 27;
            // 
            // cmbCoughs
            // 
            this.cmbCoughs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoughs.FormattingEnabled = true;
            this.cmbCoughs.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbCoughs.Location = new System.Drawing.Point(500, 161);
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
            this.cmbShort.Location = new System.Drawing.Point(500, 205);
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
            this.cmbChestPains.Location = new System.Drawing.Point(500, 247);
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
            this.cmbDifficult.Location = new System.Drawing.Point(500, 291);
            this.cmbDifficult.Name = "cmbDifficult";
            this.cmbDifficult.Size = new System.Drawing.Size(124, 24);
            this.cmbDifficult.TabIndex = 30;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(500, 357);
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
            this.label18.Location = new System.Drawing.Point(201, 434);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 17);
            this.label18.TabIndex = 34;
            this.label18.Text = "Results: ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(292, 431);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(124, 22);
            this.txtResult.TabIndex = 35;
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
            this.ClientSize = new System.Drawing.Size(699, 487);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cmbShort);
            this.Controls.Add(this.cmbChestPains);
            this.Controls.Add(this.cmbDifficult);
            this.Controls.Add(this.cmbFatigue);
            this.Controls.Add(this.cmbWheezing);
            this.Controls.Add(this.cmbCoughs);
            this.Controls.Add(this.cmbDisease);
            this.Controls.Add(this.cmbYellow);
            this.Controls.Add(this.cmbSmoke);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeNeuralNetworksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbSmoke;
        private System.Windows.Forms.ComboBox cmbYellow;
        private System.Windows.Forms.ComboBox cmbDisease;
        private System.Windows.Forms.ComboBox cmbFatigue;
        private System.Windows.Forms.ComboBox cmbWheezing;
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

