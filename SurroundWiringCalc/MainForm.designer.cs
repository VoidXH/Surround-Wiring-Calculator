namespace SurroundWiringCalc {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.wiringPlan = new System.Windows.Forms.Panel();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.systemCurrent = new System.Windows.Forms.Label();
            this.systemImpedance = new System.Windows.Forms.Label();
            this.systemVoltage = new System.Windows.Forms.Label();
            this.amplifierLoad = new System.Windows.Forms.NumericUpDown();
            this.amplifierLoadLabel = new System.Windows.Forms.Label();
            this.amplifierImpedance = new System.Windows.Forms.NumericUpDown();
            this.amplifierImpedanceLabel = new System.Windows.Forms.Label();
            this.speakerImpedance = new System.Windows.Forms.NumericUpDown();
            this.speakerImpedanceLabel = new System.Windows.Forms.Label();
            this.speakerCount = new System.Windows.Forms.NumericUpDown();
            this.speakerCountLabel = new System.Windows.Forms.Label();
            this.wiringPlanInfo = new System.Windows.Forms.Label();
            this.voidx = new System.Windows.Forms.LinkLabel();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.tolerance = new System.Windows.Forms.NumericUpDown();
            this.settingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplifierLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifierImpedance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerImpedance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolerance)).BeginInit();
            this.SuspendLayout();
            // 
            // wiringPlan
            // 
            this.wiringPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wiringPlan.AutoScroll = true;
            this.wiringPlan.Location = new System.Drawing.Point(12, 12);
            this.wiringPlan.Name = "wiringPlan";
            this.wiringPlan.Size = new System.Drawing.Size(576, 404);
            this.wiringPlan.TabIndex = 0;
            // 
            // settingsBox
            // 
            this.settingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBox.Controls.Add(this.tolerance);
            this.settingsBox.Controls.Add(this.toleranceLabel);
            this.settingsBox.Controls.Add(this.systemCurrent);
            this.settingsBox.Controls.Add(this.systemImpedance);
            this.settingsBox.Controls.Add(this.systemVoltage);
            this.settingsBox.Controls.Add(this.amplifierLoad);
            this.settingsBox.Controls.Add(this.amplifierLoadLabel);
            this.settingsBox.Controls.Add(this.amplifierImpedance);
            this.settingsBox.Controls.Add(this.amplifierImpedanceLabel);
            this.settingsBox.Controls.Add(this.speakerImpedance);
            this.settingsBox.Controls.Add(this.speakerImpedanceLabel);
            this.settingsBox.Controls.Add(this.speakerCount);
            this.settingsBox.Controls.Add(this.speakerCountLabel);
            this.settingsBox.Location = new System.Drawing.Point(594, 12);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(178, 203);
            this.settingsBox.TabIndex = 1;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // systemCurrent
            // 
            this.systemCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.systemCurrent.Location = new System.Drawing.Point(6, 180);
            this.systemCurrent.Name = "systemCurrent";
            this.systemCurrent.Size = new System.Drawing.Size(166, 13);
            this.systemCurrent.TabIndex = 10;
            this.systemCurrent.Text = "System current: 0 A";
            this.systemCurrent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // systemImpedance
            // 
            this.systemImpedance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.systemImpedance.Location = new System.Drawing.Point(6, 146);
            this.systemImpedance.Name = "systemImpedance";
            this.systemImpedance.Size = new System.Drawing.Size(166, 13);
            this.systemImpedance.TabIndex = 9;
            this.systemImpedance.Text = "System impedance: 0 Ω";
            this.systemImpedance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // systemVoltage
            // 
            this.systemVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.systemVoltage.Location = new System.Drawing.Point(6, 163);
            this.systemVoltage.Name = "systemVoltage";
            this.systemVoltage.Size = new System.Drawing.Size(166, 13);
            this.systemVoltage.TabIndex = 8;
            this.systemVoltage.Text = "System voltage: 0 V";
            this.systemVoltage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // amplifierLoad
            // 
            this.amplifierLoad.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.amplifierLoad.Location = new System.Drawing.Point(104, 97);
            this.amplifierLoad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amplifierLoad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amplifierLoad.Name = "amplifierLoad";
            this.amplifierLoad.Size = new System.Drawing.Size(68, 20);
            this.amplifierLoad.TabIndex = 7;
            this.amplifierLoad.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.amplifierLoad.ValueChanged += new System.EventHandler(this.Replan);
            // 
            // amplifierLoadLabel
            // 
            this.amplifierLoadLabel.AutoSize = true;
            this.amplifierLoadLabel.Location = new System.Drawing.Point(6, 99);
            this.amplifierLoadLabel.Name = "amplifierLoadLabel";
            this.amplifierLoadLabel.Size = new System.Drawing.Size(92, 13);
            this.amplifierLoadLabel.TabIndex = 6;
            this.amplifierLoadLabel.Text = "Amplifier load (W):";
            // 
            // amplifierImpedance
            // 
            this.amplifierImpedance.DecimalPlaces = 1;
            this.amplifierImpedance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.amplifierImpedance.Location = new System.Drawing.Point(126, 71);
            this.amplifierImpedance.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.amplifierImpedance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amplifierImpedance.Name = "amplifierImpedance";
            this.amplifierImpedance.Size = new System.Drawing.Size(46, 20);
            this.amplifierImpedance.TabIndex = 5;
            this.amplifierImpedance.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.amplifierImpedance.ValueChanged += new System.EventHandler(this.Replan);
            // 
            // amplifierImpedanceLabel
            // 
            this.amplifierImpedanceLabel.AutoSize = true;
            this.amplifierImpedanceLabel.Location = new System.Drawing.Point(6, 73);
            this.amplifierImpedanceLabel.Name = "amplifierImpedanceLabel";
            this.amplifierImpedanceLabel.Size = new System.Drawing.Size(114, 13);
            this.amplifierImpedanceLabel.TabIndex = 4;
            this.amplifierImpedanceLabel.Text = "Target impedance (Ω):";
            // 
            // speakerImpedance
            // 
            this.speakerImpedance.DecimalPlaces = 1;
            this.speakerImpedance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speakerImpedance.Location = new System.Drawing.Point(117, 45);
            this.speakerImpedance.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.speakerImpedance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speakerImpedance.Name = "speakerImpedance";
            this.speakerImpedance.Size = new System.Drawing.Size(55, 20);
            this.speakerImpedance.TabIndex = 3;
            this.speakerImpedance.Value = new decimal(new int[] {
            46,
            0,
            0,
            65536});
            this.speakerImpedance.ValueChanged += new System.EventHandler(this.Replan);
            // 
            // speakerImpedanceLabel
            // 
            this.speakerImpedanceLabel.AutoSize = true;
            this.speakerImpedanceLabel.Location = new System.Drawing.Point(6, 47);
            this.speakerImpedanceLabel.Name = "speakerImpedanceLabel";
            this.speakerImpedanceLabel.Size = new System.Drawing.Size(105, 13);
            this.speakerImpedanceLabel.TabIndex = 2;
            this.speakerImpedanceLabel.Text = "Speaker impedance:";
            // 
            // speakerCount
            // 
            this.speakerCount.Location = new System.Drawing.Point(92, 19);
            this.speakerCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.speakerCount.Name = "speakerCount";
            this.speakerCount.Size = new System.Drawing.Size(80, 20);
            this.speakerCount.TabIndex = 1;
            this.speakerCount.ValueChanged += new System.EventHandler(this.Replan);
            // 
            // speakerCountLabel
            // 
            this.speakerCountLabel.AutoSize = true;
            this.speakerCountLabel.Location = new System.Drawing.Point(6, 21);
            this.speakerCountLabel.Name = "speakerCountLabel";
            this.speakerCountLabel.Size = new System.Drawing.Size(80, 13);
            this.speakerCountLabel.TabIndex = 0;
            this.speakerCountLabel.Text = "Speaker count:";
            // 
            // wiringPlanInfo
            // 
            this.wiringPlanInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wiringPlanInfo.AutoSize = true;
            this.wiringPlanInfo.Location = new System.Drawing.Point(13, 419);
            this.wiringPlanInfo.Name = "wiringPlanInfo";
            this.wiringPlanInfo.Size = new System.Drawing.Size(354, 13);
            this.wiringPlanInfo.TabIndex = 2;
            this.wiringPlanInfo.Text = "Each layer represents a parallel connection, and layers are wired in series.";
            // 
            // voidx
            // 
            this.voidx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voidx.AutoSize = true;
            this.voidx.Location = new System.Drawing.Point(723, 419);
            this.voidx.Name = "voidx";
            this.voidx.Size = new System.Drawing.Size(49, 13);
            this.voidx.TabIndex = 3;
            this.voidx.TabStop = true;
            this.voidx.Text = "by VoidX";
            this.voidx.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.voidx.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VoidX_LinkClicked);
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Location = new System.Drawing.Point(6, 125);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(76, 13);
            this.toleranceLabel.TabIndex = 11;
            this.toleranceLabel.Text = "Tolerance (Ω):";
            // 
            // tolerance
            // 
            this.tolerance.DecimalPlaces = 1;
            this.tolerance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tolerance.Location = new System.Drawing.Point(88, 123);
            this.tolerance.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tolerance.Name = "tolerance";
            this.tolerance.Size = new System.Drawing.Size(84, 20);
            this.tolerance.TabIndex = 12;
            this.tolerance.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tolerance.ValueChanged += new System.EventHandler(this.Replan);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.voidx);
            this.Controls.Add(this.wiringPlanInfo);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.wiringPlan);
            this.Name = "MainForm";
            this.Text = "Surround Wiring Calculator";
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplifierLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifierImpedance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerImpedance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolerance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel wiringPlan;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.NumericUpDown speakerCount;
        private System.Windows.Forms.Label speakerCountLabel;
        private System.Windows.Forms.Label speakerImpedanceLabel;
        private System.Windows.Forms.NumericUpDown speakerImpedance;
        private System.Windows.Forms.NumericUpDown amplifierImpedance;
        private System.Windows.Forms.Label amplifierImpedanceLabel;
        private System.Windows.Forms.Label amplifierLoadLabel;
        private System.Windows.Forms.NumericUpDown amplifierLoad;
        private System.Windows.Forms.Label systemVoltage;
        private System.Windows.Forms.Label systemImpedance;
        private System.Windows.Forms.Label systemCurrent;
        private System.Windows.Forms.Label wiringPlanInfo;
        private System.Windows.Forms.LinkLabel voidx;
        private System.Windows.Forms.NumericUpDown tolerance;
        private System.Windows.Forms.Label toleranceLabel;
    }
}