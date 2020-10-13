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
   this.lvData = new System.Windows.Forms.ListView();
   this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.SuspendLayout();
   // 
   // panel1
   // 
   this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
   this.panel1.Location = new System.Drawing.Point(998, 0);
   this.panel1.Name = "panel1";
   this.panel1.Size = new System.Drawing.Size(365, 859);
   this.panel1.TabIndex = 0;
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
 }
}

