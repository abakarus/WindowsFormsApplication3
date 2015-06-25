namespace WindowsFormsApplication3
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Emal_kvit = new WindowsFormsApplication3.DataSet_Emal_kvit();
            this.dataSet_Emal_kvit1 = new WindowsFormsApplication3.DataSet_Emal_kvit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emal_kvit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emal_kvit1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1371, 603);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Emal_kvit
            // 
            this.dataSet_Emal_kvit.DataSetName = "DataSet_Emal_kvit";
            this.dataSet_Emal_kvit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet_Emal_kvit1
            // 
            this.dataSet_Emal_kvit1.DataSetName = "DataSet_Emal_kvit";
            this.dataSet_Emal_kvit1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 627);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emal_kvit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emal_kvit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_Emal_kvit dataSet_Emal_kvit;
        private DataSet_Emal_kvit dataSet_Emal_kvit1;
    }
}