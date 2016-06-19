namespace FizzBuzzWinUI
{
    partial class FBWinUI
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
            this.bulkChk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericNTxt = new System.Windows.Forms.NumericUpDown();
            this.addparmBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.replacestrTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paramListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.processBtn = new System.Windows.Forms.Button();
            this.startnumNTxt = new System.Windows.Forms.NumericUpDown();
            this.endnumNTxt = new System.Windows.Forms.NumericUpDown();
            this.removeBtn = new System.Windows.Forms.Button();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNTxt)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startnumNTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endnumNTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Number";
            // 
            // bulkChk
            // 
            this.bulkChk.AutoSize = true;
            this.bulkChk.Location = new System.Drawing.Point(12, 1);
            this.bulkChk.Name = "bulkChk";
            this.bulkChk.Size = new System.Drawing.Size(102, 17);
            this.bulkChk.TabIndex = 1;
            this.bulkChk.Text = "Bulk Processing";
            this.bulkChk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeBtn);
            this.groupBox1.Controls.Add(this.numericNTxt);
            this.groupBox1.Controls.Add(this.addparmBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.replacestrTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.paramListBox);
            this.groupBox1.Location = new System.Drawing.Point(29, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 330);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement Parameters";
            // 
            // numericNTxt
            // 
            this.numericNTxt.Location = new System.Drawing.Point(9, 44);
            this.numericNTxt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericNTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNTxt.Name = "numericNTxt";
            this.numericNTxt.Size = new System.Drawing.Size(108, 20);
            this.numericNTxt.TabIndex = 4;
            this.numericNTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addparmBtn
            // 
            this.addparmBtn.Location = new System.Drawing.Point(245, 27);
            this.addparmBtn.Name = "addparmBtn";
            this.addparmBtn.Size = new System.Drawing.Size(87, 35);
            this.addparmBtn.TabIndex = 6;
            this.addparmBtn.Text = "Add To List";
            this.addparmBtn.UseVisualStyleBackColor = true;
            this.addparmBtn.Click += new System.EventHandler(this.addparmBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Replacement String";
            // 
            // replacestrTxt
            // 
            this.replacestrTxt.Location = new System.Drawing.Point(126, 43);
            this.replacestrTxt.Name = "replacestrTxt";
            this.replacestrTxt.Size = new System.Drawing.Size(100, 20);
            this.replacestrTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numeric";
            // 
            // paramListBox
            // 
            this.paramListBox.FormattingEnabled = true;
            this.paramListBox.Location = new System.Drawing.Point(9, 74);
            this.paramListBox.Name = "paramListBox";
            this.paramListBox.Size = new System.Drawing.Size(217, 212);
            this.paramListBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputTxt);
            this.groupBox2.Location = new System.Drawing.Point(433, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 576);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(274, 34);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(106, 36);
            this.processBtn.TabIndex = 7;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // startnumNTxt
            // 
            this.startnumNTxt.Location = new System.Drawing.Point(29, 50);
            this.startnumNTxt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.startnumNTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startnumNTxt.Name = "startnumNTxt";
            this.startnumNTxt.Size = new System.Drawing.Size(109, 20);
            this.startnumNTxt.TabIndex = 2;
            this.startnumNTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startnumNTxt.ValueChanged += new System.EventHandler(this.startnumNTxt_ValueChanged);
            // 
            // endnumNTxt
            // 
            this.endnumNTxt.Location = new System.Drawing.Point(144, 50);
            this.endnumNTxt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.endnumNTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endnumNTxt.Name = "endnumNTxt";
            this.endnumNTxt.Size = new System.Drawing.Size(108, 20);
            this.endnumNTxt.TabIndex = 3;
            this.endnumNTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(245, 85);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(78, 35);
            this.removeBtn.TabIndex = 9;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(15, 19);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTxt.Size = new System.Drawing.Size(441, 539);
            this.outputTxt.TabIndex = 1;
            // 
            // FBWinUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 612);
            this.Controls.Add(this.endnumNTxt);
            this.Controls.Add(this.startnumNTxt);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bulkChk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FBWinUI";
            this.Text = "FizzBuzz Winform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNTxt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startnumNTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endnumNTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox bulkChk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericNTxt;
        private System.Windows.Forms.Button addparmBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox replacestrTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox paramListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.NumericUpDown startnumNTxt;
        private System.Windows.Forms.NumericUpDown endnumNTxt;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox outputTxt;
    }
}