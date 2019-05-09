using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KorisnickiInterfejs
{
    public class Sem
    {

        private int pID;

        public int ID
        {
            get { return pID; }
            set { pID = value; }
        }
        public string ImeKandidata { get; set; }
        public string PrezimeKandidata { get; set; }
        public string MestoKandidata{ get; set; }
        public string AdresaKandidata { get; set; }
        public string OblastTakmicenja { get; set; }
        public string BrojGodina{ get; set; }
        public string NazivSkole { get; set; }
    }
}