
using System;

namespace CallOffCreator1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CallOffLabel = new System.Windows.Forms.Label();
            this.VinNumberLabel = new System.Windows.Forms.Label();
            this.PartFamilyLabel = new System.Windows.Forms.Label();
            this.CallOffBox = new System.Windows.Forms.TextBox();
            this.VinNumberBox = new System.Windows.Forms.TextBox();
            this.PartFamilyBox = new System.Windows.Forms.TextBox();
            this.CreateFileButton1 = new System.Windows.Forms.Button();
            this.SupplierNum = new System.Windows.Forms.Label();
            this.ProcessSequenceLabel = new System.Windows.Forms.Label();
            this.PartFamSeq = new System.Windows.Forms.Label();
            this.SWETTime = new System.Windows.Forms.Label();
            this.SupplierNumberBox = new System.Windows.Forms.TextBox();
            this.ProcessSequenceBox = new System.Windows.Forms.TextBox();
            this.PartFamilySeqBox = new System.Windows.Forms.TextBox();
            this.SWETTimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.OrderNumberBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BuildNumBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CallOffLabel
            // 
            this.CallOffLabel.AutoSize = true;
            this.CallOffLabel.Location = new System.Drawing.Point(98, 58);
            this.CallOffLabel.Name = "CallOffLabel";
            this.CallOffLabel.Size = new System.Drawing.Size(96, 15);
            this.CallOffLabel.TabIndex = 0;
            this.CallOffLabel.Text = "Call-Off Number";
            // 
            // VinNumberLabel
            // 
            this.VinNumberLabel.AutoSize = true;
            this.VinNumberLabel.Location = new System.Drawing.Point(100, 306);
            this.VinNumberLabel.Name = "VinNumberLabel";
            this.VinNumberLabel.Size = new System.Drawing.Size(71, 15);
            this.VinNumberLabel.TabIndex = 1;
            this.VinNumberLabel.Text = "Vin Number";
            // 
            // PartFamilyLabel
            // 
            this.PartFamilyLabel.AutoSize = true;
            this.PartFamilyLabel.Location = new System.Drawing.Point(98, 128);
            this.PartFamilyLabel.Name = "PartFamilyLabel";
            this.PartFamilyLabel.Size = new System.Drawing.Size(66, 15);
            this.PartFamilyLabel.TabIndex = 2;
            this.PartFamilyLabel.Text = "Part Family";
            // 
            // CallOffBox
            // 
            this.CallOffBox.Location = new System.Drawing.Point(257, 50);
            this.CallOffBox.Name = "CallOffBox";
            this.CallOffBox.Size = new System.Drawing.Size(100, 23);
            this.CallOffBox.TabIndex = 3;
            // 
            // VinNumberBox
            // 
            this.VinNumberBox.Location = new System.Drawing.Point(257, 303);
            this.VinNumberBox.Name = "VinNumberBox";
            this.VinNumberBox.Size = new System.Drawing.Size(100, 23);
            this.VinNumberBox.TabIndex = 4;
            // 
            // PartFamilyBox
            // 
            this.PartFamilyBox.Location = new System.Drawing.Point(257, 120);
            this.PartFamilyBox.Name = "PartFamilyBox";
            this.PartFamilyBox.Size = new System.Drawing.Size(100, 23);
            this.PartFamilyBox.TabIndex = 5;
            // 
            // CreateFileButton1
            // 
            this.CreateFileButton1.Location = new System.Drawing.Point(98, 351);
            this.CreateFileButton1.Name = "CreateFileButton1";
            this.CreateFileButton1.Size = new System.Drawing.Size(453, 42);
            this.CreateFileButton1.TabIndex = 6;
            this.CreateFileButton1.Text = "Create Call-Off File";
            this.CreateFileButton1.UseVisualStyleBackColor = true;
            this.CreateFileButton1.Click += new System.EventHandler(this.CreateFileButton1_Click);
            // 
            // SupplierNum
            // 
            this.SupplierNum.AutoSize = true;
            this.SupplierNum.Location = new System.Drawing.Point(100, 24);
            this.SupplierNum.Name = "SupplierNum";
            this.SupplierNum.Size = new System.Drawing.Size(97, 15);
            this.SupplierNum.TabIndex = 7;
            this.SupplierNum.Text = "Supplier Number";
            // 
            // ProcessSequenceLabel
            // 
            this.ProcessSequenceLabel.AutoSize = true;
            this.ProcessSequenceLabel.Location = new System.Drawing.Point(100, 200);
            this.ProcessSequenceLabel.Name = "ProcessSequenceLabel";
            this.ProcessSequenceLabel.Size = new System.Drawing.Size(101, 15);
            this.ProcessSequenceLabel.TabIndex = 8;
            this.ProcessSequenceLabel.Text = "Process Sequence";
            // 
            // PartFamSeq
            // 
            this.PartFamSeq.AutoSize = true;
            this.PartFamSeq.Location = new System.Drawing.Point(98, 92);
            this.PartFamSeq.Name = "PartFamSeq";
            this.PartFamSeq.Size = new System.Drawing.Size(120, 15);
            this.PartFamSeq.TabIndex = 9;
            this.PartFamSeq.Text = "Part Family Sequence";
            // 
            // SWETTime
            // 
            this.SWETTime.AutoSize = true;
            this.SWETTime.Location = new System.Drawing.Point(98, 168);
            this.SWETTime.Name = "SWETTime";
            this.SWETTime.Size = new System.Drawing.Size(65, 15);
            this.SWETTime.TabIndex = 10;
            this.SWETTime.Text = "SWET Time";
            // 
            // SupplierNumberBox
            // 
            this.SupplierNumberBox.Location = new System.Drawing.Point(257, 16);
            this.SupplierNumberBox.Name = "SupplierNumberBox";
            this.SupplierNumberBox.Size = new System.Drawing.Size(100, 23);
            this.SupplierNumberBox.TabIndex = 11;
            this.SupplierNumberBox.TextChanged += new System.EventHandler(this.SupplierNumberBox_TextChanged);
            // 
            // ProcessSequenceBox
            // 
            this.ProcessSequenceBox.Location = new System.Drawing.Point(257, 197);
            this.ProcessSequenceBox.Name = "ProcessSequenceBox";
            this.ProcessSequenceBox.Size = new System.Drawing.Size(100, 23);
            this.ProcessSequenceBox.TabIndex = 12;
            // 
            // PartFamilySeqBox
            // 
            this.PartFamilySeqBox.Location = new System.Drawing.Point(257, 84);
            this.PartFamilySeqBox.Name = "PartFamilySeqBox";
            this.PartFamilySeqBox.Size = new System.Drawing.Size(100, 23);
            this.PartFamilySeqBox.TabIndex = 13;
            // 
            // SWETTimeBox
            // 
            this.SWETTimeBox.Location = new System.Drawing.Point(257, 160);
            this.SWETTimeBox.Name = "SWETTimeBox";
            this.SWETTimeBox.Size = new System.Drawing.Size(100, 23);
            this.SWETTimeBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Example: STFGBR11";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Example: 23.11.2019-11:56";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Example: 00440397";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Example: 96402441";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Example: 116856";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Example: 964024410000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Example: 1989596";
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Location = new System.Drawing.Point(98, 236);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(84, 15);
            this.OrderNumberLabel.TabIndex = 22;
            this.OrderNumberLabel.Text = "Order Number";
            // 
            // OrderNumberBox
            // 
            this.OrderNumberBox.Location = new System.Drawing.Point(257, 233);
            this.OrderNumberBox.Name = "OrderNumberBox";
            this.OrderNumberBox.Size = new System.Drawing.Size(100, 23);
            this.OrderNumberBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Example: LX31522";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Build Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Example: 11518";
            // 
            // BuildNumBox
            // 
            this.BuildNumBox.Location = new System.Drawing.Point(257, 268);
            this.BuildNumBox.Name = "BuildNumBox";
            this.BuildNumBox.Size = new System.Drawing.Size(100, 23);
            this.BuildNumBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BuildNumBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OrderNumberBox);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SWETTimeBox);
            this.Controls.Add(this.PartFamilySeqBox);
            this.Controls.Add(this.ProcessSequenceBox);
            this.Controls.Add(this.SupplierNumberBox);
            this.Controls.Add(this.SWETTime);
            this.Controls.Add(this.PartFamSeq);
            this.Controls.Add(this.ProcessSequenceLabel);
            this.Controls.Add(this.SupplierNum);
            this.Controls.Add(this.CreateFileButton1);
            this.Controls.Add(this.PartFamilyBox);
            this.Controls.Add(this.VinNumberBox);
            this.Controls.Add(this.CallOffBox);
            this.Controls.Add(this.PartFamilyLabel);
            this.Controls.Add(this.VinNumberLabel);
            this.Controls.Add(this.CallOffLabel);
            this.Name = "Form1";
            this.Text = "Call-Off Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       // private void Form1_Load(object sender, EventArgs e)
       // {
           // throw new NotImplementedException();
       // }

        #endregion

        private System.Windows.Forms.Label CallOffLabel;
        private System.Windows.Forms.Label VinNumberLabel;
        private System.Windows.Forms.Label PartFamilyLabel;
        private System.Windows.Forms.TextBox CallOffBox;
        private System.Windows.Forms.TextBox VinNumberBox;
        private System.Windows.Forms.TextBox PartFamilyBox;
        private System.Windows.Forms.Button CreateFileButton1;
        private System.Windows.Forms.Label SupplierNum;
        private System.Windows.Forms.Label ProcessSequenceLabel;
        private System.Windows.Forms.Label PartFamSeq;
        private System.Windows.Forms.Label SWETTime;
        private System.Windows.Forms.TextBox SupplierNumberBox;
        private System.Windows.Forms.TextBox ProcessSequenceBox;
        private System.Windows.Forms.TextBox PartFamilySeqBox;
        private System.Windows.Forms.TextBox SWETTimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.TextBox OrderNumberBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BuildNumBox;
    }
}

