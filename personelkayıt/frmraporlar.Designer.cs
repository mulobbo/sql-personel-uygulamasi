﻿namespace personelkayıt
{
    partial class frmraporlar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonelveritabaniDataSet = new personelkayıt.PersonelveritabaniDataSet();
            this.Tbl_PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_PersonelTableAdapter = new personelkayıt.PersonelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelveritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tbl_PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "personelkayıt.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonelveritabaniDataSet
            // 
            this.PersonelveritabaniDataSet.DataSetName = "PersonelveritabaniDataSet";
            this.PersonelveritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_PersonelBindingSource
            // 
            this.Tbl_PersonelBindingSource.DataMember = "Tbl_Personel";
            this.Tbl_PersonelBindingSource.DataSource = this.PersonelveritabaniDataSet;
            // 
            // Tbl_PersonelTableAdapter
            // 
            this.Tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // frmraporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmraporlar";
            this.Text = "frmraporlar";
            this.Load += new System.EventHandler(this.frmraporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelveritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_PersonelBindingSource;
        private PersonelveritabaniDataSet PersonelveritabaniDataSet;
        private PersonelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter Tbl_PersonelTableAdapter;
    }
}