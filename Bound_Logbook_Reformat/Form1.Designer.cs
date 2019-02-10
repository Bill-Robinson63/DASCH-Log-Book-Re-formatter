namespace WindowsFormsApplication1
{
    partial class BoundLogbookReformat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoundLogbookReformat));
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelectImages = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReformatImages = new System.Windows.Forms.Button();
            this.progressBarReformat = new System.Windows.Forms.ProgressBar();
            this.checkBoxArrow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDefCuts = new System.Windows.Forms.Button();
            this.numericUpDown1Start = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1Stop = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2Start = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2Stop = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Stop)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.DefaultExt = "jpg";
            this.openFileDialogImage.FileName = "openFileDialogImage";
            this.openFileDialogImage.Multiselect = true;
            this.openFileDialogImage.Title = "Select Image Files to Format";
            // 
            // buttonSelectImages
            // 
            this.buttonSelectImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSelectImages.Location = new System.Drawing.Point(12, 430);
            this.buttonSelectImages.Name = "buttonSelectImages";
            this.buttonSelectImages.Size = new System.Drawing.Size(111, 23);
            this.buttonSelectImages.TabIndex = 0;
            this.buttonSelectImages.Text = "Select Images";
            this.buttonSelectImages.UseVisualStyleBackColor = true;
            this.buttonSelectImages.Click += new System.EventHandler(this.buttonSelectImages_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(621, 430);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReformatImages
            // 
            this.buttonReformatImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReformatImages.Enabled = false;
            this.buttonReformatImages.Location = new System.Drawing.Point(146, 430);
            this.buttonReformatImages.Name = "buttonReformatImages";
            this.buttonReformatImages.Size = new System.Drawing.Size(128, 23);
            this.buttonReformatImages.TabIndex = 2;
            this.buttonReformatImages.Text = "Reformat Images";
            this.buttonReformatImages.UseVisualStyleBackColor = true;
            this.buttonReformatImages.Click += new System.EventHandler(this.buttonReformatImages_Click);
            // 
            // progressBarReformat
            // 
            this.progressBarReformat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarReformat.Location = new System.Drawing.Point(12, 12);
            this.progressBarReformat.Name = "progressBarReformat";
            this.progressBarReformat.Size = new System.Drawing.Size(684, 26);
            this.progressBarReformat.TabIndex = 3;
            this.progressBarReformat.UseWaitCursor = true;
            this.progressBarReformat.Visible = false;
            // 
            // checkBoxArrow
            // 
            this.checkBoxArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxArrow.AutoSize = true;
            this.checkBoxArrow.Location = new System.Drawing.Point(12, 387);
            this.checkBoxArrow.Name = "checkBoxArrow";
            this.checkBoxArrow.Size = new System.Drawing.Size(139, 21);
            this.checkBoxArrow.TabIndex = 4;
            this.checkBoxArrow.Text = "Insert Start Arrow";
            this.checkBoxArrow.UseVisualStyleBackColor = true;
            this.checkBoxArrow.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cut Positions (pixels):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cut One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(408, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cut Two";
            // 
            // buttonDefCuts
            // 
            this.buttonDefCuts.Location = new System.Drawing.Point(570, 115);
            this.buttonDefCuts.Name = "buttonDefCuts";
            this.buttonDefCuts.Size = new System.Drawing.Size(126, 23);
            this.buttonDefCuts.TabIndex = 16;
            this.buttonDefCuts.Text = "Restore Defaults";
            this.buttonDefCuts.UseVisualStyleBackColor = true;
            this.buttonDefCuts.Click += new System.EventHandler(this.buttonDefCuts_Click);
            // 
            // numericUpDown1Start
            // 
            this.numericUpDown1Start.Location = new System.Drawing.Point(170, 117);
            this.numericUpDown1Start.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1Start.Name = "numericUpDown1Start";
            this.numericUpDown1Start.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown1Start.TabIndex = 17;
            // 
            // numericUpDown1Stop
            // 
            this.numericUpDown1Stop.Location = new System.Drawing.Point(232, 117);
            this.numericUpDown1Stop.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1Stop.Name = "numericUpDown1Stop";
            this.numericUpDown1Stop.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown1Stop.TabIndex = 18;
            // 
            // numericUpDown2Start
            // 
            this.numericUpDown2Start.Location = new System.Drawing.Point(402, 117);
            this.numericUpDown2Start.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown2Start.Name = "numericUpDown2Start";
            this.numericUpDown2Start.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown2Start.TabIndex = 19;
            // 
            // numericUpDown2Stop
            // 
            this.numericUpDown2Stop.Location = new System.Drawing.Point(464, 117);
            this.numericUpDown2Stop.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown2Stop.Name = "numericUpDown2Stop";
            this.numericUpDown2Stop.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown2Stop.TabIndex = 20;
            // 
            // BoundLogbookReformat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoundLogbookReformatApplication.Properties.Resources.daschlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 477);
            this.Controls.Add(this.numericUpDown2Stop);
            this.Controls.Add(this.numericUpDown2Start);
            this.Controls.Add(this.numericUpDown1Stop);
            this.Controls.Add(this.numericUpDown1Start);
            this.Controls.Add(this.buttonDefCuts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxArrow);
            this.Controls.Add(this.progressBarReformat);
            this.Controls.Add(this.buttonReformatImages);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSelectImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "BoundLogbookReformat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bound Logbook Reformat";
            this.Load += new System.EventHandler(this.BoundLogbookReformat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Stop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonSelectImages;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReformatImages;
        private System.Windows.Forms.ProgressBar progressBarReformat;
        private System.Windows.Forms.CheckBox checkBoxArrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDefCuts;
        private System.Windows.Forms.NumericUpDown numericUpDown1Start;
        private System.Windows.Forms.NumericUpDown numericUpDown1Stop;
        private System.Windows.Forms.NumericUpDown numericUpDown2Start;
        private System.Windows.Forms.NumericUpDown numericUpDown2Stop;
    }
}

