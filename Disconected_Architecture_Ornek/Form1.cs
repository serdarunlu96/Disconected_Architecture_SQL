using System.Data;
using System.Data.SqlClient;

namespace Disconected_Architecture_Ornek
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=.;database=Boost13Db;trusted_connection=true");
        DataTable dt;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
            //DataTable benimVeriTablom = new DataTable();
            //benimVeriTablom.Columns.Add("Plaka");
            //benimVeriTablom.Columns.Add("Sehir");
            //benimVeriTablom.Rows.Add(1, "Adana");
            //benimVeriTablom.Rows.Add(6, "Ankara");
            //benimVeriTablom.Rows.Add(7, "Antalya");
            //benimVeriTablom.Rows.Add(33, "Mersin");
            //dgvOgrenciler.DataSource = benimVeriTablom;
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM Ogrenciler", con);
            da.Fill(dt);
            var cb = new SqlCommandBuilder(da); // data adapter insert delete update saglýyor
            dgvOgrenciler.DataSource = dt;
        }

        private void btnDegisiklikleriKaydet_Click(object sender, EventArgs e)
        {
            da.Update(dt);
        }
    }
}