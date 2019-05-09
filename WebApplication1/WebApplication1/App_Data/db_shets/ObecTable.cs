using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.App_Data.proxy_shet;

namespace WebApplication1.App_Data.db_shets {
    public class ObecTable:ObecTableProxy {
        public static string SELECT = "SELECT obec_id, nazev, vidible FROM SEM_OBEC WHERE OBEC_ID = :obecId";
        public static string SELECT_ALL = "SELECT obec_id, nazev, vidible FROM SEM_OBEC";
        public static string INSERT = "INSERT INTO SEM_OBEC(OBEC_ID, NAZEV) VALUES (SEQ_OBEC.nextval, :nazev)";
        public static string UPDATE = "UPDATE SEM_OBEC SET NAZEV= :nazev, VIDIBLE = :vis where OBEC_ID = :obecId";
        public static string DELETE = "UPDATE SEM_OBEC SET VIDIBLE = 0 where OBEC_ID = :obecId";


        public static void Prepare(OracleCommand cmd, Obec chmpff) {
            cmd.Parameters.Add("nazev", chmpff.Nazev);
            cmd.Parameters.Add("vis", chmpff.Visible);
        }
        
        protected override void insert(Obec tmp) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(INSERT);
//            Prepare(cmd, tmp);
            cmd.Parameters.Add("nazev", tmp.Nazev);            
            db.ExecuteNonQuery(cmd);
            db.Close();
        }


        protected override void update(Obec obec) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(UPDATE);
//            Prepare(cmd, obec);
            cmd.Parameters.Add("nazev", obec.Nazev);
            cmd.Parameters.Add("vis", obec.Visible);
            cmd.Parameters.Add("obecId", obec.ObecId);
            db.ExecuteNonQuery(cmd);   
            db.Close();
        }

        protected override void delete(Obec obec) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(DELETE);
//            Prepare(cmd, obec);
            cmd.Parameters.Add("obecId", obec.ObecId);
            db.ExecuteNonQuery(cmd);  
            db.Close();
        }
        
        protected override Obec select(Obec obec) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT);
            cmd.Parameters.Add("obecId", obec.ObecId);
            List<Obec> vystup = new List<Obec>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Obec tmp = new Obec();
                tmp.ObecId = readshit.GetInt32(0);
                tmp.Nazev = readshit.GetString(1);
                tmp.Visible = readshit.GetInt32(2);
                vystup.Add(tmp);
            }
            Obec wtf = null;
                
            if (vystup.Count == 1) {
                wtf = vystup[0];
            }
            readshit.Close();
            db.Close();
            return wtf;
        }

        protected override List<Obec> select() {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT_ALL);
            List<Obec> vystup = new List<Obec>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Obec tmp = new Obec();
                tmp.ObecId = readshit.GetInt32(0);
                tmp.Nazev = readshit.GetString(1);
                tmp.Visible = readshit.GetInt32(2);
                vystup.Add(tmp);
            }
            readshit.Close();
            db.Close();
            return vystup;
        }
    }
}