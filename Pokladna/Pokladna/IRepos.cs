using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
 public interface IRepos
 {
  List<PokladniZaznam> NactiVse();
  List<PokladniZaznam> NactiMesic(int rok, int mesic);
  PokladniZaznam NactiZaznam(int idPokladniZaznam);
  PokladniZaznam VytvorZaznam(PokladniZaznam pokladniZaznam);
  void UpravZaznam(PokladniZaznam pokladniZaznam);
  void SmazZaznam(PokladniZaznam pokladniZaznam);
 }
}
