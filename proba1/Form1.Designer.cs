namespace proba1
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
            this.Load = new System.Windows.Forms.Button();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.txtArat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(42, 97);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(112, 36);
            this.Load.TabIndex = 0;
            this.Load.Text = "btnLoad";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(54, 222);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(90, 26);
            this.txtOffset.TabIndex = 1;
            this.txtOffset.Text = "0";
            // 
            // txtArat
            // 
            this.txtArat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArat.Location = new System.Drawing.Point(198, 48);
            this.txtArat.Multiline = true;
            this.txtArat.Name = "txtArat";
            this.txtArat.Size = new System.Drawing.Size(464, 297);
            this.txtArat.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArat);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.Load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.TextBox txtArat;
    }
}

