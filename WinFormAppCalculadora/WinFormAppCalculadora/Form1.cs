using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppCalculadora
{
    public partial class Form1 : Form
    {   
    double numeroUno = 0;
        string operador = "";
        bool limpiarPantalla = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            tbxResultados.Text += "0";
        }

        //boton para mostrar el historial de operaciones
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            //Conexion a la base de datos
            string connectionString = @"Server=.\sqlexpress;Database=CalculadoraDB;Trusted_Connection=True;";
            string sql = "select TOP 10 Operacion, Resultado, Fecha from Historial ORDER BY Id DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    tbxHistorial.Clear();

                    while (reader.Read())
                    {
                        string fecha = Convert.ToDateTime(reader["Fecha"]).ToString("dd/MM/yyyy HH:mm:ss");
                        string operacion = reader["Operacion"].ToString();
                        string resultado = reader["Resultado"].ToString();

                        tbxHistorial.AppendText($"({fecha}) {operacion} = {resultado}\r\n\r\n");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar historial: " + ex.Message);
            }
        }

        

        private void button8_Click(object sender, EventArgs e)
        {

        }

        // Limpiar el textbox de resultados
        private void btnC_Click(object sender, EventArgs e)
        {
            tbxResultados.Clear();
            tbxOperacion.Clear();
            numeroUno = 0;
            operador = "";
        }
        // Limpiar el ultimo valor ingresado
        private void btnCE_Click(object sender, EventArgs e)
        {
            tbxResultados.Clear();
        }
        //Borrar un solo numero
        private void button15_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxResultados.Text))
            {
                tbxResultados.Text = tbxResultados.Text.Substring(0, tbxResultados.Text.Length - 1);
            }
        }
        //Boton de suma
        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxResultados.Text, out numeroUno))
            {
                operador = "+";
                tbxOperacion.Text = numeroUno + " " + operador;
                tbxResultados.Clear();
            }
        }
        //Boton de resta
        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxResultados.Text, out numeroUno))
            {
                operador = "-";
                tbxOperacion.Text = numeroUno + " " + operador;
                tbxResultados.Clear();
            }
        }
        //Boton de multiplicacion
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxResultados.Text, out numeroUno))
            {
                operador = "*";
                tbxOperacion.Text = numeroUno + " " + operador;
                tbxResultados.Clear();
            }
        }
        //Boton de division
        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxResultados.Text, out numeroUno))
            {
                operador = "/";
                tbxOperacion.Text = numeroUno + " " + operador;
                tbxResultados.Clear();
            }
        }
        //Boton para raiz cuadrada
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxResultados.Text, out double valor))
            {
                if (valor >= 0)
                {
                    double resultado = Math.Sqrt(valor);
                    tbxResultados.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Error: No se puede calcular la raíz cuadrada de un número negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Entrada no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Boton para potencia
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxResultados.Text, out numeroUno))
            {
                operador = "^";
                tbxOperacion.Text = numeroUno + " " + operador;
                tbxResultados.Clear();
            }
        }
        //Boton para sacar modulo
        private void btn_Click(object sender, EventArgs e)
        {   
            if (double.TryParse(tbxResultados.Text, out numeroUno))
            {
                operador = "%";
                tbxOperacion.Text = numeroUno + " " + operador;
                tbxResultados.Clear();
            }
        }
        //Boton para porcentaje
        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxResultados.Text, out double valor))
            {
                double resultado = valor / 100;
                tbxResultados.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Error: Entrada no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Boton para punto decimal
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!tbxResultados.Text.Contains("."))
            {
                if (string.IsNullOrEmpty(tbxResultados.Text))
                {
                    tbxResultados.Text = "0.";
                }
                else
                {
                    tbxResultados.Text += ".";
                }
            }
        }




        //textbox de Resultados
        private void tbxResultados_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            if (double.TryParse(tbxResultados.Text, out double conjuntoDosValor))
            {
                
                switch (operador)
                {
                    case "+":
                        resultado = numeroUno + conjuntoDosValor;
                        break;
                    case "-":
                        resultado = numeroUno - conjuntoDosValor;
                        break;
                    case "*":
                        resultado = numeroUno * conjuntoDosValor;
                        break;
                    case "/":
                        if (conjuntoDosValor != 0)
                        {
                            resultado = numeroUno / conjuntoDosValor;
                        }
                        else
                        {
                            MessageBox.Show("Error: División por cero no permitida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case "^":
                        resultado = Math.Pow(numeroUno, conjuntoDosValor);
                        break;
                    case
                        "%":
                        if (conjuntoDosValor != 0)
                        {
                            resultado = numeroUno % conjuntoDosValor;
                        }
                        else
                        {
                            MessageBox.Show("Error: Módulo por cero no permitido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Error: Operador no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                tbxResultados.Text = resultado.ToString();
                numeroUno = resultado;
            }
            else
            {
                MessageBox.Show("Error: Entrada no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Base de datos para guardar el historial
            try
            {
                string connectionString = @"Server=.\sqlexpress;Database=CalculadoraDB;Trusted_Connection=True;";
                string sqlInsert = "INSERT INTO Historial (Operacion, Resultado, Fecha) VALUES (@Operacion, @Resultado, @Fecha)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@Operacion", tbxOperacion.Text + " " + conjuntoDosValor);
                    cmd.Parameters.AddWithValue("@Resultado", resultado.ToString());
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cálculo: " + ex.Message);
            }

        }
        //textbox de Operacion para mostrar la operacion actual
        private void tbxOperacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxHistorial_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
