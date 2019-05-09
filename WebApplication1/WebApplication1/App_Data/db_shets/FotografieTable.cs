using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.App_Data.proxy_shet;

namespace WebApplication1.App_Data.db_shets {
    public class FotografieTable:FotografieTableProxy {
        public static string SELECT = "SELECT foto_id, nazev, datum, popis, album_album_id, visible FROM SEM_FOTO where FOTO_ID = :fotoId";
        public static string SELECT_ALB = "SELECT foto_id, nazev, datum, popis, album_album_id, visible FROM SEM_FOTO where ALBUM_ALBUM_ID = :albumId";
        public static string INSERT =
            @"INSERT INTO SEM_FOTO(foto_id, nazev, datum, popis, album_album_id)
            VALUES (SEQ_FOTO.nextval, :mazev, :datum, :popis, :albumId)";
        public static string UPDATE =
            @"UPDATE SEM_FOTO SET NAZEV=:nazev, POPIS=:popis, ALBUM_ALBUM_ID=:albumId, VISIBLE =:visible
            WHERE FOTO_ID =:fotoId";
        public static string DELETE = "UPDATE SEM_FOTO SET VISIBLE= 0 WHERE FOTO_ID=:fotoId";

        protected override void insert(Fotografie fotografie) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(INSERT);
            DateTime now = DateTime.Today;
            cmd.Parameters.Add("nazev", fotografie.Nazev);            
            cmd.Parameters.Add("datum", now);            
            cmd.Parameters.Add("popis", fotografie.Popis);            
            cmd.Parameters.Add("albumId", fotografie.AlbumId);            
            db.ExecuteNonQuery(cmd);
            db.Close();         
        }

        protected override void update(Fotografie fotografie) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(UPDATE);
            cmd.Parameters.Add("nazev", fotografie.Nazev);            
            cmd.Parameters.Add("popis", fotografie.Popis);            
            cmd.Parameters.Add("albumId", fotografie.AlbumId);
            cmd.Parameters.Add("visible", fotografie.Visible);
            db.ExecuteNonQuery(cmd);
            db.Close();
        }

        protected override void delete(Fotografie fotografie) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(DELETE);
            cmd.Parameters.Add("fotoId", fotografie.FotoId);
            db.ExecuteNonQuery(cmd);
            db.Close();          }

        protected override Fotografie select(Fotografie fotografie) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT);
            cmd.Parameters.Add("fotoId", fotografie.FotoId);

            List<Fotografie> vystup = new List<Fotografie>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Fotografie tmp = new Fotografie();
                tmp.FotoId = readshit.GetInt32(0);
                tmp.Nazev = readshit.GetString(1);
                tmp.Datum = readshit.GetDateTime(2);
                tmp.Popis = readshit.GetValue(3)== DBNull.Value ? null : readshit.GetString(3);
                tmp.AlbumId = readshit.GetInt32(4);
                tmp.Visible = readshit.GetInt32(5);
                vystup.Add(tmp);
            }
            Fotografie wtf = null;
                
            if (vystup.Count == 1) {
                wtf = vystup[0];
            }
            readshit.Close();
            db.Close();
            return wtf;
        }

        protected override List<Fotografie> select_alb(int albumId) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT_ALB);
            cmd.Parameters.Add("albumId", albumId);

            List<Fotografie> vystup = new List<Fotografie>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Fotografie tmp = new Fotografie();
                tmp.FotoId = readshit.GetInt32(0);
                tmp.Nazev = readshit.GetString(1);
                tmp.Datum = readshit.GetDateTime(2);
                tmp.Popis = readshit.GetValue(3)== DBNull.Value ? null : readshit.GetString(3);
                tmp.AlbumId = readshit.GetInt32(4);
                tmp.Visible = readshit.GetInt32(5);
                vystup.Add(tmp);
            }
            db.Close(); 
            readshit.Close();
            return vystup;
        }
    }
}