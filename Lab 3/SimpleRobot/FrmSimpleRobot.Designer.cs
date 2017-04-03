namespace SimpleRobot
{
    partial class FrmSimpleRobot
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
            this.pnlBox = new System.Windows.Forms.Panel();
            this.lblArrow = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.btnGo10 = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBox
            // 
            this.pnlBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBox.Controls.Add(this.lblArrow);
            this.pnlBox.Location = new System.Drawing.Point(12, 34);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(200, 200);
            this.pnlBox.TabIndex = 0;
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblArrow.Location = new System.Drawing.Point(22, 55);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(20, 14);
            this.lblArrow.TabIndex = 0;
            this.lblArrow.Text = "ç";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(9, 9);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 13);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "X,Y coord";
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(95, 240);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(32, 23);
            this.btnNorth.TabIndex = 2;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(13, 269);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(46, 23);
            this.btnGo1.TabIndex = 7;
            this.btnGo1.Text = "Go 1";
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // btnGo10
            // 
            this.btnGo10.Location = new System.Drawing.Point(167, 269);
            this.btnGo10.Name = "btnGo10";
            this.btnGo10.Size = new System.Drawing.Size(46, 23);
            this.btnGo10.TabIndex = 8;
            this.btnGo10.Text = "Go 10";
            this.btnGo10.UseVisualStyleBackColor = true;
            this.btnGo10.Click += new System.EventHandler(this.btnGo10_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(95, 298);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(32, 23);
            this.btnSouth.TabIndex = 9;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(65, 269);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(32, 23);
            this.btnWest.TabIndex = 10;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(125, 269);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(32, 23);
            this.btnEast.TabIndex = 11;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(142, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmSimpleRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 349);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnGo10);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.pnlBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 388);
            this.MinimumSize = new System.Drawing.Size(240, 388);
            this.Name = "FrmSimpleRobot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot";
            this.Load += new System.EventHandler(this.FrmSimpleRobot_Load);
            this.pnlBox.ResumeLayout(false);
            this.pnlBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Button btnGo10;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnExit;
    }
}

