namespace Lab4
{
    partial class frmNewHireApp
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
            this.cbxObjectType = new System.Windows.Forms.ComboBox();
            this.lblIdNum = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDrop = new System.Windows.Forms.Label();
            this.lblSwap = new System.Windows.Forms.Label();
            this.txtIdNum = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSwap = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.cbxDrop = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxObjectType
            // 
            this.cbxObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxObjectType.FormattingEnabled = true;
            this.cbxObjectType.Location = new System.Drawing.Point(120, 23);
            this.cbxObjectType.Name = "cbxObjectType";
            this.cbxObjectType.Size = new System.Drawing.Size(188, 21);
            this.cbxObjectType.TabIndex = 0;
            this.cbxObjectType.SelectedIndexChanged += new System.EventHandler(this.cbxObjectType_SelectedIndexChanged);
            // 
            // lblIdNum
            // 
            this.lblIdNum.AutoSize = true;
            this.lblIdNum.Location = new System.Drawing.Point(24, 89);
            this.lblIdNum.Name = "lblIdNum";
            this.lblIdNum.Size = new System.Drawing.Size(61, 13);
            this.lblIdNum.TabIndex = 1;
            this.lblIdNum.Text = "ID Number:";
            this.lblIdNum.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(24, 136);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(24, 186);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Visible = false;
            // 
            // lblDrop
            // 
            this.lblDrop.AutoSize = true;
            this.lblDrop.Location = new System.Drawing.Point(24, 232);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(60, 13);
            this.lblDrop.TabIndex = 4;
            this.lblDrop.Text = "*Changing*";
            this.lblDrop.Visible = false;
            // 
            // lblSwap
            // 
            this.lblSwap.AutoSize = true;
            this.lblSwap.Location = new System.Drawing.Point(24, 284);
            this.lblSwap.Name = "lblSwap";
            this.lblSwap.Size = new System.Drawing.Size(60, 13);
            this.lblSwap.TabIndex = 5;
            this.lblSwap.Text = "*Changing*";
            this.lblSwap.Visible = false;
            // 
            // txtIdNum
            // 
            this.txtIdNum.Location = new System.Drawing.Point(120, 86);
            this.txtIdNum.MaxLength = 5;
            this.txtIdNum.Name = "txtIdNum";
            this.txtIdNum.Size = new System.Drawing.Size(188, 20);
            this.txtIdNum.TabIndex = 7;
            this.txtIdNum.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 133);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(188, 20);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 183);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(188, 20);
            this.txtLastName.TabIndex = 9;
            this.txtLastName.Visible = false;
            // 
            // txtSwap
            // 
            this.txtSwap.Location = new System.Drawing.Point(120, 281);
            this.txtSwap.MaxLength = 6;
            this.txtSwap.Name = "txtSwap";
            this.txtSwap.Size = new System.Drawing.Size(188, 20);
            this.txtSwap.TabIndex = 11;
            this.txtSwap.Visible = false;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(68, 334);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(188, 23);
            this.btnResult.TabIndex = 13;
            this.btnResult.Text = "Get Results";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // cbxDrop
            // 
            this.cbxDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDrop.FormattingEnabled = true;
            this.cbxDrop.Location = new System.Drawing.Point(120, 229);
            this.cbxDrop.Name = "cbxDrop";
            this.cbxDrop.Size = new System.Drawing.Size(188, 21);
            this.cbxDrop.TabIndex = 14;
            this.cbxDrop.Visible = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(24, 31);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type";
            this.lblType.Visible = false;
            // 
            // frmNewHireApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 387);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbxDrop);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtSwap);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtIdNum);
            this.Controls.Add(this.lblSwap);
            this.Controls.Add(this.lblDrop);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblIdNum);
            this.Controls.Add(this.cbxObjectType);
            this.Name = "frmNewHireApp";
            this.Text = "New Hire Application";
            this.Load += new System.EventHandler(this.frmNewHireApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxObjectType;
        private System.Windows.Forms.Label lblIdNum;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDrop;
        private System.Windows.Forms.Label lblSwap;
        private System.Windows.Forms.TextBox txtIdNum;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSwap;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.ComboBox cbxDrop;
        private System.Windows.Forms.Label lblType;
    }
}

