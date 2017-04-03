namespace TravelTimeCalculator
{
    partial class FrmVehicles
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSwap = new System.Windows.Forms.TextBox();
            this.cbxObjectType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxDrop = new System.Windows.Forms.ComboBox();
            this.lblDrop = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Distance";
            // 
            // txtSwap
            // 
            this.txtSwap.Location = new System.Drawing.Point(157, 161);
            this.txtSwap.Name = "txtSwap";
            this.txtSwap.Size = new System.Drawing.Size(100, 20);
            this.txtSwap.TabIndex = 4;
            // 
            // cbxObjectType
            // 
            this.cbxObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxObjectType.FormattingEnabled = true;
            this.cbxObjectType.Location = new System.Drawing.Point(157, 43);
            this.cbxObjectType.Name = "cbxObjectType";
            this.cbxObjectType.Size = new System.Drawing.Size(188, 21);
            this.cbxObjectType.TabIndex = 5;
            this.cbxObjectType.SelectedIndexChanged += new System.EventHandler(this.cbxObjectType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 46);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(69, 13);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Vehicle Type";
            this.lblType.Visible = false;
            // 
            // cbxDrop
            // 
            this.cbxDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDrop.FormattingEnabled = true;
            this.cbxDrop.Location = new System.Drawing.Point(157, 85);
            this.cbxDrop.Name = "cbxDrop";
            this.cbxDrop.Size = new System.Drawing.Size(188, 21);
            this.cbxDrop.TabIndex = 17;
            this.cbxDrop.Visible = false;
            // 
            // lblDrop
            // 
            this.lblDrop.AutoSize = true;
            this.lblDrop.Location = new System.Drawing.Point(23, 93);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(60, 13);
            this.lblDrop.TabIndex = 18;
            this.lblDrop.Text = "*Changing*";
            this.lblDrop.Visible = false;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(157, 236);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(188, 23);
            this.btnResult.TabIndex = 19;
            this.btnResult.Text = "Get Results";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // FrmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 319);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblDrop);
            this.Controls.Add(this.cbxDrop);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbxObjectType);
            this.Controls.Add(this.txtSwap);
            this.Controls.Add(this.label2);
            this.Name = "FrmVehicles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmVehicles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSwap;
        private System.Windows.Forms.ComboBox cbxObjectType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxDrop;
        private System.Windows.Forms.Label lblDrop;
        private System.Windows.Forms.Button btnResult;
    }
}

