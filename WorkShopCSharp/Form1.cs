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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pago().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workShopDataSet3.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter1.Fill(this.workShopDataSet3.empleado);
            // TODO: This line of code loads data into the 'workShopDataSet.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.workShopDataSet.empleado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "insert into empleado (nombre, apellido, direccion, cargo) values(@nombre,@apellido,@direccion,@cargo)";
            SqlCommand cmd = new SqlCommand(query, Conexion.conectar());
            cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
            cmd.Parameters.AddWithValue("@apellido", textBox2.Text);
            cmd.Parameters.AddWithValue("@direccion", textBox3.Text);
            cmd.Parameters.AddWithValue("@cargo", textBox4.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se guardo el empleado!!");
                updateDataGridView("select * from empleado", "empleado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "delete from empleado where id_empleado=@id";
            SqlCommand cmd = new SqlCommand(query, Conexion.conectar());
            cmd.Parameters.AddWithValue("@id", comboBox1.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se elimino el empleado!!");
                updateDataGridView("select * from empleado", "empleado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String query = "update empleado set nombre=@nombre, apellido=@apellido, cargo=@cargo, direccion=@direccion where id_empleado=@id";
            SqlCommand cmd = new SqlCommand(query, Conexion.conectar());

            cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
            cmd.Parameters.AddWithValue("@apellido", textBox2.Text);
            cmd.Parameters.AddWithValue("@direccion", textBox3.Text);
            cmd.Parameters.AddWithValue("@cargo", textBox4.Text);
            cmd.Parameters.AddWithValue("@id", comboBox1.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizo el empleado!!");
                updateDataGridView("select * from empleado", "empleado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateDataGridView(String query, String tbl )
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, Conexion.conectar());
            DataSet ds = new DataSet();

            ada.Fill(ds, tbl);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = tbl;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            String query = "select * from empleado where nombre like '%" + textBox5.Text +"%'";
            updateDataGridView(query, "empleado");
        }
    }
}
