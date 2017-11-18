namespace TrainAndTest
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.noNeuronsInHiddenLayersInput = new System.Windows.Forms.NumericUpDown();
            this.neuronsInHiddenLayerLabel = new System.Windows.Forms.Label();
            this.noHiddenLayersInput = new System.Windows.Forms.NumericUpDown();
            this.noHiddenLayersLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.noInputNeuronLabel = new System.Windows.Forms.Label();
            this.noInputNeuronField = new System.Windows.Forms.NumericUpDown();
            this.testButton = new System.Windows.Forms.Button();
            this.trainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noTrainCyclesInput = new System.Windows.Forms.NumericUpDown();
            this.resetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.testPathLabel = new System.Windows.Forms.Label();
            this.selectTrainDataDialog = new System.Windows.Forms.Button();
            this.trainPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noNeuronsInHiddenLayersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noHiddenLayersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noInputNeuronField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noTrainCyclesInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "Select image to classify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Test on a single image";
            // 
            // noNeuronsInHiddenLayersInput
            // 
            this.noNeuronsInHiddenLayersInput.Location = new System.Drawing.Point(12, 424);
            this.noNeuronsInHiddenLayersInput.Name = "noNeuronsInHiddenLayersInput";
            this.noNeuronsInHiddenLayersInput.Size = new System.Drawing.Size(282, 22);
            this.noNeuronsInHiddenLayersInput.TabIndex = 56;
            // 
            // neuronsInHiddenLayerLabel
            // 
            this.neuronsInHiddenLayerLabel.AutoSize = true;
            this.neuronsInHiddenLayerLabel.Location = new System.Drawing.Point(12, 404);
            this.neuronsInHiddenLayerLabel.Name = "neuronsInHiddenLayerLabel";
            this.neuronsInHiddenLayerLabel.Size = new System.Drawing.Size(258, 17);
            this.neuronsInHiddenLayerLabel.TabIndex = 55;
            this.neuronsInHiddenLayerLabel.Text = "Number of neurons in the hidden layers";
            // 
            // noHiddenLayersInput
            // 
            this.noHiddenLayersInput.Location = new System.Drawing.Point(12, 379);
            this.noHiddenLayersInput.Name = "noHiddenLayersInput";
            this.noHiddenLayersInput.Size = new System.Drawing.Size(282, 22);
            this.noHiddenLayersInput.TabIndex = 54;
            // 
            // noHiddenLayersLabel
            // 
            this.noHiddenLayersLabel.AutoSize = true;
            this.noHiddenLayersLabel.Location = new System.Drawing.Point(12, 359);
            this.noHiddenLayersLabel.Name = "noHiddenLayersLabel";
            this.noHiddenLayersLabel.Size = new System.Drawing.Size(163, 17);
            this.noHiddenLayersLabel.TabIndex = 53;
            this.noHiddenLayersLabel.Text = "Number of hidden layers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Number of output neurons";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 469);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(282, 22);
            this.numericUpDown1.TabIndex = 51;
            // 
            // noInputNeuronLabel
            // 
            this.noInputNeuronLabel.AutoSize = true;
            this.noInputNeuronLabel.Location = new System.Drawing.Point(12, 310);
            this.noInputNeuronLabel.Name = "noInputNeuronLabel";
            this.noInputNeuronLabel.Size = new System.Drawing.Size(165, 17);
            this.noInputNeuronLabel.TabIndex = 50;
            this.noInputNeuronLabel.Text = "Number of input neurons";
            // 
            // noInputNeuronField
            // 
            this.noInputNeuronField.Location = new System.Drawing.Point(12, 330);
            this.noInputNeuronField.Name = "noInputNeuronField";
            this.noInputNeuronField.Size = new System.Drawing.Size(282, 22);
            this.noInputNeuronField.TabIndex = 49;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(12, 701);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(282, 23);
            this.testButton.TabIndex = 48;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(12, 653);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(282, 23);
            this.trainButton.TabIndex = 47;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Amount of training cycles";
            // 
            // noTrainCyclesInput
            // 
            this.noTrainCyclesInput.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.noTrainCyclesInput.Location = new System.Drawing.Point(9, 625);
            this.noTrainCyclesInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.noTrainCyclesInput.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.noTrainCyclesInput.Name = "noTrainCyclesInput";
            this.noTrainCyclesInput.Size = new System.Drawing.Size(285, 22);
            this.noTrainCyclesInput.TabIndex = 45;
            this.noTrainCyclesInput.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 497);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(282, 23);
            this.resetButton.TabIndex = 44;
            this.resetButton.Text = "(Re)set NeuralNetwork";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Select your testdata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testPathLabel
            // 
            this.testPathLabel.AutoSize = true;
            this.testPathLabel.Location = new System.Drawing.Point(9, 66);
            this.testPathLabel.Name = "testPathLabel";
            this.testPathLabel.Size = new System.Drawing.Size(125, 17);
            this.testPathLabel.TabIndex = 42;
            this.testPathLabel.Text = "Path to Testdata...";
            // 
            // selectTrainDataDialog
            // 
            this.selectTrainDataDialog.Location = new System.Drawing.Point(12, 29);
            this.selectTrainDataDialog.Name = "selectTrainDataDialog";
            this.selectTrainDataDialog.Size = new System.Drawing.Size(282, 23);
            this.selectTrainDataDialog.TabIndex = 41;
            this.selectTrainDataDialog.Text = "Select your traindata";
            this.selectTrainDataDialog.UseVisualStyleBackColor = true;
            this.selectTrainDataDialog.Click += new System.EventHandler(this.selectTrainDataDialog_Click);
            // 
            // trainPathLabel
            // 
            this.trainPathLabel.AutoSize = true;
            this.trainPathLabel.Location = new System.Drawing.Point(9, 9);
            this.trainPathLabel.Name = "trainPathLabel";
            this.trainPathLabel.Size = new System.Drawing.Size(130, 17);
            this.trainPathLabel.TabIndex = 40;
            this.trainPathLabel.Text = "Path to Traindata...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 733);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noNeuronsInHiddenLayersInput);
            this.Controls.Add(this.neuronsInHiddenLayerLabel);
            this.Controls.Add(this.noHiddenLayersInput);
            this.Controls.Add(this.noHiddenLayersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.noInputNeuronLabel);
            this.Controls.Add(this.noInputNeuronField);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noTrainCyclesInput);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testPathLabel);
            this.Controls.Add(this.selectTrainDataDialog);
            this.Controls.Add(this.trainPathLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.noNeuronsInHiddenLayersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noHiddenLayersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noInputNeuronField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noTrainCyclesInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown noNeuronsInHiddenLayersInput;
        private System.Windows.Forms.Label neuronsInHiddenLayerLabel;
        private System.Windows.Forms.NumericUpDown noHiddenLayersInput;
        private System.Windows.Forms.Label noHiddenLayersLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label noInputNeuronLabel;
        private System.Windows.Forms.NumericUpDown noInputNeuronField;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown noTrainCyclesInput;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label testPathLabel;
        private System.Windows.Forms.Button selectTrainDataDialog;
        private System.Windows.Forms.Label trainPathLabel;
    }
}