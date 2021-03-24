
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
            this.components = new System.ComponentModel.Container();
            this.databaseUTBDataSet32 = new AK8PO.DatabaseUTBDataSet32();
            this.databaseUTBDataSet32BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stitkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stitkyTableAdapter = new AK8PO.DatabaseUTBDataSet32TableAdapters.StitkyTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseUTBDataSet32
            // 
            this.databaseUTBDataSet32.DataSetName = "DatabaseUTBDataSet32";
            this.databaseUTBDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseUTBDataSet32BindingSource
            // 
            this.databaseUTBDataSet32BindingSource.DataSource = this.databaseUTBDataSet32;
            this.databaseUTBDataSet32BindingSource.Position = 0;
            // 
            // stitkyBindingSource
            // 
            this.stitkyBindingSource.DataMember = "Stitky";
            this.stitkyBindingSource.DataSource = this.databaseUTBDataSet32BindingSource;
            // 
            // stitkyTableAdapter
            // 
            this.stitkyTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.zobraz);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource databaseUTBDataSet32BindingSource;
        private DatabaseUTBDataSet32 databaseUTBDataSet32;
        private System.Windows.Forms.BindingSource stitkyBindingSource;
        private DatabaseUTBDataSet32TableAdapters.StitkyTableAdapter stitkyTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}