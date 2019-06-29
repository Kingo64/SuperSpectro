namespace SuperSpectro
{
    partial class UI
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
            this.bBuildList = new System.Windows.Forms.Button();
            this.bExecute = new System.Windows.Forms.Button();
            this.tbFiles = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbFilemask = new System.Windows.Forms.TextBox();
            this.lFileCounter = new System.Windows.Forms.Label();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.nThreads = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // bBuildList
            // 
            this.bBuildList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bBuildList.Location = new System.Drawing.Point(12, 353);
            this.bBuildList.Name = "bBuildList";
            this.bBuildList.Size = new System.Drawing.Size(75, 23);
            this.bBuildList.TabIndex = 1;
            this.bBuildList.Text = "Build List";
            this.bBuildList.UseVisualStyleBackColor = true;
            this.bBuildList.Click += new System.EventHandler(this.bBuildList_Click);
            // 
            // bExecute
            // 
            this.bExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bExecute.Location = new System.Drawing.Point(93, 353);
            this.bExecute.Name = "bExecute";
            this.bExecute.Size = new System.Drawing.Size(75, 23);
            this.bExecute.TabIndex = 2;
            this.bExecute.Text = "Execute";
            this.bExecute.UseVisualStyleBackColor = true;
            this.bExecute.Click += new System.EventHandler(this.bExecute_Click);
            // 
            // tbFiles
            // 
            this.tbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiles.Location = new System.Drawing.Point(12, 12);
            this.tbFiles.MaxLength = 65565;
            this.tbFiles.Multiline = true;
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFiles.Size = new System.Drawing.Size(514, 282);
            this.tbFiles.TabIndex = 3;
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Location = new System.Drawing.Point(60, 327);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(390, 20);
            this.tbOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input:";
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(60, 301);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(406, 20);
            this.tbInput.TabIndex = 4;
            // 
            // tbFilemask
            // 
            this.tbFilemask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilemask.Location = new System.Drawing.Point(472, 300);
            this.tbFilemask.Name = "tbFilemask";
            this.tbFilemask.Size = new System.Drawing.Size(54, 20);
            this.tbFilemask.TabIndex = 6;
            this.tbFilemask.Text = "*.flac";
            // 
            // lFileCounter
            // 
            this.lFileCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lFileCounter.AutoSize = true;
            this.lFileCounter.Location = new System.Drawing.Point(174, 358);
            this.lFileCounter.Name = "lFileCounter";
            this.lFileCounter.Size = new System.Drawing.Size(40, 13);
            this.lFileCounter.TabIndex = 7;
            this.lFileCounter.Text = "Files: 0";
            // 
            // tbRes
            // 
            this.tbRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRes.Location = new System.Drawing.Point(456, 326);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(70, 20);
            this.tbRes.TabIndex = 6;
            this.tbRes.Text = "512x1024";
            // 
            // nThreads
            // 
            this.nThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nThreads.Location = new System.Drawing.Point(483, 356);
            this.nThreads.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nThreads.Name = "nThreads";
            this.nThreads.Size = new System.Drawing.Size(43, 20);
            this.nThreads.TabIndex = 8;
            this.nThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Threads:";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nThreads);
            this.Controls.Add(this.lFileCounter);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.tbFilemask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbFiles);
            this.Controls.Add(this.bExecute);
            this.Controls.Add(this.bBuildList);
            this.Name = "UI";
            this.Text = "SuperSpectro";
            ((System.ComponentModel.ISupportInitialize)(this.nThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bBuildList;
        private System.Windows.Forms.Button bExecute;
        private System.Windows.Forms.TextBox tbFiles;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbFilemask;
        private System.Windows.Forms.Label lFileCounter;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.NumericUpDown nThreads;
        private System.Windows.Forms.Label label3;
    }
}

