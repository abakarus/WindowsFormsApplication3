using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            
            dataSet_Emal_kvit.Kvit_DataTable.Rows.Clear();
            dataSet_Emal_kvit.ReadXml(Functions.DataRoot + @"\KVIT1.xml");

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataSet_Emal_kvit.Tables["Kvit_DataTable"]));
            

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();


            //this.reportViewer1.RefreshReport();
        }
    }
}
