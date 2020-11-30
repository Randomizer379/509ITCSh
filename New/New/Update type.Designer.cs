
namespace New
{
    partial class Form3
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
            this.PerButU = new System.Windows.Forms.Button();
            this.BusiButU = new System.Windows.Forms.Button();
            this.TypeLblU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PerButU
            // 
            this.PerButU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerButU.Location = new System.Drawing.Point(491, 261);
            this.PerButU.Name = "PerButU";
            this.PerButU.Size = new System.Drawing.Size(147, 55);
            this.PerButU.TabIndex = 9;
            this.PerButU.Text = "Personal";
            this.PerButU.UseVisualStyleBackColor = true;
            // 
            // BusiButU
            // 
            this.BusiButU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusiButU.Location = new System.Drawing.Point(128, 261);
            this.BusiButU.Name = "BusiButU";
            this.BusiButU.Size = new System.Drawing.Size(147, 55);
            this.BusiButU.TabIndex = 8;
            this.BusiButU.Text = "Business";
            this.BusiButU.UseVisualStyleBackColor = true;
            // 
            // TypeLblU
            // 
            this.TypeLblU.AutoSize = true;
            this.TypeLblU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLblU.Location = new System.Drawing.Point(155, 136);
            this.TypeLblU.Name = "TypeLblU";
            this.TypeLblU.Size = new System.Drawing.Size(469, 25);
            this.TypeLblU.TabIndex = 7;
            this.TypeLblU.Text = "Which type of contact would you like to update?";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PerButU);
            this.Controls.Add(this.BusiButU);
            this.Controls.Add(this.TypeLblU);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PerButU;
        private System.Windows.Forms.Button BusiButU;
        private System.Windows.Forms.Label TypeLblU;
    }
}