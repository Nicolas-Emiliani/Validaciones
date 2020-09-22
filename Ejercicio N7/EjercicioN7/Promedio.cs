using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN7
{
    public partial class Promedio : Form
    {
        int c = 0;
        const int lim = 5;
        Alumnos[] alu = new Alumnos[lim];
        public Promedio()
        {
            for (int i = 0; i < lim; i++)
            {
                alu[i] = null;
            }
            InitializeComponent();
        }
        private void Promedio_Load(object sender, EventArgs e)
        {
            this.txtPromGral.Enabled = false;
            btnPromedio.Enabled = false;
            txtAlumno.MaxLength = 20;
            txtLegajo.MaxLength = 10;
            txtNota1.MaxLength = 2;
            txtNota2.MaxLength = 2;
            txtNota3.MaxLength = 2;

            lstAlumno.Items.Clear();
            lstLegajo.Items.Clear();
            lstNota1.Items.Clear();
            lstNota2.Items.Clear();
            lstNota3.Items.Clear();
            lstProm.Items.Clear();
        }

        private void validarCampo()
        {
            var vc =!string.IsNullOrEmpty(txtAlumno.Text) &&
                !string.IsNullOrEmpty(txtLegajo.Text) &&
                !string.IsNullOrEmpty(txtNota1.Text) &&
                !string.IsNullOrEmpty(txtNota2.Text) &&
                !string.IsNullOrEmpty(txtNota3.Text);
            btnPromedio.Enabled = vc;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            alu[c] = new Alumnos();
            alu[c].pAlumno = txtAlumno.Text;
            alu[c].pLegajo = double.Parse(txtLegajo.Text);
            alu[c].pNota1 = double.Parse(txtNota1.Text);
            alu[c].pNota2 = double.Parse(txtNota2.Text);
            alu[c].pNota3 = double.Parse(txtNota3.Text);

            lstAlumno.Items.Add(alu[c].pAlumno);
            lstLegajo.Items.Add(alu[c].pLegajo);
            lstNota1.Items.Add(alu[c].pNota1);
            lstNota2.Items.Add(alu[c].pNota2);
            lstNota3.Items.Add(alu[c].pNota3);

            c++;

            if (c == lim)
            {
                MessageBox.Show("Se llegó al límite de carga");
                this.txtAlumno.Enabled = false;
                this.txtLegajo.Enabled = false;
                this.txtNota1.Enabled = false;
                this.txtNota2.Enabled = false;
                this.txtNota3.Enabled = false;
            }

            double acumulador = 0;
            double promedio = 0;

            lstProm.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                lstProm.Items.Add(Math.Round(alu[i].calcularPromedio(), 2));
                acumulador += (alu[i].calcularPromedio());
                promedio = acumulador / c;
            }
            txtPromGral.Text = promedio.ToString("0.00");      

            txtAlumno.Clear();
            txtLegajo.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();


        }
        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
        private void txtNota2_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
        private void txtNota3_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
        private void txtAlumno_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;

            if (e.KeyChar == 8)
            {
                e.Handled = true;
                txtNota1.Clear();
            }

            if ((!char.IsDigit(e.KeyChar) ||
                Convert.ToInt32(txtNota1.Text + e.KeyChar) >= 11 ||
                Convert.ToInt32(txtNota1.Text + e.KeyChar) <= 0 ||
                txtNota1.Text == "0"))
                e.Handled = true;
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;

            if (e.KeyChar == 8)
            {
                e.Handled = true;
                txtNota2.Clear();
            }
            if ((!char.IsDigit(e.KeyChar) ||
                Convert.ToInt32(txtNota2.Text + e.KeyChar) >= 11 ||
                Convert.ToInt32(txtNota2.Text + e.KeyChar) <= 0 ||
                txtNota2.Text == "0"))
                e.Handled = true;
        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;

            if (e.KeyChar == 8)
            {
                e.Handled = true;
                txtNota3.Clear();
            }

            if ((!char.IsDigit(e.KeyChar) ||
                Convert.ToInt32(txtNota3.Text + e.KeyChar) >= 11 ||
                Convert.ToInt32(txtNota3.Text + e.KeyChar) <= 0 ||
                txtNota3.Text == "0"))
                e.Handled = true;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumno.Clear();
            txtLegajo.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if ((!char.IsDigit(e.KeyChar) || 
    Convert.ToInt64(txtLegajo.Text + e.KeyChar) >= 10000000000 ||
    Convert.ToInt64(txtLegajo.Text + e.KeyChar) <= 0 ||
    txtLegajo.Text == "0"))
                e.Handled = true;

            if (e.KeyChar == 8)
            {
                e.Handled = true;
                txtLegajo.Clear();
            }
        }
    private void txtAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 ||char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Promedio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estás a punto de salir...", "Saliendo...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
