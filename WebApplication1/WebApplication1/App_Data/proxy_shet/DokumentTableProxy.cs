using System.Collections.Generic;
using System.Runtime.CompilerServices;
using OracleInternal.SqlAndPlsqlParser.LocalParsing;

namespace WebApplication1.App_Data.proxy_shet {
    public abstract class DokumentTableProxy {
        private static DokumentTableProxy chmpff{
            get{ return new db_shets.DokumentTable();}
        }
        protected abstract void insert(Dokument doc);
        protected abstract void update(Dokument doc);
        protected abstract void delete(Dokument doc);
        protected abstract Dokument select(Dokument doc);
        protected abstract List<Dokument> select_rubr(Dokument doc);

        public static void Insert(Dokument doc) {
            chmpff.insert(doc);
        }
        public static void Update(Dokument doc) {
            chmpff.update(doc);
        }
        public static void Delete(Dokument doc) {
            chmpff.delete(doc);
        }
        public static Dokument Select(Dokument doc) {
            return chmpff.select(doc);
        }
        public static List<Dokument> Select_rubr(Dokument doc) {
            return chmpff.select_rubr(doc);
        }
        
    }
}