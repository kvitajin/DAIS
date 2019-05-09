using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.App_Data.proxy_shet;

namespace WebApplication1.App_Data.db_shets {
    public class AlbumTable:AlbumTableProxy {
        public static string SELECT = "SELECT album_id, nazev, obec_obec_id, vidible FROM SEM_ALBUM WHERE ALBUM_ID = :albumId";
        public static string SELECT_OBEC = "SELECT album_id, nazev, obec_obec_id, vidible FROM SEM_ALBUM WHERE OBEC_OBEC_ID=:obecId";
        public static string INSERT = "INSERT INTO SEM_ALBUM(ALBUM_ID, NAZEV, OBEC_OBEC_ID) VALUES (SEQ_ALBUM.nextval, :nazev, :obecId)";
        public static string UPDATE = "UPDATE SEM_ALBUM SET NAZEV= :nazev, VIDIBLE = :vis, OBEC_OBEC_ID=:obecId where ALBUM_ID = :albumId";
        public static string DELETE = "UPDATE SEM_ALBUM SET VIDIBLE = 0 where ALBUM_ID = :albumId";
        
        protected override void insert(Album album) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(INSERT);
            cmd.Parameters.Add("nazev", album.Nazev);  
            cmd.Parameters.Add("obecId", album.ObecId);  
            db.ExecuteNonQuery(cmd);
            db.Close();        
        }

        protected override void update(Album album) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(UPDATE);
//            Prepare(cmd, obec);
            cmd.Parameters.Add("nazev", album.Nazev);
            cmd.Parameters.Add("vis", album.Visible);
            cmd.Parameters.Add("obecId", album.ObecId);
            cmd.Parameters.Add("albumId", album.AlbumId);
            db.ExecuteNonQuery(cmd);   
            db.Close();        }

        protected override void delete(Album album) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(DELETE);
            cmd.Parameters.Add("albumId", album.AlbumId);
            db.ExecuteNonQuery(cmd);  
            db.Close();
        }

        protected override Album select(Album album) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT);
            cmd.Parameters.Add("albumId", album.AlbumId);
            List<Album> vystup = new List<Album>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Album tmp = new Album();
                tmp.AlbumId = readshit.GetInt32(0);
                tmp.Nazev = readshit.GetString(1);
                tmp.ObecId = readshit.GetInt32(2);
                tmp.Visible = readshit.GetInt32(3);
                vystup.Add(tmp);
            }
            Album wtf = null;
                
            if (vystup.Count == 1) {
                wtf = vystup[0];
            }
            readshit.Close();
            db.Close();
            return wtf;        
        }

        protected override List<Album> select(int obecId) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT_OBEC);
            cmd.Parameters.Add("obecId", obecId);
            List<Album> vystup = new List<Album>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Album tmp = new Album();
                tmp.AlbumId = readshit.GetInt32(0);
                tmp.Nazev = readshit.GetString(1);
                tmp.ObecId = readshit.GetInt32(2);
                tmp.Visible = readshit.GetInt32(3);
                vystup.Add(tmp);
            }
            readshit.Close();
            db.Close();
            return vystup;
        }
    }
}