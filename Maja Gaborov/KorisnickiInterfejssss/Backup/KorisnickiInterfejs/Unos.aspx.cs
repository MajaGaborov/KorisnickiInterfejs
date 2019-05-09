﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace KorisnickiInterfejs
{
    public partial class Unos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSnimi_Click(object sender, EventArgs e)
        {
            Sem obj = new Sem();
            obj.ID = int.Parse(txbID.Text);
            obj.BrojIndeksa = txbBrojIndeksa.Text;
            obj.IzvorTeme = ddlIzvorTeme.Text;
            obj.Ocena = int.Parse(txbOcena.Text);
            obj.NazivTeme = txbNazivTeme.Text;
            obj.TehnologijaIzrade = txbTehnologijaIzrade.Text;
            string PutanjaNazivKataloga = Server.MapPath("~/") + "XML/Katalog.XML";
            lblStatus.Text = SnimiPodatkeIzKataloga(PutanjaNazivKataloga, obj);
        }
        private string SnimiPodatkeIzKataloga(string PutanjaNazivKataloga, Sem obj)
        {
            string TekstUspehSnimanja = "";
            DataSet dsKatalog = new DataSet();
            dsKatalog.ReadXml(PutanjaNazivKataloga);
            int MaxBrojSTavkiKataloga = dsKatalog.Tables[0].Rows.Count;
            string NazviKonekcije = "";
            string OpisBaze = "";
            string ModalitetRada = "";
            string IzvorTeme = obj.IzvorTeme;
            for (int i = 0; i < MaxBrojSTavkiKataloga; i++)
            {
                NazviKonekcije = dsKatalog.Tables[0].Rows[i].ItemArray[1].ToString();
                OpisBaze = dsKatalog.Tables[0].Rows[i].ItemArray[0].ToString();
                ModalitetRada = dsKatalog.Tables[0].Rows[i].ItemArray[2].ToString();

                lblStatus.Text = NazviKonekcije + OpisBaze + ModalitetRada;
                if (OpisBaze.Equals(IzvorTeme) || !ModalitetRada.Equals("full"))
                {
                    try
                    {
                        lblStatus.Text = NazviKonekcije + OpisBaze + ModalitetRada;
                        bool uspehSnimanja = SnimiPodatke(NazviKonekcije, ModalitetRada, obj);
                        if (uspehSnimanja) TekstUspehSnimanja = TekstUspehSnimanja + " " + OpisBaze + ": Uspesno snimljeni...";
                    }
                    catch (Exception greska)
                    {
                        TekstUspehSnimanja = TekstUspehSnimanja + " " + OpisBaze + " :Neuspeh snimanja podataka!!! Greska:" + greska.Message;
                    }
                }
                else
                {
                }


            }
            return TekstUspehSnimanja;
        }
        private bool SnimiPodatke(string NazivStringaKonekcije, string tipupisa, Sem obj)
        {
            int brojslogova = 0;
            lblStatus.Text = "Dd";
            // SNIMANJE U BAZU PODATAKA
            // konektovanje na bazu
            SqlConnection Veza = new SqlConnection(ConfigurationManager.ConnectionStrings[NazivStringaKonekcije].ConnectionString);
            Veza.Open();



            // snimanje podataka
            string strSQL = "";
            switch (tipupisa)
            {
                case "full":
                    strSQL = "Insert into SemRad(ID, BrojIndeksa, IzvorTeme, Ocena, NazivTeme, TehnologijaIzrade) values ("+obj.ID +",'" + obj.BrojIndeksa + "','" + obj.IzvorTeme + "'," + obj.Ocena + ",'" + obj.NazivTeme + "','" + obj.TehnologijaIzrade + "')";
                    break;
                case "Osnovni":
                    strSQL = "Insert into SemRad(ID, BrojIndeksa, IzvorTeme, Ocena) values (" + obj.ID + ",'" + obj.BrojIndeksa + "','" + obj.IzvorTeme + "'," + obj.Ocena + ")";
                    break;
                case "Dodatni":
                    strSQL = "Insert into SemRad(ID, NazivTeme, TehnologijaIzrade) values (" + obj.ID + ",'"  + obj.NazivTeme + "','" + obj.TehnologijaIzrade + "')";
                    break;
          /*      case "licni":
                    strSQL = "Insert into PredskolskoDete(JMBG, Prezime, Ime, DatumRodjenja) values ('" + objPodaciDete.JMBG + "','" + objPodaciDete.Prezime + "','" + objPodaciDete.Ime + "','" + strDatumRodjenja + "')";
                    break;

                case "porodicni":
                    strSQL = "Insert into PredskolskoDete(JMBG, StanujeSaRoditeljima, RoditeljiRazvedeni, PrezimeStaratelja, ImeStaratelja, PrezimeOca, ImeOca, PrezimeMajke, ImeMajke, UkupanBrojClanovaDomacinstva, ImaBrata, ImaSestru) values ('" + objPodaciDete.JMBG + "'," + strStanujeSaRoditeljima + "," + strRoditeljiRazvedeni + ", '" + objPodaciDete.PrezimeStaratelja + "','" + objPodaciDete.ImeStaratelja + "','" + objPodaciDete.PrezimeOca + "','" + objPodaciDete.ImeOca + "','" + objPodaciDete.PrezimeMajke + "','" + objPodaciDete.ImeMajke + "'," + objPodaciDete.UkupnoClanovaDomacinstva + "," + strImaBrata + "," + strImaSestru + ")";
                    break;

                case "stanovanja":
                    strSQL = "Insert into PredskolskoDete(JMBG, Ulica_i_broj_prebivalista, NazivMesta_Prebivalista, PTTMesta_Prebivalista) values ('" + objPodaciDete.JMBG + "','" + objPodaciDete.UlicaBrojPrebivalista + "','" + objPodaciDete.Mesto + "'," + objPodaciDete.PTT + ")";
                    break;
                case "transport":
                    strSQL = "Insert into PredskolskoDete(JMBG,  UdaljenostDoPredskolskeUstanove, KoristiTransportDoPredskolskeUstanove) values ('" + objPodaciDete.JMBG + "'," + objPodaciDete.UdaljenostPredskolska + "," + strKoristiPrevoz + ")";
                    break;
                case "zdrastvena":
                    strSQL = "Insert into PredskolskoDete(JMBG, ProblemiSaVidom, ProblemiSaSluhom, ProblemiSaEkstremitetima, OstaliZdravstveniProblemi) values ('" + objPodaciDete.JMBG + "'," + strProblemiSaVidom + "," + strProblemiSaSluhom + "," + strProblemiSaEkstremitetima + ",'" + objPodaciDete.OstaliZdravstveniProblemi + "')";
                    break;*/
            };

            SqlCommand Komanda = new SqlCommand(strSQL, Veza);
            brojslogova = Komanda.ExecuteNonQuery();

            // diskonektovanje sa baze
            Veza.Close();
            Veza.Dispose();

            return brojslogova > 0;

        }
    }
}