using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
 public class SqlRepos : IRepos
 {
  private string connString = "Data Source=titanic.vassboskovice.cz;" +
                              "Initial Catalog = Hla_pokladna; " +
                              "User ID = sa; " +
                              "Password=Agent007; " +
                              "Connect Timeout = 30; " +
                              "Encrypt=False;" +
                              "TrustServerCertificate=False;" +
                              "ApplicationIntent=ReadWrite;" +
                              "MultiSubnetFailover=False";

  public void VytvorTestData(List<PokladniZaznam> vychoziZaznamy)
  {   
   using (SqlConnection sqlConnection = new SqlConnection(connString))
   {
    string dotaz = "DROP TABLE IF EXISTS [dbo].[PokladniZaznamy];" +
                   "CREATE TABLE [dbo].[PokladniZaznamy] " +
                   " ( " +
                   "   [IdPokladniZaznam] INT NOT NULL PRIMARY KEY IDENTITY(1,1)," +
                   "   [Cislo] INT NOT NULL," +
                   "   [Datum] DATETIME NOT NULL," +
                   "   [Popis] VARCHAR(250) NOT NULL," +
                   "   [Castka] FLOAT NOT NULL," +
                   "   [Zustatek] FLOAT NOT NULL," +
                   "   [Poznamka] VARCHAR(250) NOT NULL" +
                   ");";
                   
    foreach(var z in vychoziZaznamy)
    {
     dotaz += $"insert into PokladniZaznamy(Cislo    ,Datum    ,Popis      ,Castka    ,Zustatek    ,Poznamka    ) " +
                                   $"values({z.Cislo},'{z.Datum.ToString("yyyyMMdd")}','{z.Popis}',{z.Castka},{z.Zustatek},'{z.Poznamka}')";
    }

    using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
    {
     sqlConnection.Open();
     sqlCommand.ExecuteNonQuery();
     sqlConnection.Close();
    }    
   }
  }

  public List<PokladniZaznam> NactiMesic(int rok, int mesic, string sloupecTrideni, bool sestupne)
  {
   List<PokladniZaznam> result = new List<PokladniZaznam>();
   using (SqlConnection sqlConnection = new SqlConnection(connString))
   {
    string dotaz = $"select * from PokladniZaznamy where YEAR(Datum)={rok} and MONTH(Datum)={mesic} order by {sloupecTrideni} {(sestupne ? " desc" : "")}";
    using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
    {
     sqlConnection.Open();
     using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
     {
      while (dataReader.Read())
      {
       result.Add(new PokladniZaznam(Convert.ToInt32(dataReader["IdPokladniZaznam"])
                                   , Convert.ToInt32(dataReader["Cislo"])
                                   , Convert.ToDateTime(dataReader["Datum"])
                                   , dataReader["Popis"].ToString()
                                   , Convert.ToDouble(dataReader["Castka"])
                                   , Convert.ToDouble(dataReader["Zustatek"])
                                   , dataReader["Poznamka"].ToString()));
      }
     }
     sqlConnection.Close();
    }
   }
   return result;
  }

  public List<PokladniZaznam> NactiVse()
  {
   List<PokladniZaznam> result = new List<PokladniZaznam>();
   using (SqlConnection sqlConnection = new SqlConnection(connString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("select * from PokladniZaznamy", sqlConnection))
    {
     sqlConnection.Open();
     using(SqlDataReader dataReader = sqlCommand.ExecuteReader())
     {
      while (dataReader.Read())
      {
       result.Add(new PokladniZaznam(Convert.ToInt32(dataReader["IdPokladniZaznam"])
                                   , Convert.ToInt32(dataReader["Cislo"])
                                   , Convert.ToDateTime(dataReader["Datum"])
                                   , dataReader["Popis"].ToString()
                                   , Convert.ToDouble(dataReader["Castka"])
                                   , Convert.ToDouble(dataReader["Zustatek"])
                                   , dataReader["Poznamka"].ToString()));
      }
     }
     sqlConnection.Close();
    }    
   }
   return result;
  }

  public PokladniZaznam NactiZaznam(int idPokladniZaznam)
  {
   throw new NotImplementedException();
  }

  public void SmazZaznam(PokladniZaznam pokladniZaznam)
  {
   using (SqlConnection sqlConnection = new SqlConnection(connString))
   {
    string dotaz = $"delete from PokladniZaznamy where IdPokladniZaznam={pokladniZaznam.IdPokladniZaznam}";
                   
    using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
    {
     sqlConnection.Open();
     sqlCommand.ExecuteNonQuery();
     sqlConnection.Close();
    }
   }
  }

  public void UpravZaznam(PokladniZaznam pokladniZaznam)
  {
   using (SqlConnection sqlConnection = new SqlConnection(connString))
   {
    string dotaz = $"update PokladniZaznamy set " +
                     $" Datum='{pokladniZaznam.Datum.ToString("yyyyMMdd")}'," +
                     $" Popis='{pokladniZaznam.Popis}'," +
                     $" Castka={pokladniZaznam.Castka}," +
                     $" Poznamka='{pokladniZaznam.Poznamka}' " +
                   $" where IdPokladniZaznam={pokladniZaznam.IdPokladniZaznam}";
    using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
    {
     sqlConnection.Open();
     sqlCommand.ExecuteNonQuery();
     sqlConnection.Close();
    }
   }
  }

  public PokladniZaznam VytvorZaznam(PokladniZaznam pokladniZaznam)
  {
   PokladniZaznam result = pokladniZaznam;
   PokladniZaznam z = pokladniZaznam;
   using (SqlConnection sqlConnection = new SqlConnection(connString))
   {
    string dotaz = $"insert into PokladniZaznamy(Cislo    ,Datum    ,Popis      ,Castka    ,Zustatek    ,Poznamka    ) " +
                                        $"values({z.Cislo},'{z.Datum.ToString("yyyyMMdd")}','{z.Popis}',{z.Castka},{z.Zustatek},'{z.Poznamka}')";
    using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
    {
     sqlConnection.Open();
     sqlCommand.ExecuteNonQuery();
     sqlConnection.Close();
    }
   }
   return result;
  }
 }
}
