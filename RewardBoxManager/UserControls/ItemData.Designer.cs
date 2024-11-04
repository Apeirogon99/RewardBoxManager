namespace UserControls.ItemData
{
    partial class ItemData
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IMG_Icon = new System.Windows.Forms.PictureBox();
            this.ItemLabelLine = new System.Windows.Forms.Label();
            this.T_Name = new System.Windows.Forms.Label();
            this.T_Width = new System.Windows.Forms.Label();
            this.T_Height = new System.Windows.Forms.Label();
            this.T_Weight = new System.Windows.Forms.Label();
            this.T_Amount = new System.Windows.Forms.Label();
            this.T_Code = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG_Icon
            // 
            this.IMG_Icon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IMG_Icon.Location = new System.Drawing.Point(4, 8);
            this.IMG_Icon.Name = "IMG_Icon";
            this.IMG_Icon.Size = new System.Drawing.Size(64, 64);
            this.IMG_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Icon.TabIndex = 0;
            this.IMG_Icon.TabStop = false;
            // 
            // ItemLabelLine
            // 
            this.ItemLabelLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemLabelLine.Location = new System.Drawing.Point(75, 30);
            this.ItemLabelLine.Name = "ItemLabelLine";
            this.ItemLabelLine.Size = new System.Drawing.Size(220, 2);
            this.ItemLabelLine.TabIndex = 1;
            // 
            // T_Name
            // 
            this.T_Name.AutoSize = true;
            this.T_Name.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_Name.Location = new System.Drawing.Point(80, 8);
            this.T_Name.Name = "T_Name";
            this.T_Name.Size = new System.Drawing.Size(61, 20);
            this.T_Name.TabIndex = 2;
            this.T_Name.Text = "Name";
            this.T_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // T_Width
            // 
            this.T_Width.AutoSize = true;
            this.T_Width.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_Width.Location = new System.Drawing.Point(80, 40);
            this.T_Width.Name = "T_Width";
            this.T_Width.Size = new System.Drawing.Size(59, 14);
            this.T_Width.TabIndex = 4;
            this.T_Width.Text = "너비 : X";
            this.T_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // T_Height
            // 
            this.T_Height.AutoSize = true;
            this.T_Height.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_Height.Location = new System.Drawing.Point(80, 60);
            this.T_Height.Name = "T_Height";
            this.T_Height.Size = new System.Drawing.Size(58, 14);
            this.T_Height.TabIndex = 5;
            this.T_Height.Text = "높이 : Y";
            this.T_Height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // T_Weight
            // 
            this.T_Weight.AutoSize = true;
            this.T_Weight.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_Weight.Location = new System.Drawing.Point(180, 40);
            this.T_Weight.Name = "T_Weight";
            this.T_Weight.Size = new System.Drawing.Size(64, 14);
            this.T_Weight.TabIndex = 6;
            this.T_Weight.Text = "무게 : W";
            this.T_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // T_Amount
            // 
            this.T_Amount.AutoSize = true;
            this.T_Amount.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_Amount.Location = new System.Drawing.Point(180, 60);
            this.T_Amount.Name = "T_Amount";
            this.T_Amount.Size = new System.Drawing.Size(59, 14);
            this.T_Amount.TabIndex = 7;
            this.T_Amount.Text = "수량 : A";
            this.T_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // T_Code
            // 
            this.T_Code.AutoSize = true;
            this.T_Code.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_Code.Location = new System.Drawing.Point(200, 14);
            this.T_Code.Name = "T_Code";
            this.T_Code.Size = new System.Drawing.Size(46, 14);
            this.T_Code.TabIndex = 8;
            this.T_Code.Text = "Code";
            this.T_Code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.T_Code);
            this.Controls.Add(this.T_Amount);
            this.Controls.Add(this.T_Weight);
            this.Controls.Add(this.T_Height);
            this.Controls.Add(this.T_Width);
            this.Controls.Add(this.T_Name);
            this.Controls.Add(this.ItemLabelLine);
            this.Controls.Add(this.IMG_Icon);
            this.Name = "ItemData";
            this.Size = new System.Drawing.Size(300, 80);
            this.Click += new System.EventHandler(this.OnClick_Item);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG_Icon;
        private System.Windows.Forms.Label ItemLabelLine;
        private System.Windows.Forms.Label T_Name;
        private System.Windows.Forms.Label T_Width;
        private System.Windows.Forms.Label T_Height;
        private System.Windows.Forms.Label T_Weight;
        private System.Windows.Forms.Label T_Amount;
        private System.Windows.Forms.Label T_Code;
    }
}
