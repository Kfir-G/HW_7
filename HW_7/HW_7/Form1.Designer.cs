namespace HW_7
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
            this.lblTitleWomenChart = new System.Windows.Forms.Label();
            this.btnFindMatch = new System.Windows.Forms.Button();
            this.lblTitleCouplesChart = new System.Windows.Forms.Label();
            this.lblTitleSignalWomenChart = new System.Windows.Forms.Label();
            this.lblTitleSignalMenChart = new System.Windows.Forms.Label();
            this.lstbxWomenNameChart = new System.Windows.Forms.ListBox();
            this.lstbxCouplesChart = new System.Windows.Forms.ListBox();
            this.lstbxSignalWomenChart = new System.Windows.Forms.ListBox();
            this.lstbxSignalMenChart = new System.Windows.Forms.ListBox();
            this.lblTitleSaveTofile = new System.Windows.Forms.Label();
            this.rdbtnSignalMen = new System.Windows.Forms.RadioButton();
            this.rdbtnSignalWomen = new System.Windows.Forms.RadioButton();
            this.rdbtnCouples = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleWomenChart
            // 
            this.lblTitleWomenChart.AutoSize = true;
            this.lblTitleWomenChart.Location = new System.Drawing.Point(13, 13);
            this.lblTitleWomenChart.Name = "lblTitleWomenChart";
            this.lblTitleWomenChart.Size = new System.Drawing.Size(68, 20);
            this.lblTitleWomenChart.TabIndex = 0;
            this.lblTitleWomenChart.Text = "Women:";
            // 
            // btnFindMatch
            // 
            this.btnFindMatch.Location = new System.Drawing.Point(273, 36);
            this.btnFindMatch.Name = "btnFindMatch";
            this.btnFindMatch.Size = new System.Drawing.Size(120, 34);
            this.btnFindMatch.TabIndex = 2;
            this.btnFindMatch.Text = "find a match";
            this.btnFindMatch.UseVisualStyleBackColor = true;
            this.btnFindMatch.Click += new System.EventHandler(this.btnFindMatch_Click);
            // 
            // lblTitleCouplesChart
            // 
            this.lblTitleCouplesChart.AutoSize = true;
            this.lblTitleCouplesChart.Location = new System.Drawing.Point(14, 232);
            this.lblTitleCouplesChart.Name = "lblTitleCouplesChart";
            this.lblTitleCouplesChart.Size = new System.Drawing.Size(67, 20);
            this.lblTitleCouplesChart.TabIndex = 3;
            this.lblTitleCouplesChart.Text = "Couples";
            this.lblTitleCouplesChart.Click += new System.EventHandler(this.lblTitleCouplesChart_Click);
            // 
            // lblTitleSignalWomenChart
            // 
            this.lblTitleSignalWomenChart.AutoSize = true;
            this.lblTitleSignalWomenChart.Location = new System.Drawing.Point(334, 232);
            this.lblTitleSignalWomenChart.Name = "lblTitleSignalWomenChart";
            this.lblTitleSignalWomenChart.Size = new System.Drawing.Size(207, 20);
            this.lblTitleSignalWomenChart.TabIndex = 5;
            this.lblTitleSignalWomenChart.Text = "Signal women (num of kids):";
            // 
            // lblTitleSignalMenChart
            // 
            this.lblTitleSignalMenChart.AutoSize = true;
            this.lblTitleSignalMenChart.Location = new System.Drawing.Point(651, 232);
            this.lblTitleSignalMenChart.Name = "lblTitleSignalMenChart";
            this.lblTitleSignalMenChart.Size = new System.Drawing.Size(239, 20);
            this.lblTitleSignalMenChart.TabIndex = 7;
            this.lblTitleSignalMenChart.Text = "Signal Men (distance from work):";
            // 
            // lstbxWomenNameChart
            // 
            this.lstbxWomenNameChart.FormattingEnabled = true;
            this.lstbxWomenNameChart.ItemHeight = 20;
            this.lstbxWomenNameChart.Location = new System.Drawing.Point(17, 36);
            this.lstbxWomenNameChart.Name = "lstbxWomenNameChart";
            this.lstbxWomenNameChart.Size = new System.Drawing.Size(207, 164);
            this.lstbxWomenNameChart.TabIndex = 9;
            // 
            // lstbxCouplesChart
            // 
            this.lstbxCouplesChart.FormattingEnabled = true;
            this.lstbxCouplesChart.ItemHeight = 20;
            this.lstbxCouplesChart.Location = new System.Drawing.Point(18, 272);
            this.lstbxCouplesChart.Name = "lstbxCouplesChart";
            this.lstbxCouplesChart.Size = new System.Drawing.Size(267, 144);
            this.lstbxCouplesChart.TabIndex = 10;
            // 
            // lstbxSignalWomenChart
            // 
            this.lstbxSignalWomenChart.FormattingEnabled = true;
            this.lstbxSignalWomenChart.ItemHeight = 20;
            this.lstbxSignalWomenChart.Location = new System.Drawing.Point(338, 272);
            this.lstbxSignalWomenChart.Name = "lstbxSignalWomenChart";
            this.lstbxSignalWomenChart.Size = new System.Drawing.Size(203, 144);
            this.lstbxSignalWomenChart.TabIndex = 11;
            // 
            // lstbxSignalMenChart
            // 
            this.lstbxSignalMenChart.FormattingEnabled = true;
            this.lstbxSignalMenChart.ItemHeight = 20;
            this.lstbxSignalMenChart.Location = new System.Drawing.Point(655, 272);
            this.lstbxSignalMenChart.Name = "lstbxSignalMenChart";
            this.lstbxSignalMenChart.Size = new System.Drawing.Size(235, 144);
            this.lstbxSignalMenChart.TabIndex = 12;
            // 
            // lblTitleSaveTofile
            // 
            this.lblTitleSaveTofile.AutoSize = true;
            this.lblTitleSaveTofile.Location = new System.Drawing.Point(17, 450);
            this.lblTitleSaveTofile.Name = "lblTitleSaveTofile";
            this.lblTitleSaveTofile.Size = new System.Drawing.Size(91, 20);
            this.lblTitleSaveTofile.TabIndex = 13;
            this.lblTitleSaveTofile.Text = "Save to file:";
            // 
            // rdbtnSignalMen
            // 
            this.rdbtnSignalMen.AutoSize = true;
            this.rdbtnSignalMen.Location = new System.Drawing.Point(21, 482);
            this.rdbtnSignalMen.Name = "rdbtnSignalMen";
            this.rdbtnSignalMen.Size = new System.Drawing.Size(110, 24);
            this.rdbtnSignalMen.TabIndex = 14;
            this.rdbtnSignalMen.TabStop = true;
            this.rdbtnSignalMen.Text = "signal men";
            this.rdbtnSignalMen.UseVisualStyleBackColor = true;
            // 
            // rdbtnSignalWomen
            // 
            this.rdbtnSignalWomen.AutoSize = true;
            this.rdbtnSignalWomen.Location = new System.Drawing.Point(21, 512);
            this.rdbtnSignalWomen.Name = "rdbtnSignalWomen";
            this.rdbtnSignalWomen.Size = new System.Drawing.Size(130, 24);
            this.rdbtnSignalWomen.TabIndex = 15;
            this.rdbtnSignalWomen.TabStop = true;
            this.rdbtnSignalWomen.Text = "signal women";
            this.rdbtnSignalWomen.UseVisualStyleBackColor = true;
            // 
            // rdbtnCouples
            // 
            this.rdbtnCouples.AutoSize = true;
            this.rdbtnCouples.Location = new System.Drawing.Point(21, 542);
            this.rdbtnCouples.Name = "rdbtnCouples";
            this.rdbtnCouples.Size = new System.Drawing.Size(89, 24);
            this.rdbtnCouples.TabIndex = 16;
            this.rdbtnCouples.TabStop = true;
            this.rdbtnCouples.Text = "couples";
            this.rdbtnCouples.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 719);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdbtnCouples);
            this.Controls.Add(this.rdbtnSignalWomen);
            this.Controls.Add(this.rdbtnSignalMen);
            this.Controls.Add(this.lblTitleSaveTofile);
            this.Controls.Add(this.lstbxSignalMenChart);
            this.Controls.Add(this.lstbxSignalWomenChart);
            this.Controls.Add(this.lstbxCouplesChart);
            this.Controls.Add(this.lstbxWomenNameChart);
            this.Controls.Add(this.lblTitleSignalMenChart);
            this.Controls.Add(this.lblTitleSignalWomenChart);
            this.Controls.Add(this.lblTitleCouplesChart);
            this.Controls.Add(this.btnFindMatch);
            this.Controls.Add(this.lblTitleWomenChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleWomenChart;
        private System.Windows.Forms.Button btnFindMatch;
        private System.Windows.Forms.Label lblTitleCouplesChart;
        private System.Windows.Forms.Label lblTitleSignalWomenChart;
        private System.Windows.Forms.Label lblTitleSignalMenChart;
        private System.Windows.Forms.ListBox lstbxWomenNameChart;
        private System.Windows.Forms.ListBox lstbxCouplesChart;
        private System.Windows.Forms.ListBox lstbxSignalWomenChart;
        private System.Windows.Forms.ListBox lstbxSignalMenChart;
        private System.Windows.Forms.Label lblTitleSaveTofile;
        private System.Windows.Forms.RadioButton rdbtnSignalMen;
        private System.Windows.Forms.RadioButton rdbtnSignalWomen;
        private System.Windows.Forms.RadioButton rdbtnCouples;
        private System.Windows.Forms.Button btnSave;
    }
}

