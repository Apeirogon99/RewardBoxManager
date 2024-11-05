namespace RewardBoxManager
{
    partial class MainForm
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
            this.Apply = new System.Windows.Forms.Button();
            this.FLP_Items = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(772, 558);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 0;
            this.Apply.Text = "적용";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // FLP_Items
            // 
            this.FLP_Items.AutoScroll = true;
            this.FLP_Items.Location = new System.Drawing.Point(1500, 12);
            this.FLP_Items.Name = "FLP_Items";
            this.FLP_Items.Size = new System.Drawing.Size(320, 1017);
            this.FLP_Items.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.FLP_Items);
            this.Controls.Add(this.Apply);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.FlowLayoutPanel FLP_Items;
    }
}

