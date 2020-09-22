using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN8
{
    public partial class frmPromedios : Form
    {
        const int curso = 3;
        const int alum = 5;
        Alumno[,] mAlumnos = new Alumno[curso, alum];
        int ff = 0, cc = 0;
        double promGrl;
        int contAlm;
        public frmPromedios()
        {
            InitializeComponent();
            for (int f = 0; f < curso; f++)
                for (int c = 0; c < alum; c++)
                    mAlumnos[f, c] = null;
            contAlm = 0;
            promGrl = 0;
            
        }
        private void frmPromedios_Load(object sender, EventArgs e)
        {
            this.txtPromGral.Enabled = false;
            //btnPromedio.Enabled = false;
            btnCargar.Enabled = false;
            txtAlumno.MaxLength = 20;
            txtLegajo.MaxLength = 6;
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
            var vc = !string.IsNullOrEmpty(txtAlumno.Text) &&
                !string.IsNullOrEmpty(txtLegajo.Text) &&
                !string.IsNullOrEmpty(txtNota1.Text) &&
                !string.IsNullOrEmpty(txtNota2.Text) &&
                !string.IsNullOrEmpty(txtNota3.Text);
            btnCargar.Enabled = vc;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {


            mAlumnos[ff, cc] = new Alumno();
            mAlumnos[ff, cc].pAlumno = txtAlumno.Text;
            mAlumnos[ff, cc].pLegajo = int.Parse(txtLegajo.Text);
            mAlumnos[ff, cc].pNota1 = double.Parse(txtNota1.Text);
            mAlumnos[ff, cc].pNota2 = double.Parse(txtNota2.Text);
            mAlumnos[ff, cc].pNota3 = double.Parse(txtNota3.Text);

            lstAlumno.Items.Add(mAlumnos[ff, cc].pAlumno);
            lstLegajo.Items.Add(mAlumnos[ff, cc].pLegajo);
            lstNota1.Items.Add(mAlumnos[ff, cc].pNota1);
            lstNota2.Items.Add(mAlumnos[ff, cc].pNota2);
            lstNota3.Items.Add(mAlumnos[ff, cc].pNota3);
            lstProm.Items.Add(Math.Round(mAlumnos[ff, cc].calcularPromedio(), 2));
            promGrl += mAlumnos[ff, cc].calcularPromedio();
            txtPromGral.Text = Convert.ToString(Math.Round(promGrl / (contAlm + 1), 2));
            lstCurso.Items.Add("Nº: " + (ff+1));

            contAlm++;
            cc++;
            if (cc == alum)
            {
                MessageBox.Show("Se completó el Registro de Alumnos del Curso: Nº" + (ff + 1));
                cc = 0;
                ff++;
                lstAlumno.Items.Add("----------------");
                lstLegajo.Items.Add("----------------");
                lstNota1.Items.Add("----");
                lstNota2.Items.Add("----");
                lstNota3.Items.Add("----");
                lstProm.Items.Add("-------");
                lstCurso.Items.Add("--------");

            }
            if (ff == curso)
            {
                MessageBox.Show("Se completaron los Registros de los Cursos");
                txtAlumno.Enabled = false;
                txtLegajo.Enabled = false;
                txtNota1.Enabled = false;
                txtNota2.Enabled = false;
                txtNota3.Enabled = false;
            }

            txtAlumno.Clear();
            txtLegajo.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
        }


        private void txtAlumno_TextChanged(object sender, EventArgs e) { validarCampo(); }
        private void txtLegajo_TextChanged(object sender, EventArgs e) { validarCampo(); }
        private void txtNota1_TextChanged(object sender, EventArgs e) { validarCampo(); }
        private void txtNota2_TextChanged(object sender, EventArgs e) { validarCampo(); }
        private void txtNota3_TextChanged(object sender, EventArgs e) { validarCampo(); }

        private void txtAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
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

        private void frmPromedios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estás a punto de salir...", "Saliendo...",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if ((!char.IsDigit(e.KeyChar) || 
    Convert.ToInt64(txtLegajo.Text + e.KeyChar) >= 1000000 ||
    Convert.ToInt64(txtLegajo.Text + e.KeyChar) <= 0 ||
    txtLegajo.Text == "0"))
                e.Handled = true;

            if (e.KeyChar == 8)
            {
                e.Handled = true;
                txtLegajo.Clear();
            }
        }


    }
}
