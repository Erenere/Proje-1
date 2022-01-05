using System.Collections.Generic;

namespace Proje1
{
    public interface IRehberIslem
    {
        public void Ekle();
        public void Sil();
        public void Guncelle();

        public void RehberListele();
        public void RehberArama();
        public void BaslangicEkrani();
    }
}