using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.App_Data.proxy_shet;

namespace WebApplication1.App_Data.db_shets {
    public class RubrikaTable:RubrikaTableProxy {
        public static string SELECT = "SELECT rubrika_id, nazev FROM SEM_RUBRIKA WHERE RUBRIKA_ID = :rubrikaId";
        public static string SELECT_ALL = "SELECT rubrika_id, nazev FROM SEM_RUBRIKA";
        public static string INSERT = "INSERT INTO SEM_RUBRIKA(RUBRIKA_ID, NAZEV) VALUES (SEQ_RUBRIKA.nextval, :nazev)";
        public static string UPDATE = "UPDATE SEM_RUBRIKA SET NAZEV= :nazev where RUBRIKA_ID = :rubrikaId";
        public static string DELETE = "DELETE FROM SEM_RUBRIKA WHERE RUBRIKA_ID=:rubrikaId";


        protected override void insert(Rubrika rubrika) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(INSERT);
            cmd.Parameters.Add("nazev", rubrika.Nazev);            
            db.ExecuteNonQuery(cmd);
            db.Close();        
        }

        protected override void update(Rubrika rubrika) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(UPDATE);
            cmd.Parameters.Add("nazev", rubrika.Nazev);
            cmd.Parameters.Add("rubrikaId", rubrika.RubrikaId);
            db.ExecuteNonQuery(cmd);   
            db.Close();
        }

        protected override void delete(Rubrika rubrika) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(DELETE);
            cmd.Parameters.Add("obecId", rubrika.RubrikaId);
            db.ExecuteNonQuery(cmd);  
            db.Close();
        }

        protected override Rubrika select(Rubrika rubrika) {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT);
            cmd.Parameters.Add("obecId", rubrika.RubrikaId);
            List<Rubrika> vystup = new List<Rubrika>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Rubrika tmp = new Rubrika();
                tmp.RubrikaId = readshit.GetInt32(0);
                tmp.Nazev = readshit.GetString(1);
                vystup.Add(tmp);
            }
            Rubrika wtf = null;
                
            if (vystup.Count == 1) {
                wtf = vystup[0];
            }
            readshit.Close();
            db.Close();
            return wtf;
        }

        protected override List<Rubrika> select() {
            Database db = new Database();
            db.Connect();
            OracleCommand cmd = db.CreateCommand(SELECT_ALL);
            List<Rubrika> vystup = new List<Rubrika>();
            
            OracleDataReader readshit = db.Select(cmd);
            while (readshit.Read()) {
                Rubrika tmp = new Rubrika();
                tmp.RubrikaId = readshit.GetInt32(0);
                tmp.Nazev = readshit.GetString(1);
                vystup.Add(tmp);
            }
            readshit.Close();
            db.Close();
            return vystup;
        }
    }
}