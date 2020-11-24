using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
 public partial class Form1 : Form
 {
  List<PokladniZaznam> pokladna;
  IRepos repositar;
  PokladniZaznam vybranyZaznam;

  public Form1()
  {
   InitializeComponent();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
   JsonRepos jsonRepos = new JsonRepos("data.json");
   //jsonRepos.VytvorTestData();
   SqlRepos sqlRepos = new SqlRepos();
   //sqlRepos.VytvorTestData(jsonRepos.NactiVse());
   repositar = sqlRepos;

   cBoxRok.SelectedIndex = cBoxRok.Items.IndexOf(DateTime.Now.Year.ToString());
   cBoxMesic.SelectedIndex = DateTime.Now.Month - 1;
  }

  private void cBoxRok_SelectedIndexChanged(object sender, EventArgs e)
  {
   NactiDataAktMesic();
  }

  private void NactiDataAktMesic()
  {
   if (cBoxRok.SelectedIndex >= 0 && cBoxMesic.SelectedIndex >= 0)
   {
    pokladna = repositar.NactiMesic(int.Parse(cBoxRok.SelectedItem.ToString()), cBoxMesic.SelectedIndex + 1);
    lvData.Items.Clear();
    foreach (var p in pokladna)
    {
     lvData.Items.Add(p.DoLvItem());
    }
   }
  }

  private void txtCisloDokladu_TextChanged(object sender, EventArgs e)
  {
   btnUlozit.Enabled = txtCisloDokladu.Text != "";
  }

  private void txtPopis_TextChanged(object sender, EventArgs e)
  {
   btnUlozitJakoNovy.Enabled = txtPopis.Text.Trim() != "" && numCastka.Value != 0;
  }

  private void numCastka_ValueChanged(object sender, EventArgs e)
  {
   btnUlozitJakoNovy.Enabled = txtPopis.Text.Trim() != "" && numCastka.Value != 0;
  }

  private void btnUlozitJakoNovy_Click(object sender, EventArgs e)
  {
   PokladniZaznam novyZaznam = new PokladniZaznam(dtpDatum.Value
                                                , txtPopis.Text
                                                , (double)numCastka.Value
                                                , txtPoznamka.Text);
   repositar.VytvorZaznam(novyZaznam);
   NactiDataAktMesic();
   ResetujFormular();
  }

  private void lvData_DoubleClick(object sender, EventArgs e)
  {
   VyberZaznam();
  }

  private void btnUlozit_Click(object sender, EventArgs e)
  {
   vybranyZaznam.Datum = dtpDatum.Value;
   vybranyZaznam.Popis = txtPopis.Text;
   vybranyZaznam.Castka = Convert.ToDouble(numCastka.Value);
   vybranyZaznam.Poznamka = txtPoznamka.Text;
   repositar.UpravZaznam(vybranyZaznam);
   NactiDataAktMesic();
   ResetujFormular();
  }

  private void ResetujFormular()
  {
   txtPopis.Text = "";
   numCastka.Value = 0;
   txtPoznamka.Text = "";
   txtCisloDokladu.Text = "";
   dtpDatum.Value = DateTime.Now;
  }

  private void VyberZaznam()
  {
   if (lvData.SelectedIndices.Count > 0)
   {
    int vybranyIndex = lvData.SelectedIndices[0];
    vybranyZaznam = pokladna[vybranyIndex];
    dtpDatum.Value = vybranyZaznam.Datum;
    txtCisloDokladu.Text = vybranyZaznam.Cislo.ToString();
    txtPopis.Text = vybranyZaznam.Popis;
    numCastka.Value = Convert.ToDecimal(vybranyZaznam.Castka);
    txtPoznamka.Text = vybranyZaznam.Poznamka;
   }
  }

  private void lvData_KeyUp(object sender, KeyEventArgs e)
  {
   switch (e.KeyCode)
   {
    case Keys.Enter:
     VyberZaznam();
     break;
    case Keys.Delete:
     if (lvData.SelectedIndices.Count > 0)
     {
      int vybranyIndex = lvData.SelectedIndices[0];
      vybranyZaznam = pokladna[vybranyIndex];
      if (MessageBox.Show("Opravdu chcete smazat vybranou položku", "Mazání položky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
       repositar.SmazZaznam(vybranyZaznam);
       NactiDataAktMesic();
       ResetujFormular();
      }      
     }
     break;
   }
  }

  private void cboxTridit_SelectedIndexChanged(object sender, EventArgs e)
  {
   SetriditPokladnu();
  }

  private void chboxSestupne_CheckedChanged(object sender, EventArgs e)
  {
   SetriditPokladnu();
  }

  private void SetriditPokladnu()
  {
   string[] sloupce = new string[] { "Datum","Popis","Castka","Castka" }; 
   string sloupec = sloupce[cboxTridit.SelectedIndex];
   string smer = chboxSestupne.Checked ? "desc" : "asc";
   

  }
 }
}
