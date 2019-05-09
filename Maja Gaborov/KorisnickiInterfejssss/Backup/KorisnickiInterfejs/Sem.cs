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
        public string BrojIndeksa { get; set; }
        public string IzvorTeme { get; set; }
        public int Ocena { get; set; }
        public string NazivTeme { get; set; }
        public string TehnologijaIzrade { get; set; }
    }
}