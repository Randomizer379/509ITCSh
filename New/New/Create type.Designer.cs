
namespace New
{
    partial class Form2
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
            this.PerButC = new System.Windows.Forms.Button();
            this.BusiButC = new System.Windows.Forms.Button();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PerButC
            // 
            this.PerButC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerButC.Location = new System.Drawing.Point(490, 263);
            this.PerButC.Name = "PerButC";
            this.PerButC.Size = new System.Drawing.Size(147, 55);
            this.PerButC.TabIndex = 6;
            this.PerButC.Text = "Personal";
            this.PerButC.UseVisualStyleBackColor = true;
            // 
            // BusiButC
            // 
            this.BusiButC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusiButC.Location = new System.Drawing.Point(127, 263);
            this.BusiButC.Name = "BusiButC";
            this.BusiButC.Size = new System.Drawing.Size(147, 55);
            this.BusiButC.TabIndex = 5;
            this.BusiButC.Text = "Business";
            this.BusiButC.UseVisualStyleBackColor = true;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLbl.Location = new System.Drawing.Point(154, 138);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(463, 25);
            this.TypeLbl.TabIndex = 4;
            this.TypeLbl.Text = "Which type of contact would you like to create?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PerButC);
            this.Controls.Add(this.BusiButC);
            this.Controls.Add(this.TypeLbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PerButC;
        private System.Windows.Forms.Button BusiButC;
        private System.Windows.Forms.Label TypeLbl;
    }
}