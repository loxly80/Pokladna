namespace Pokladna
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
   this.panel1 = new System.Windows.Forms.Panel();
   this.gBoxObdobi = new System.Windows.Forms.GroupBox();
   this.cBoxMesic = new System.Windows.Forms.ComboBox();
   this.cBoxRok = new System.Windows.Forms.ComboBox();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.lvData = new System.Windows.Forms.ListView();
   this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.panel1.SuspendLayout();
   this.gBoxObdobi.SuspendLayout();
   this.SuspendLayout();
   // 
   // panel1
   // 
   this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.panel1.Controls.Add(this.gBoxObdobi);
   this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
   this.panel1.Location = new System.Drawing.Point(998, 0);
   this.panel1.Name = "panel1";
   this.panel1.Size = new System.Drawing.Size(365, 859);
   this.panel1.TabIndex = 0;
   // 
   // gBoxObdobi
   // 
   this.gBoxObdobi.Controls.Add(this.cBoxMesic);
   this.gBoxObdobi.Controls.Add(this.cBoxRok);
   this.gBoxObdobi.Controls.Add(this.label2);
   this.gBoxObdobi.Controls.Add(this.label1);
   this.gBoxObdobi.Location = new System.Drawing.Point(5, 0);
   this.gBoxObdobi.Name = "gBoxObdobi";
   this.gBoxObdobi.Size = new System.Drawing.Size(355, 97);
   this.gBoxObdobi.TabIndex = 0;
   this.gBoxObdobi.TabStop = false;
   this.gBoxObdobi.Text = "Účetní období";
   // 
   // cBoxMesic
   // 
   this.cBoxMesic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cBoxMesic.FormattingEnabled = true;
   this.cBoxMesic.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen",
            "Červenec",
            "Srpen",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
   this.cBoxMesic.Location = new System.Drawing.Point(81, 59);
   this.cBoxMesic.Name = "cBoxMesic";
   this.cBoxMesic.Size = new System.Drawing.Size(148, 24);
   this.cBoxMesic.TabIndex = 3;
   this.cBoxMesic.SelectedIndexChanged += new System.EventHandler(this.cBoxRok_SelectedIndexChanged);
   // 
   // cBoxRok
   // 
   this.cBoxRok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cBoxRok.FormattingEnabled = true;
   this.cBoxRok.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
   this.cBoxRok.Location = new System.Drawing.Point(81, 26);
   this.cBoxRok.Name = "cBoxRok";
   this.cBoxRok.Size = new System.Drawing.Size(148, 24);
   this.cBoxRok.TabIndex = 2;
   this.cBoxRok.SelectedIndexChanged += new System.EventHandler(this.cBoxRok_SelectedIndexChanged);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(22, 59);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(44, 17);
   this.label2.TabIndex = 1;
   this.label2.Text = "Měsíc";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(22, 29);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(33, 17);
   this.label1.TabIndex = 0;
   this.label1.Text = "Rok";
   // 
   // lvData
   // 
   this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
   this.lvData.Dock = System.Windows.Forms.DockStyle.Fill;
   this.lvData.FullRowSelect = true;
   this.lvData.GridLines = true;
   this.lvData.HideSelection = false;
   this.lvData.Location = new System.Drawing.Point(0, 0);
   this.lvData.Name = "lvData";
   this.lvData.Size = new System.Drawing.Size(998, 859);
   this.lvData.TabIndex = 1;
   this.lvData.UseCompatibleStateImageBehavior = false;
   this.lvData.View = System.Windows.Forms.View.Details;
   // 
   // columnHeader1
   // 
   this.columnHeader1.Text = "Datum";
   // 
   // columnHeader2
   // 
   this.columnHeader2.Text = "Č. dokladu";
   this.columnHeader2.Width = 97;
   // 
   // columnHeader3
   // 
   this.columnHeader3.Text = "Popis";
   this.columnHeader3.Width = 290;
   // 
   // columnHeader4
   // 
   this.columnHeader4.Text = "Příjmy";
   this.columnHeader4.Width = 95;
   // 
   // columnHeader5
   // 
   this.columnHeader5.Text = "Výdaje";
   this.columnHeader5.Width = 114;
   // 
   // columnHeader6
   // 
   this.columnHeader6.Text = "Zůstatek";
   this.columnHeader6.Width = 146;
   // 
   // columnHeader7
   // 
   this.columnHeader7.Text = "Poznámka";
   this.columnHeader7.Width = 192;
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1363, 859);
   this.Controls.Add(this.lvData);
   this.Controls.Add(this.panel1);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.panel1.ResumeLayout(false);
   this.gBoxObdobi.ResumeLayout(false);
   this.gBoxObdobi.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.ListView lvData;
  private System.Windows.Forms.ColumnHeader columnHeader1;
  private System.Windows.Forms.ColumnHeader columnHeader2;
  private System.Windows.Forms.ColumnHeader columnHeader3;
  private System.Windows.Forms.ColumnHeader columnHeader4;
  private System.Windows.Forms.ColumnHeader columnHeader5;
  private System.Windows.Forms.ColumnHeader columnHeader6;
  private System.Windows.Forms.ColumnHeader columnHeader7;
  private System.Windows.Forms.GroupBox gBoxObdobi;
  private System.Windows.Forms.ComboBox cBoxMesic;
  private System.Windows.Forms.ComboBox cBoxRok;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
 }
}

