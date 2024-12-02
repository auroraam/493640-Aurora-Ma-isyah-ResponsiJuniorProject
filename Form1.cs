using System.Data;
using Npgsql;

namespace responsi_aurora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5432; Username=postgres; Password=informatika; database=responsi_aurora";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            LoadData();
        }

        private void LoadData()
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = "select karyawan.id_karyawan, karyawan.nama, karyawan.id_dep, departemen.nama_dep " +
                    "FROM karyawan JOIN departemen ON karyawan.id_dep = departemen.id_dep;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }
        private int getIdDep()
        {
            string text = cbDep.Text;
            int idDep = 0;
            if (text == "HR") idDep = 1;
            if (text == "ENG") idDep = 2;
            if (text == "DEV") idDep = 3;
            if (text == "PM") idDep = 4;
            if (text == "FIN") idDep = 5;
            return idDep;
        }

        private string getNamaDep(int idDep)
        {
            string text = "";
            if (idDep == 1) text = "HR";
            if (idDep == 2) text = "ENG";
            if (idDep == 3) text = "DEV";
            if (idDep == 4) text = "PM";
            if (idDep == 5) text = "FIN";
            return text;
        }

        private int getIdJab()
        {
            string text = cbJabatan.Text;
            int idJab = 0;
            if (text == "Kadiv") idJab = 1;
            if (text == "Wakadiv") idJab = 2;
            if (text == "Staff") idJab = 3;
            return idJab;
        }

        private string getNamaJab(int idJab)
        {
            string text = "";
            if (idJab == 1) text = "Kadiv";
            if (idJab == 2) text = "Wakadiv";
            if (idJab == 3) text = "Staff";
            return text;
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbDep.Text) || cbDep.SelectedIndex == -1 || string.IsNullOrEmpty(tbNama.Text))
            {
                MessageBox.Show("Silakan lengkapi nama dan departemen terlebih dahulu.");
                return;
            }
            string nama = tbNama.Text;
            string[] words = nama.Split(' ');
            string inisial = "";
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    inisial += word[0].ToString().ToUpper();
                }
            }
            int id_dep = getIdDep();
            string id_karyawan = inisial + "_" + id_dep.ToString();
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "SELECT * FROM insertKaryawan(@_id_karyawan, @_nama, @_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@_id_karyawan", id_karyawan);
                cmd.Parameters.AddWithValue("@_nama", nama);
                cmd.Parameters.AddWithValue("@_id_dep", id_dep);
                int statusCode = (int)cmd.ExecuteScalar();
                if (statusCode == 201)
                {
                    MessageBox.Show("[201] Created");
                    LoadData();
                    return;
                }
                if (statusCode == 409)
                {
                    throw new Exception("[409] User already exist");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }
            finally { conn.Close(); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dataGridView1.Rows[e.RowIndex];
                tbNama.Text = r.Cells["nama"].Value.ToString();
                int idDep = (int)r.Cells["id_dep"].Value;
                cbDep.SelectedItem = getNamaDep(idDep);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tbNama.Text;
                if (r == null)
                {
                    MessageBox.Show("Silakan pilih karyawan terlebih dahulu.");
                    return;
                }
                int id_dep = getIdDep();

                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "SELECT * FROM editKaryawan(@_id_karyawan, @_nama, @_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@_id_karyawan", r.Cells["id_karyawan"].Value);
                cmd.Parameters.AddWithValue("@_nama", nama);
                cmd.Parameters.AddWithValue("@_id_dep", id_dep);
                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 200)
                {
                    MessageBox.Show("[200] Edit success", "Success");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception("[404] karyawan tidak ditemukan");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally { conn.Close(); }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Silakan pilih karyawan terlebih dahulu.");
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "SELECT * FROM deleteKaryawan(@_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@_id_karyawan", r.Cells["id_karyawan"].Value);
                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 204)
                {
                    MessageBox.Show("[204] Delete success", "Success");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception("[404] Karyawan tidak ditemukan");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            { conn.Close(); }
        }
    }
}