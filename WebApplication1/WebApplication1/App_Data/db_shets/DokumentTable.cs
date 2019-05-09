using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.App_Data.proxy_shet;

namespace WebApplication1.App_Data.db_shets {
    public class DokumentTable:DokumentTableProxy {
        public static string SELECT = "SELECT dokument_id, nadpis, obsah, datum, obrazek, rubrika_rubrika_id FROM SEM_DOKUMENT where DOKUMENT_ID = :dokumentId";
        public static string SELECT_RUBR = "SELECT dokument_id, nadpis, obsah, datum, obrazek, rubrika_rubrika_id FROM SEM_DOKUMENT where RUBRIKA_RUBRIKA_ID = :rubrikaId";
        public static string INSERT =
            @"INSERT INTO SEM_DOKUMENT(dokument_id, nadpis, obsah, datum, obrazek, rubrika_rubrika_id) 
            VALUES (SEQ_DOKUMENT.nextval, :nadpis, :obsah, :datum, :obrazek, :rubrikaId)";
        public static string UPDATE =
            @"UPDATE SEM_DOKUMENT SET NADPIS= :nadpis, obsah= :obsah, obrazek = :obrazek, RUBRIKA_RUBRIKA_ID=:rubrikaId 
            WHERE DOKUMENT_ID =:rubrikaId";
        public static string DELETE = "DELETE FROM SEM_DOKUMENT where DOKUMENT_ID = :dokumentId";
        protected override void insert(Dokument doc) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(INSERT);
            DateTime now = DateTime.Now;
            cmd.Parameters.Add("nadpis", doc.Nadpis);            
            cmd.Parameters.Add("obsah", doc.Obsah);            
            cmd.Parameters.Add("datum", now);            
            cmd.Parameters.Add("obrazek", doc.Obrazek);            
            cmd.Parameters.Add("rubrikaId", doc.RubrikaId);            
            db.ExecuteNonQuery(cmd);
            db.Close();        
        }

        protected override void update(Dokument doc) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(UPDATE);
            cmd.Parameters.Add("nadpis", doc.Nadpis);            
            cmd.Parameters.Add("obsah", doc.Obsah);            
            cmd.Parameters.Add("obrazek", doc.Obrazek);            
            cmd.Parameters.Add("rubrikaId", doc.RubrikaId);
            cmd.Parameters.Add("dokumentId", doc.DokumentId);
            db.ExecuteNonQuery(cmd);
            db.Close();
        }

        protected override void delete(Dokument doc) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(DELETE);
            cmd.Parameters.Add("dokumentId", doc.DokumentId);
            db.ExecuteNonQuery(cmd);
            db.Close();        
        }

        protected override Dokument select(Dokument doc) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT);
            cmd.Parameters.Add("dokumentId", doc.DokumentId);

            List<Dokument> vystup = new List<Dokument>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Dokument tmp = new Dokument();
                tmp.DokumentId = readshit.GetInt32(0);
                tmp.Nadpis = readshit.GetString(1);
                tmp.Obsah = readshit.GetString(2);
                tmp.Datum = readshit.GetDateTime(3);
                tmp.Obrazek = readshit.GetValue(4) == DBNull.Value ? null : readshit.GetString(4);
                tmp.RubrikaId = readshit.GetInt32(5);
                vystup.Add(tmp);
            }
            Dokument wtf = null;
                
            if (vystup.Count == 1) {
                wtf = vystup[0];
            }
            readshit.Close();
            db.Close();
            return wtf;
            
        }

        protected override List<Dokument> select_rubr(Dokument doc) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT_RUBR);
            cmd.Parameters.Add("rubrikaId", doc.RubrikaId);

            List<Dokument> vystup = new List<Dokument>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Dokument tmp = new Dokument();
                tmp.DokumentId = readshit.GetInt32(0);
                tmp.Nadpis = readshit.GetString(1);
                tmp.Obsah = readshit.GetString(2);
                tmp.Datum = readshit.GetDateTime(3);
                tmp.Obrazek = readshit.GetValue(4) == DBNull.Value ? null : readshit.GetString(4);
                tmp.RubrikaId = readshit.GetInt32(5);
                vystup.Add(tmp);
            }
            db.Close(); 
            readshit.Close();
            return vystup;
        }
    }
}