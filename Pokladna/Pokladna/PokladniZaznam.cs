using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
 }
}
