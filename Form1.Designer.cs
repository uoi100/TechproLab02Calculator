namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_period = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_PrevOperations = new System.Windows.Forms.TextBox();
            this.text_currentOperation = new System.Windows.Forms.TextBox();
            this.btn_On = new System.Windows.Forms.Button();
            this.Numbers = new System.Windows.Forms.GroupBox();
            this.btn_PosNeg = new System.Windows.Forms.Button();
            this.Operations = new System.Windows.Forms.GroupBox();
            this.btn_CE = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_backSpace = new System.Windows.Forms.Button();
            this.btn_MPlus = new System.Windows.Forms.Button();
            this.btn_MRecall = new System.Windows.Forms.Button();
            this.btn_MClear = new System.Windows.Forms.Button();
            this.btn_MStore = new System.Windows.Forms.Button();
            this.MemoryBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Numbers.SuspendLayout();
            this.Operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MemoryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btn_backSpace);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.btn_CE);
            this.groupBox1.Controls.Add(this.btn_equals);
            this.groupBox1.Location = new System.Drawing.Point(296, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(56, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_division
            // 
            this.btn_division.AutoSize = true;
            this.btn_division.Location = new System.Drawing.Point(3, 16);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(50, 25);
            this.btn_division.TabIndex = 7;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.AutoSize = true;
            this.btn_multiply.Location = new System.Drawing.Point(3, 45);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(50, 25);
            this.btn_multiply.TabIndex = 6;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.AutoSize = true;
            this.btn_minus.Location = new System.Drawing.Point(3, 74);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(50, 25);
            this.btn_minus.TabIndex = 5;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.AutoSize = true;
            this.btn_plus.Location = new System.Drawing.Point(3, 103);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(50, 25);
            this.btn_plus.TabIndex = 4;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btn_equals
            // 
            this.btn_equals.AutoSize = true;
            this.btn_equals.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_equals.Location = new System.Drawing.Point(3, 103);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(50, 25);
            this.btn_equals.TabIndex = 3;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_period
            // 
            this.btn_period.AutoSize = true;
            this.btn_period.Location = new System.Drawing.Point(59, 103);
            this.btn_period.Name = "btn_period";
            this.btn_period.Size = new System.Drawing.Size(50, 25);
            this.btn_period.TabIndex = 9;
            this.btn_period.Text = ".";
            this.btn_period.UseVisualStyleBackColor = true;
            this.btn_period.Click += new System.EventHandler(this.Operations_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(3, 103);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 25);
            this.button10.TabIndex = 3;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Location = new System.Drawing.Point(115, 74);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 25);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(59, 74);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 25);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(3, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 25);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(115, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(59, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(3, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(115, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(59, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(3, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumClickEvent);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.text_PrevOperations);
            this.panel1.Controls.Add(this.text_currentOperation);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(4, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 37);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // text_PrevOperations
            // 
            this.text_PrevOperations.Location = new System.Drawing.Point(0, 0);
            this.text_PrevOperations.Margin = new System.Windows.Forms.Padding(0);
            this.text_PrevOperations.Name = "text_PrevOperations";
            this.text_PrevOperations.ReadOnly = true;
            this.text_PrevOperations.Size = new System.Drawing.Size(348, 20);
            this.text_PrevOperations.TabIndex = 1;
            this.text_PrevOperations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_currentOperation
            // 
            this.text_currentOperation.Location = new System.Drawing.Point(0, 17);
            this.text_currentOperation.Margin = new System.Windows.Forms.Padding(0);
            this.text_currentOperation.Name = "text_currentOperation";
            this.text_currentOperation.ReadOnly = true;
            this.text_currentOperation.Size = new System.Drawing.Size(348, 20);
            this.text_currentOperation.TabIndex = 0;
            this.text_currentOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_On
            // 
            this.btn_On.Location = new System.Drawing.Point(355, 13);
            this.btn_On.Name = "btn_On";
            this.btn_On.Size = new System.Drawing.Size(65, 37);
            this.btn_On.TabIndex = 2;
            this.btn_On.Text = "On";
            this.btn_On.UseVisualStyleBackColor = true;
            this.btn_On.Click += new System.EventHandler(this.btn_On_Click);
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Numbers.Controls.Add(this.btn_PosNeg);
            this.Numbers.Controls.Add(this.button5);
            this.Numbers.Controls.Add(this.btn_period);
            this.Numbers.Controls.Add(this.button1);
            this.Numbers.Controls.Add(this.button2);
            this.Numbers.Controls.Add(this.button10);
            this.Numbers.Controls.Add(this.button3);
            this.Numbers.Controls.Add(this.button4);
            this.Numbers.Controls.Add(this.button9);
            this.Numbers.Controls.Add(this.button6);
            this.Numbers.Controls.Add(this.button7);
            this.Numbers.Controls.Add(this.button8);
            this.Numbers.Location = new System.Drawing.Point(4, 57);
            this.Numbers.Name = "Numbers";
            this.Numbers.Padding = new System.Windows.Forms.Padding(0);
            this.Numbers.Size = new System.Drawing.Size(168, 144);
            this.Numbers.TabIndex = 3;
            this.Numbers.TabStop = false;
            // 
            // btn_PosNeg
            // 
            this.btn_PosNeg.AutoSize = true;
            this.btn_PosNeg.Location = new System.Drawing.Point(115, 103);
            this.btn_PosNeg.Name = "btn_PosNeg";
            this.btn_PosNeg.Size = new System.Drawing.Size(50, 25);
            this.btn_PosNeg.TabIndex = 10;
            this.btn_PosNeg.Text = "+/-";
            this.btn_PosNeg.UseVisualStyleBackColor = true;
            this.btn_PosNeg.Click += new System.EventHandler(this.btn_PosNeg_click);
            // 
            // Operations
            // 
            this.Operations.AutoSize = true;
            this.Operations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Operations.Controls.Add(this.btn_plus);
            this.Operations.Controls.Add(this.btn_minus);
            this.Operations.Controls.Add(this.btn_multiply);
            this.Operations.Controls.Add(this.btn_division);
            this.Operations.Location = new System.Drawing.Point(175, 57);
            this.Operations.Name = "Operations";
            this.Operations.Padding = new System.Windows.Forms.Padding(0);
            this.Operations.Size = new System.Drawing.Size(56, 144);
            this.Operations.TabIndex = 4;
            this.Operations.TabStop = false;
            // 
            // btn_CE
            // 
            this.btn_CE.AutoSize = true;
            this.btn_CE.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_CE.Location = new System.Drawing.Point(3, 45);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(50, 25);
            this.btn_CE.TabIndex = 4;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button11.Location = new System.Drawing.Point(3, 16);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 25);
            this.button11.TabIndex = 5;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Calculator.Properties.Resources.lab02_Calculator_Picture;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 168);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_backSpace
            // 
            this.btn_backSpace.AutoSize = true;
            this.btn_backSpace.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_backSpace.Location = new System.Drawing.Point(3, 74);
            this.btn_backSpace.Name = "btn_backSpace";
            this.btn_backSpace.Size = new System.Drawing.Size(50, 25);
            this.btn_backSpace.TabIndex = 6;
            this.btn_backSpace.Text = "<-";
            this.btn_backSpace.UseVisualStyleBackColor = true;
            this.btn_backSpace.Click += new System.EventHandler(this.btn_BackSpace_Click);
            // 
            // btn_MPlus
            // 
            this.btn_MPlus.AutoSize = true;
            this.btn_MPlus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_MPlus.Location = new System.Drawing.Point(3, 16);
            this.btn_MPlus.Name = "btn_MPlus";
            this.btn_MPlus.Size = new System.Drawing.Size(50, 25);
            this.btn_MPlus.TabIndex = 6;
            this.btn_MPlus.Text = "M+";
            this.btn_MPlus.UseVisualStyleBackColor = true;
            this.btn_MPlus.Click += new System.EventHandler(this.btn_Memory_Click);
            // 
            // btn_MRecall
            // 
            this.btn_MRecall.AutoSize = true;
            this.btn_MRecall.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_MRecall.Location = new System.Drawing.Point(3, 45);
            this.btn_MRecall.Name = "btn_MRecall";
            this.btn_MRecall.Size = new System.Drawing.Size(50, 25);
            this.btn_MRecall.TabIndex = 7;
            this.btn_MRecall.Text = "MR";
            this.btn_MRecall.UseVisualStyleBackColor = true;
            this.btn_MRecall.Click += new System.EventHandler(this.btn_Memory_Click);
            // 
            // btn_MClear
            // 
            this.btn_MClear.AutoSize = true;
            this.btn_MClear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_MClear.Location = new System.Drawing.Point(3, 74);
            this.btn_MClear.Name = "btn_MClear";
            this.btn_MClear.Size = new System.Drawing.Size(50, 25);
            this.btn_MClear.TabIndex = 8;
            this.btn_MClear.Text = "MC";
            this.btn_MClear.UseVisualStyleBackColor = true;
            this.btn_MClear.Click += new System.EventHandler(this.btn_Memory_Click);
            // 
            // btn_MStore
            // 
            this.btn_MStore.AutoSize = true;
            this.btn_MStore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_MStore.Location = new System.Drawing.Point(3, 103);
            this.btn_MStore.Name = "btn_MStore";
            this.btn_MStore.Size = new System.Drawing.Size(50, 25);
            this.btn_MStore.TabIndex = 9;
            this.btn_MStore.Text = "MS";
            this.btn_MStore.UseVisualStyleBackColor = true;
            this.btn_MStore.Click += new System.EventHandler(this.btn_Memory_Click);
            // 
            // MemoryBox
            // 
            this.MemoryBox.AutoSize = true;
            this.MemoryBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MemoryBox.Controls.Add(this.btn_MPlus);
            this.MemoryBox.Controls.Add(this.btn_MStore);
            this.MemoryBox.Controls.Add(this.btn_MRecall);
            this.MemoryBox.Controls.Add(this.btn_MClear);
            this.MemoryBox.Location = new System.Drawing.Point(234, 57);
            this.MemoryBox.Name = "MemoryBox";
            this.MemoryBox.Padding = new System.Windows.Forms.Padding(0);
            this.MemoryBox.Size = new System.Drawing.Size(56, 144);
            this.MemoryBox.TabIndex = 10;
            this.MemoryBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_equals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(424, 397);
            this.Controls.Add(this.MemoryBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.btn_On);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 436);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Numbers.ResumeLayout(false);
            this.Numbers.PerformLayout();
            this.Operations.ResumeLayout(false);
            this.Operations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MemoryBox.ResumeLayout(false);
            this.MemoryBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_period;
        private System.Windows.Forms.Button btn_On;
        private System.Windows.Forms.TextBox text_PrevOperations;
        private System.Windows.Forms.TextBox text_currentOperation;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.GroupBox Numbers;
        private System.Windows.Forms.Button btn_PosNeg;
        private System.Windows.Forms.GroupBox Operations;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_backSpace;
        private System.Windows.Forms.Button btn_MPlus;
        private System.Windows.Forms.Button btn_MRecall;
        private System.Windows.Forms.Button btn_MClear;
        private System.Windows.Forms.Button btn_MStore;
        private System.Windows.Forms.GroupBox MemoryBox;
    }
}

