using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
 public class PokladniZaznam
 {
  public int IdPokladniZaznam { get; set; }
  public int Cislo { get; set; }
  public DateTime Datum { get; set; }
  public string Popis { get; set; }
  public double Castka { get; set; }
  public double Zustatek { get; set; }
  public string Poznamka { get; set; }

  public PokladniZaznam()
  {
  }

  public PokladniZaznam(int idPokladniZaznam, int cislo, DateTime datum, string popis, double castka, double zustatek, string poznamka)
  {
   IdPokladniZaznam = idPokladniZaznam;
   Cislo = cislo;
   Datum = datum;
   Popis = popis;
   Castka = castka;
   Zustatek = zustatek;
   Poznamka = poznamka;
  }

  public PokladniZaznam(DateTime datum, string popis, double castka, string poznamka)
  {
   IdPokladniZaznam = -1;
   Cislo = -1;
   Datum = datum;
   Popis = popis;
   Castka = castka;
   Zustatek = -1;
   Poznamka = poznamka;
  }

  public ListViewItem DoLvItem()
  {
   if (Castka > 0)
   {
    return new ListViewItem(new string[] { Datum.ToString("dd.MM.yyyy")
                                         , Cislo.ToString()
                                         , Popis
                                         , Castka.ToString()
                                         , ""
                                         , Zustatek.ToString()
                                         , Poznamka });
   }
   else
   {
    return new ListViewItem(new string[] { Datum.ToString("dd.MM.yyyy")
                                         , Cislo.ToString()
                                         , Popis
                                         , ""
                                         , Math.Abs(Castka).ToString()
                                         , Zustatek.ToString()
                                         , Poznamka });
   }
  }
 }
}
