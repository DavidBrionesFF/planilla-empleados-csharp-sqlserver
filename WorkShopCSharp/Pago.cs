using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkShopCSharp
{
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workShopDataSet2.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.workShopDataSet2.empleado);
            // TODO: This line of code loads data into the 'workShopDataSet1.pago' table. You can move, or remove it, as needed.
            this.pagoTableAdapter.Fill(this.workShopDataSet1.pago);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ihss = 0;
            double fosovi = 0;
            double neto_pagar = 0;
            double total_deducciones = 0;
            String empelado = comboBox1.Text;
            double pago = double.Parse(textBox1.Text);

            if (pago > 7000)
            {
                ihss = pago * 0.035;
            }
            else
            {
                ihss = 7000 * 0.035;
            }

            fosovi = pago * 0.025;

            total_deducciones = fosovi + ihss;

            neto_pagar = pago - total_deducciones;

            String query = "insert into pago (pago,ihss,fosovi,neto_pagar,total_deducciones,empleado) values(@pago,@ihss,@fosovi,@neto,@total,@empleado)";

            SqlCommand cmd = new SqlCommand(query,Conexion.conectar());

            cmd.Parameters.AddWithValue("@pago", pago);
            cmd.Parameters.AddWithValue("@ihss", ihss);
            cmd.Parameters.AddWithValue("@fosovi", fosovi);
            cmd.Parameters.AddWithValue("@neto", neto_pagar);
            cmd.Parameters.AddWithValue("@total", total_deducciones);
            cmd.Parameters.AddWithValue("@empleado",empelado );
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pago realizado!!");
                updateDataGridView("select * from pago", "pago");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void updateDataGridView(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, Conexion.conectar());
            DataSet ds = new DataSet();

            ada.Fill(ds, tbl);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = tbl;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "select * from pago where empleado=" + comboBox1.Text;
            updateDataGridView(query, "pago");
        }
    }
}
