using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration; // zbog ConfigurationManager 

namespace KorisnickiInterfejs
{
    public partial class DeteTabelarni : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
               
                // spajanje
                DataTable dtZrenjanin = UcitajSve("KonekcijaDIS2018Zrenjanin");
                DataTable dtSela = UcitajSve("KonekcijaDIS2018Sela");
                DataSet dsZrenjanin = DajDataSet(dtZrenjanin);
                DataSet dsSela = DajDataSet(dtSela);
                DataSet dsSelaLekovi = SpojPodatke(dsZrenjanin, dsSela);
                PrikaziPodatkeDS(gvSpisakDece, dsSelaLekovi);
            }



        }

        private DataSet DajDataSet(DataTable dt)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        private DataTable UcitajSve(string NazivKonekcije)
        {
            DataTable TabelaPodataka = new DataTable();

            // konekcija na bazu
            SqlConnection Veza = new SqlConnection(ConfigurationManager.ConnectionStrings[NazivKonekcije].ConnectionString);
            Veza.Open();

            // preuzimanje podataka
            String strSQL;
          //  strSQL = "Select * from PredskolskoDete";
            strSQL = "Select JMBG, Prezime, Ime, DatumRodjenja,  NazivMesta_Prebivalista from PredskolskoDete";
            SqlCommand Komanda = new SqlCommand(strSQL, Veza);
            SqlDataReader dr = Komanda.ExecuteReader();

            // transformacija datareader u data table
            // - ne mora, u web aplikaciji se moze povezati direktno
            // grid sa data readerom, ali postoji problem zbog zatvaranja konekcije
            // pa je bolje ipak da se podati postave u datatable, koji nije direktno povezan sa bazom

            if (dr.HasRows)
            {
                TabelaPodataka.Load(dr);
            }

            dr.Close();
            Veza.Close();
            Veza.Dispose();

            return TabelaPodataka;

        }

        // spajanje sadrzaja 2 data set-a
        private System.Data.DataSet SpojPodatke(System.Data.DataSet ds1, System.Data.DataSet ds2)
        {
            System.Data.DataSet dsZajedno;

            dsZajedno = ds1.Copy();
            dsZajedno.Merge(ds2);

            return dsZajedno;
        }



        private void PrikaziPodatke(GridView gv, DataTable TabelaPodataka)
        {
            gv.DataSource = TabelaPodataka;
            gv.DataBind();
        }

        private void PrikaziPodatkeDS(GridView gv, DataSet ds)
        {
            gv.DataSource = ds.Tables[0];
            gv.DataBind();
        }  


        protected void btnPrikaziSve_Click(object sender, EventArgs e)
        {

        }
    }
}