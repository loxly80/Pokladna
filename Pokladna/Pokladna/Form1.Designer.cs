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
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.dtpDatum = new System.Windows.Forms.DateTimePicker();
   this.label4 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.txtCisloDokladu = new System.Windows.Forms.TextBox();
   this.txtPopis = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.label7 = new System.Windows.Forms.Label();
   this.numCastka = new System.Windows.Forms.NumericUpDown();
   this.txtPoznamka = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.btnUlozit = new System.Windows.Forms.Button();
   this.btnUlozitJakoNovy = new System.Windows.Forms.Button();
   this.panel1.SuspendLayout();
   this.gBoxObdobi.SuspendLayout();
   this.groupBox1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.numCastka)).BeginInit();
   this.SuspendLayout();
   // 
   // panel1
   // 
   this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.panel1.Controls.Add(this.groupBox1);
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
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.btnUlozitJakoNovy);
   this.groupBox1.Controls.Add(this.btnUlozit);
   this.groupBox1.Controls.Add(this.txtPoznamka);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.numCastka);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtPopis);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.txtCisloDokladu);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.dtpDatum);
   this.groupBox1.Location = new System.Drawing.Point(5, 103);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(355, 223);
   this.groupBox1.TabIndex = 1;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Položka";
   // 
   // dtpDatum
   // 
   this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
   this.dtpDatum.Location = new System.Drawing.Point(87, 30);
   this.dtpDatum.Name = "dtpDatum";
   this.dtpDatum.Size = new System.Drawing.Size(111, 22);
   this.dtpDatum.TabIndex = 5;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(6, 33);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(49, 17);
   this.label4.TabIndex = 6;
   this.label4.Text = "Datum";
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(6, 61);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(75, 17);
   this.label5.TabIndex = 7;
   this.label5.Text = "Č. dokladu";
   // 
   // txtCisloDokladu
   // 
   this.txtCisloDokladu.Location = new System.Drawing.Point(87, 58);
   this.txtCisloDokladu.Name = "txtCisloDokladu";
   this.txtCisloDokladu.ReadOnly = true;
   this.txtCisloDokladu.Size = new System.Drawing.Size(200, 22);
   this.txtCisloDokladu.TabIndex = 8;
   this.txtCisloDokladu.TextChanged += new System.EventHandler(this.txtCisloDokladu_TextChanged);
   // 
   // txtPopis
   // 
   this.txtPopis.Location = new System.Drawing.Point(87, 86);
   this.txtPopis.Name = "txtPopis";
   this.txtPopis.Size = new System.Drawing.Size(254, 22);
   this.txtPopis.TabIndex = 10;
   this.txtPopis.TextChanged += new System.EventHandler(this.txtPopis_TextChanged);
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(6, 89);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(43, 17);
   this.label6.TabIndex = 9;
   this.label6.Text = "Popis";
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(6, 117);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(51, 17);
   this.label7.TabIndex = 11;
   this.label7.Text = "Částka";
   // 
   // numCastka
   // 
   this.numCastka.Location = new System.Drawing.Point(87, 114);
   this.numCastka.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
   this.numCastka.Minimum = new decimal(new int[] {
            200000,
            0,
            0,
            -2147483648});
   this.numCastka.Name = "numCastka";
   this.numCastka.Size = new System.Drawing.Size(164, 22);
   this.numCastka.TabIndex = 12;
   this.numCastka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   this.numCastka.ValueChanged += new System.EventHandler(this.numCastka_ValueChanged);
   // 
   // txtPoznamka
   // 
   this.txtPoznamka.Location = new System.Drawing.Point(87, 142);
   this.txtPoznamka.Name = "txtPoznamka";
   this.txtPoznamka.Size = new System.Drawing.Size(254, 22);
   this.txtPoznamka.TabIndex = 14;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(6, 145);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(74, 17);
   this.label3.TabIndex = 13;
   this.label3.Text = "Poznámka";
   // 
   // btnUlozit
   // 
   this.btnUlozit.Enabled = false;
   this.btnUlozit.Location = new System.Drawing.Point(236, 172);
   this.btnUlozit.Name = "btnUlozit";
   this.btnUlozit.Size = new System.Drawing.Size(105, 37);
   this.btnUlozit.TabIndex = 15;
   this.btnUlozit.Text = "Uložit";
   this.btnUlozit.UseVisualStyleBackColor = true;
   // 
   // btnUlozitJakoNovy
   // 
   this.btnUlozitJakoNovy.Enabled = false;
   this.btnUlozitJakoNovy.Location = new System.Drawing.Point(87, 172);
   this.btnUlozitJakoNovy.Name = "btnUlozitJakoNovy";
   this.btnUlozitJakoNovy.Size = new System.Drawing.Size(142, 37);
   this.btnUlozitJakoNovy.TabIndex = 16;
   this.btnUlozitJakoNovy.Text = "Uložit jako nový";
   this.btnUlozitJakoNovy.UseVisualStyleBackColor = true;
   this.btnUlozitJakoNovy.Click += new System.EventHandler(this.btnUlozitJakoNovy_Click);
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
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.numCastka)).EndInit();
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
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtPoznamka;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.NumericUpDown numCastka;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtPopis;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtCisloDokladu;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpDatum;
  private System.Windows.Forms.Button btnUlozitJakoNovy;
  private System.Windows.Forms.Button btnUlozit;
 }
}

