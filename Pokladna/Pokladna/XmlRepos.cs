﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
 public class XmlRepos : IRepos
 {
  public List<PokladniZaznam> NactiMesic(int rok, int mesic, string sloupecTrideni, bool sestupne)
  {
   throw new NotImplementedException();
  }

  public List<PokladniZaznam> NactiVse()
  {
   throw new NotImplementedException();
  }

  public PokladniZaznam NactiZaznam(int idPokladniZaznam)
  {
   throw new NotImplementedException();
  }

  public void SmazZaznam(PokladniZaznam pokladniZaznam)
  {
   throw new NotImplementedException();
  }

  public void UpravZaznam(PokladniZaznam pokladniZaznam)
  {
   throw new NotImplementedException();
  }

  public PokladniZaznam VytvorZaznam(PokladniZaznam pokladniZaznam)
  {
   throw new NotImplementedException();
  }
 }
}
