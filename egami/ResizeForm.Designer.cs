namespace egami
{
    partial class ResizeForm
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
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioButtonScale2 = new System.Windows.Forms.RadioButton();
            this.trackBarScale2 = new System.Windows.Forms.TrackBar();
            this.radioButtonScale = new System.Windows.Forms.RadioButton();
            this.groupBoxScale = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale2)).BeginInit();
            this.groupBoxScale.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Items.AddRange(new object[] {
            "Nearest neighbor",
            "Bilinear interpolation",
            "Bicubic interpolation"});
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(89, 16);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(141, 23);
            this.comboBoxAlgorithm.TabIndex = 1;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Location = new System.Drawing.Point(6, 19);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(61, 15);
            this.labelAlgorithm.TabIndex = 0;
            this.labelAlgorithm.Text = "Algorithm";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(6, 47);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(70, 15);
            this.labelScale.TabIndex = 2;
            this.labelScale.Text = "Scale Factor";
            // 
            // numericUpDownScale
            // 
            this.numericUpDownScale.DecimalPlaces = 2;
            this.numericUpDownScale.Location = new System.Drawing.Point(89, 45);
            this.numericUpDownScale.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Size = new System.Drawing.Size(141, 23);
            this.numericUpDownScale.TabIndex = 3;
            this.numericUpDownScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(172, 219);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 5;
            this.buttonApply.Text = "&apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(91, 219);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // radioButtonScale2
            // 
            this.radioButtonScale2.AutoSize = true;
            this.radioButtonScale2.Location = new System.Drawing.Point(12, 12);
            this.radioButtonScale2.Name = "radioButtonScale2";
            this.radioButtonScale2.Size = new System.Drawing.Size(136, 19);
            this.radioButtonScale2.TabIndex = 0;
            this.radioButtonScale2.TabStop = true;
            this.radioButtonScale2.Text = "Scale by a power of 2";
            this.radioButtonScale2.UseVisualStyleBackColor = true;
            this.radioButtonScale2.CheckedChanged += new System.EventHandler(this.radioButtonScale2_CheckedChanged);
            // 
            // trackBarScale2
            // 
            this.trackBarScale2.Enabled = false;
            this.trackBarScale2.LargeChange = 4;
            this.trackBarScale2.Location = new System.Drawing.Point(12, 37);
            this.trackBarScale2.Maximum = 8;
            this.trackBarScale2.Minimum = -8;
            this.trackBarScale2.Name = "trackBarScale2";
            this.trackBarScale2.Size = new System.Drawing.Size(236, 45);
            this.trackBarScale2.TabIndex = 1;
            // 
            // radioButtonScale
            // 
            this.radioButtonScale.AutoSize = true;
            this.radioButtonScale.Checked = true;
            this.radioButtonScale.Location = new System.Drawing.Point(12, 93);
            this.radioButtonScale.Name = "radioButtonScale";
            this.radioButtonScale.Size = new System.Drawing.Size(154, 19);
            this.radioButtonScale.TabIndex = 2;
            this.radioButtonScale.TabStop = true;
            this.radioButtonScale.Text = "Scale by a custom factor";
            this.radioButtonScale.UseVisualStyleBackColor = true;
            this.radioButtonScale.CheckedChanged += new System.EventHandler(this.radioButtonScale_CheckedChanged);
            // 
            // groupBoxScale
            // 
            this.groupBoxScale.Controls.Add(this.labelAlgorithm);
            this.groupBoxScale.Controls.Add(this.comboBoxAlgorithm);
            this.groupBoxScale.Controls.Add(this.labelScale);
            this.groupBoxScale.Controls.Add(this.numericUpDownScale);
            this.groupBoxScale.Location = new System.Drawing.Point(12, 118);
            this.groupBoxScale.Name = "groupBoxScale";
            this.groupBoxScale.Size = new System.Drawing.Size(236, 74);
            this.groupBoxScale.TabIndex = 3;
            this.groupBoxScale.TabStop = false;
            this.groupBoxScale.Text = "Custom scaling";
            // 
            // ResizeForm
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(259, 254);
            this.Controls.Add(this.groupBoxScale);
            this.Controls.Add(this.radioButtonScale);
            this.Controls.Add(this.trackBarScale2);
            this.Controls.Add(this.radioButtonScale2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize Image";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale2)).EndInit();
            this.groupBoxScale.ResumeLayout(false);
            this.groupBoxScale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButtonScale2;
        private System.Windows.Forms.TrackBar trackBarScale2;
        private System.Windows.Forms.RadioButton radioButtonScale;
        private System.Windows.Forms.GroupBox groupBoxScale;
    }
}