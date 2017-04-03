namespace Calculator
{
    partial class frmCalculator
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
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMplus = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReciprocal.Location = new System.Drawing.Point(213, 124);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(32, 32);
            this.btnReciprocal.TabIndex = 42;
            this.btnReciprocal.Tag = "9";
            this.btnReciprocal.Text = "1/X";
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSqrt.Location = new System.Drawing.Point(213, 84);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(32, 32);
            this.btnSqrt.TabIndex = 41;
            this.btnSqrt.Tag = "9";
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.Red;
            this.btnEquals.Location = new System.Drawing.Point(213, 164);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(32, 72);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.Tag = "9";
            this.btnEquals.Text = "=";
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.Red;
            this.btnSubtract.Location = new System.Drawing.Point(173, 164);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(32, 32);
            this.btnSubtract.TabIndex = 39;
            this.btnSubtract.Tag = "9";
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(173, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Tag = "9";
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(173, 124);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(32, 32);
            this.btnMultiply.TabIndex = 38;
            this.btnMultiply.Tag = "9";
            this.btnMultiply.Text = "*";
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(173, 84);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(32, 32);
            this.btnDivide.TabIndex = 37;
            this.btnDivide.Tag = "9";
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDecimal.Location = new System.Drawing.Point(133, 204);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(32, 32);
            this.btnDecimal.TabIndex = 36;
            this.btnDecimal.Tag = "0";
            this.btnDecimal.Text = ".";
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSign.Location = new System.Drawing.Point(93, 204);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(32, 32);
            this.btnSign.TabIndex = 35;
            this.btnSign.Tag = "0";
            this.btnSign.Text = "+/-";
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(133, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 32);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.ForeColor = System.Drawing.Color.Red;
            this.btnBackSpace.Location = new System.Drawing.Point(53, 44);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(72, 32);
            this.btnBackSpace.TabIndex = 23;
            this.btnBackSpace.Text = "Back";
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn7.Location = new System.Drawing.Point(53, 84);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(32, 32);
            this.btn7.TabIndex = 32;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn4.Location = new System.Drawing.Point(53, 124);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(32, 32);
            this.btn4.TabIndex = 29;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn5.Location = new System.Drawing.Point(93, 124);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(32, 32);
            this.btn5.TabIndex = 30;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn6.Location = new System.Drawing.Point(133, 124);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(32, 32);
            this.btn6.TabIndex = 31;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn1.Location = new System.Drawing.Point(53, 164);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(32, 32);
            this.btn1.TabIndex = 26;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn2.Location = new System.Drawing.Point(93, 164);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(32, 32);
            this.btn2.TabIndex = 27;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn3.Location = new System.Drawing.Point(133, 164);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(32, 32);
            this.btn3.TabIndex = 28;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn9.Location = new System.Drawing.Point(133, 84);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(32, 32);
            this.btn9.TabIndex = 34;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn8.Location = new System.Drawing.Point(93, 84);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(32, 32);
            this.btn8.TabIndex = 33;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn0.Location = new System.Drawing.Point(53, 204);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(32, 32);
            this.btn0.TabIndex = 25;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(233, 22);
            this.txtDisplay.TabIndex = 22;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(12, 124);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(35, 32);
            this.btnMR.TabIndex = 43;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(12, 165);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(35, 32);
            this.btnMS.TabIndex = 44;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMplus
            // 
            this.btnMplus.Location = new System.Drawing.Point(12, 205);
            this.btnMplus.Name = "btnMplus";
            this.btnMplus.Size = new System.Drawing.Size(35, 32);
            this.btnMplus.TabIndex = 45;
            this.btnMplus.Text = "M+";
            this.btnMplus.UseVisualStyleBackColor = true;
            this.btnMplus.Click += new System.EventHandler(this.btnMplus_Click);
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(12, 86);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(35, 32);
            this.btnMC.TabIndex = 46;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnM
            // 
            this.btnM.Enabled = false;
            this.btnM.Location = new System.Drawing.Point(12, 44);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(35, 32);
            this.btnM.TabIndex = 47;
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 252);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMplus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.txtDisplay);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMplus;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnM;
    }
}

