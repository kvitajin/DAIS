using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.App_Data.proxy_shet;

namespace WebApplication1.App_Data.db_shets {
    public class KomentarTable :KomentarTableProxy{
        public static string SELECT = "SELECT komentar_id, obsah, foto_foto_id, dokument_dokument_id, uzivatel_uzivatel_id FROM SEM_KOMENTAR where KOMENTAR_ID = :komentarId";
        public static string SELECT_FOTO = "SELECT komentar_id, obsah, foto_foto_id, dokument_dokument_id, uzivatel_uzivatel_id FROM SEM_KOMENTAR where FOTO_FOTO_ID = :fotoId";
        public static string SELECT_DOKUMENT = "SELECT komentar_id, obsah, foto_foto_id, dokument_dokument_id, uzivatel_uzivatel_id FROM SEM_KOMENTAR where DOKUMENT_DOKUMENT_ID = :dokumentId";
        public static string INSERT =
            @"INSERT INTO SEM_KOMENTAR(komentar_id, obsah, foto_foto_id, dokument_dokument_id, uzivatel_uzivatel_id) 
            VALUES (SEQ_KOMENTAR.nextval, :obsah, :fotoId, :dokumentId, :uzivatelId)";
        public static string UPDATE =
            @"UPDATE SEM_KOMENTAR SET obsah= :obsah WHERE KOMENTAR_ID =:komentarId";
        public static string DELETE = "DELETE FROM SEM_KOMENTAR where KOMENTAR_ID = :komentarId";


        protected override void insert(Komentar komentar) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(INSERT);
            DateTime now = DateTime.Now;
            cmd.Parameters.Add("obsah", komentar.Obsah);            
            cmd.Parameters.Add("fotoId", komentar.FotoId==null?null:komentar.FotoId);            
            cmd.Parameters.Add("dokumentId", komentar.DokumentId==null?null:komentar.DokumentId);            
            cmd.Parameters.Add("uzivatelId", komentar.UzivatelId);            
            db.ExecuteNonQuery(cmd);
            db.Close();         }

        protected override void update(Komentar komentar) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(UPDATE);
            cmd.Parameters.Add("obsah", komentar.Obsah);            
            cmd.Parameters.Add("komentarId", komentar.KomentarId);            
            db.ExecuteNonQuery(cmd);
            db.Close();
        }

        protected override void delete(Komentar komentar) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(DELETE);
            cmd.Parameters.Add("komentarId", komentar.KomentarId);
            db.ExecuteNonQuery(cmd);
            db.Close(); 
        }

        protected override Komentar select(Komentar komentar) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT);
            cmd.Parameters.Add("komentarId", komentar.KomentarId);

            List<Komentar> vystup = new List<Komentar>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Komentar tmp = new Komentar();
                tmp.KomentarId = readshit.GetInt32(0);
                tmp.Obsah = readshit.GetString(1);
                tmp.FotoId = readshit.GetValue(2)== DBNull.Value ? 0 : readshit.GetInt32(2);
                tmp.DokumentId = readshit.GetValue(3)== DBNull.Value ? 0 : readshit.GetInt32(3);
                tmp.UzivatelId = readshit.GetInt32(4) ;
                vystup.Add(tmp);
            }
            Komentar wtf = null;
                
            if (vystup.Count == 1) {
                wtf = vystup[0];
            }
            readshit.Close();
            db.Close();
            return wtf;
        }

        protected override List<Komentar> select_foto(int fotoId) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT);
            cmd.Parameters.Add("fotoId", fotoId);

            List<Komentar> vystup = new List<Komentar>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Komentar tmp = new Komentar();
                tmp.KomentarId = readshit.GetInt32(0);
                tmp.Obsah = readshit.GetString(1);
                tmp.FotoId = readshit.GetValue(2)== DBNull.Value ? 0 : readshit.GetInt32(2);
                tmp.DokumentId = readshit.GetValue(3)== DBNull.Value ? 0 : readshit.GetInt32(3);
                tmp.UzivatelId = readshit.GetInt32(4) ;
                vystup.Add(tmp);
            }

            return vystup;
        }

        protected override List<Komentar> select_dokument(int dokumentId) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT);
            cmd.Parameters.Add("dokumentId", dokumentId);

            List<Komentar> vystup = new List<Komentar>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Komentar tmp = new Komentar();
                tmp.KomentarId = readshit.GetInt32(0);
                tmp.Obsah = readshit.GetString(1);
                tmp.FotoId = readshit.GetValue(2)== DBNull.Value ? 0 : readshit.GetInt32(2);
                tmp.DokumentId = readshit.GetValue(3)== DBNull.Value ? 0 : readshit.GetInt32(3);
                tmp.UzivatelId = readshit.GetInt32(4) ;
                vystup.Add(tmp);
            }

            return vystup;
        }
    }
}