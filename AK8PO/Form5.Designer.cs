
namespace AK8PO
{
    partial class Form5
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.prvni = new System.Windows.Forms.Label();
            this.druhy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Zmena);
            // 
            // prvni
            // 
            this.prvni.AutoSize = true;
            this.prvni.Location = new System.Drawing.Point(336, 255);
            this.prvni.Name = "prvni";
            this.prvni.Size = new System.Drawing.Size(30, 13);
            this.prvni.TabIndex = 1;
            this.prvni.Text = "prvni";
            // 
            // druhy
            // 
            this.druhy.AutoSize = true;
            this.druhy.Location = new System.Drawing.Point(419, 255);
            this.druhy.Name = "druhy";
            this.druhy.Size = new System.Drawing.Size(33, 13);
            this.druhy.TabIndex = 2;
            this.druhy.Text = "druhy";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 523);
            this.Controls.Add(this.druhy);
            this.Controls.Add(this.prvni);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label prvni;
        private System.Windows.Forms.Label druhy;
    }
}