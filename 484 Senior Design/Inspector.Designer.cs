namespace _484_Senior_Design
{
    partial class Inspector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inspector));
            this.btn_Analyse = new System.Windows.Forms.Button();
            this.btn_Capture = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.textBox_DefectType = new System.Windows.Forms.TextBox();
            this.label_Results = new System.Windows.Forms.Label();
            this.label_DefectType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Analyse
            // 
            this.btn_Analyse.Location = new System.Drawing.Point(974, 702);
            this.btn_Analyse.Name = "btn_Analyse";
            this.btn_Analyse.Size = new System.Drawing.Size(235, 73);
            this.btn_Analyse.TabIndex = 1;
            this.btn_Analyse.Text = "ANALYSE";
            this.btn_Analyse.UseVisualStyleBackColor = true;
            this.btn_Analyse.Click += new System.EventHandler(this.analyse_Btn_Click);
            // 
            // btn_Capture
            // 
            this.btn_Capture.Location = new System.Drawing.Point(269, 702);
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(235, 73);
            this.btn_Capture.TabIndex = 2;
            this.btn_Capture.Text = "CAPTURE";
            this.btn_Capture.UseVisualStyleBackColor = true;
            this.btn_Capture.Click += new System.EventHandler(this.capture_Btn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(269, 55);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(940, 522);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(359, 601);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(850, 27);
            this.textBox_Result.TabIndex = 4;
            // 
            // textBox_DefectType
            // 
            this.textBox_DefectType.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DefectType.Location = new System.Drawing.Point(410, 634);
            this.textBox_DefectType.Name = "textBox_DefectType";
            this.textBox_DefectType.Size = new System.Drawing.Size(799, 27);
            this.textBox_DefectType.TabIndex = 5;
            // 
            // label_Results
            // 
            this.label_Results.AutoSize = true;
            this.label_Results.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Results.Location = new System.Drawing.Point(266, 604);
            this.label_Results.Name = "label_Results";
            this.label_Results.Size = new System.Drawing.Size(78, 17);
            this.label_Results.TabIndex = 6;
            this.label_Results.Text = "Result:";
            // 
            // label_DefectType
            // 
            this.label_DefectType.AutoSize = true;
            this.label_DefectType.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DefectType.Location = new System.Drawing.Point(266, 637);
            this.label_DefectType.Name = "label_DefectType";
            this.label_DefectType.Size = new System.Drawing.Size(128, 17);
            this.label_DefectType.TabIndex = 7;
            this.label_DefectType.Text = "Defect Type:";
            // 
            // Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 854);
            this.Controls.Add(this.label_DefectType);
            this.Controls.Add(this.label_Results);
            this.Controls.Add(this.textBox_DefectType);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btn_Capture);
            this.Controls.Add(this.btn_Analyse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Inspector";
            this.Text = "Portable Material Inspector";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Analyse;
        private System.Windows.Forms.Button btn_Capture;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox textBox_DefectType;
        private System.Windows.Forms.Label label_Results;
        private System.Windows.Forms.Label label_DefectType;
    }
}

