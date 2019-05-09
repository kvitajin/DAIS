using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.App_Data.proxy_shet;

namespace WebApplication1.App_Data.db_shets {
    public class VerejneOznameniTable:VerejneOznameniProxy {
        public static string SELECT_OBEC =
            @"SELECT DOKUMENT_ID, NADPIS, DATUM, OBSAH, RUBRIKA_RUBRIKA_ID FROM SEM_DOKUMENT d 
            join SEM_VEREJNE_OZNAMENI vo 
              on d.DOKUMENT_ID = vo.DOKUMENT_DOKUMENT_ID 
            join SEM_OBEC_CLANEK oc 
              on d.DOKUMENT_ID = oc.DOKUMENT_DOKUMENT_ID 
            join SEM_OBEC o 
              on oc.OBEC_OBEC_ID = o.OBEC_ID
            WHERE o.NAZEV=:nazev ANd DATUM_STAZENI> :now AND DATUM_VYVES<:now 
            ORDER BY DATUM_STAZENI desc;";
        public static string SELECT =
            @"SELECT DOKUMENT_ID, NADPIS, DATUM, OBSAH, RUBRIKA_RUBRIKA_ID FROM SEM_DOKUMENT d 
            join SEM_VEREJNE_OZNAMENI vo 
              on d.DOKUMENT_ID = vo.DOKUMENT_DOKUMENT_ID 
            join SEM_OBEC_CLANEK oc 
              on d.DOKUMENT_ID = oc.DOKUMENT_DOKUMENT_ID 
            join SEM_OBEC o 
              on oc.OBEC_OBEC_ID = o.OBEC_ID
            WHERE DATUM_STAZENI> :now AND DATUM_VYVES<:now 
            ORDER BY DATUM_STAZENI desc;";
        public static string INSERT = "INSERT INTO SEM_VEREJNE_OZNAMENI(datum_vyves, datum_stazeni, dokument_dokument_id) VALUES (:datumVyves, :datumStaz, :dokumentId)";
        public static string UPDATE = "UPDATE SEM_VEREJNE_OZNAMENI SET DATUM_VYVES=:datumVyves, DATUM_STAZENI=:datumStaz where DOKUMENT_DOKUMENT_ID = :dokumentId";
        public static string DELETE = "DELETE FROM SEM_VEREJNE_OZNAMENI WHERE DOKUMENT_DOKUMENT_ID= DOKUMENT_DOKUMENT_ID";

        protected override void insert(VerejneOznameni vo) {
          Database db = new Database();
          db.Connect();
          OracleCommand cmd = db.CreateCommand(INSERT);
          cmd.Parameters.Add("datumVyves", vo.DatumVyves);
          cmd.Parameters.Add("datumStaz", vo.DatumStazeni);            
          cmd.Parameters.Add("dokumentId", vo.DokumentId);            
          db.ExecuteNonQuery(cmd);
          db.Close();
        }        

        protected override void update(VerejneOznameni vo) {
          Database db = new Database();
          db.Connect();
          OracleCommand cmd = db.CreateCommand(UPDATE);
          cmd.Parameters.Add("datumVyves", vo.DatumVyves);
          cmd.Parameters.Add("datumStaz", vo.DatumStazeni);            
          cmd.Parameters.Add("dokumentId", vo.DokumentId);  ;
          db.ExecuteNonQuery(cmd);   
          db.Close();
        }

        protected override void delete(VerejneOznameni vo) {
          Database db = new Database();
          db.Connect();
          OracleCommand cmd = db.CreateCommand(DELETE);
          cmd.Parameters.Add("dokumentId", vo.DokumentId);
          db.ExecuteNonQuery(cmd);  
          db.Close();
        }

        protected override List<VerejneOznameni> select(VerejneOznameni vo) {
          Database db = new Database();
          db.Connect();
          OracleCommand cmd = db.CreateCommand(SELECT);
          List<VerejneOznameni> vystup = new List<VerejneOznameni>();
            
          OracleDataReader readshit = db.Select(cmd);
          while (readshit.Read()) {
            VerejneOznameni tmp = new VerejneOznameni();
            tmp.DatumVyves = readshit.GetDateTime(0);
            tmp.DatumStazeni = readshit.GetDateTime(1);
            tmp.DokumentId = readshit.GetInt32(2);
            vystup.Add(tmp);
          }
          readshit.Close();
          db.Close();
          return vystup;
        }

       

        protected override List<VerejneOznameni> select_obec(VerejneOznameni vo, string nazevObec) {
          Database db = new Database();
          db.Connect();
          OracleCommand cmd = db.CreateCommand(SELECT_OBEC);
          cmd.Parameters.Add("nazev", nazevObec);
          List<VerejneOznameni> vystup = new List<VerejneOznameni>();
            
          OracleDataReader readshit = db.Select(cmd);
          while (readshit.Read()) {
            VerejneOznameni tmp = new VerejneOznameni();
            tmp.DatumVyves = readshit.GetDateTime(0);
            tmp.DatumStazeni = readshit.GetDateTime(1);
            tmp.DokumentId = readshit.GetInt32(2);
            vystup.Add(tmp);
          }
          readshit.Close();
          db.Close();
          return vystup;
        }
    }
}