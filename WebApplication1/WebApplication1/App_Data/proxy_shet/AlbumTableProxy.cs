using System.Collections.Generic;

namespace WebApplication1.App_Data.proxy_shet {
    public abstract class AlbumTableProxy {
        private static AlbumTableProxy chmpff {
            get{ return new db_shets.AlbumTable();}
        }
        protected abstract void insert(Album album);
        protected abstract void update(Album album);
        protected abstract void delete(Album album);
        protected abstract Album select(Album album);
        protected abstract List<Album> select(int obecId);
        
        public static void Insert(Album album) {
            chmpff.insert(album);
        }

        public static void Update(Album album) {
            chmpff.update(album);
        }

        public static void Delete(Album album) {
            chmpff.delete(album);
        }

        public Album Select(Album album) {
            return chmpff.select(album);
        }

        public static List<Album> Select(int obecId) {
            return chmpff.select(obecId);
        }
    }
}