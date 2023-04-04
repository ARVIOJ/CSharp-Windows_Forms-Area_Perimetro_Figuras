using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejedos
{
    public partial class Form1 : Form
    {

        double v1 = 0;
        double v2 = 0;
        double area = 0;
        double perimetro = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFigura.Focus();
        }

        private void btnFigura_Click(object sender, EventArgs e)
        {
            txtA.Focus();
            btnCalcular.Enabled = true;
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtA.Text = "";
            txtB.Text = "";

            if (txtFigura.Text == "cuadrado") {

                    lblA.Text = "L";
                    txtB.Visible = false;
                    lblB.Visible = false;


            }
            else if (txtFigura.Text == "rectangulo") {

                    lblA.Text = "B";
                    lblB.Text = "H";
                    txtA.Visible = true;
                    txtB.Visible = true;
   
            }
            else if (txtFigura.Text == "rectángulo")
            {

                    lblA.Text = "B";
                    lblB.Text = "H";
                    txtA.Visible = true;
                    txtB.Visible = true;

            }
            else if (txtFigura.Text == "triangulo")
            {

                    lblA.Text = "B/L";
                    lblB.Text = "H";
                    txtA.Visible = true;
                    lblB.Visible = true;
                    txtB.Visible = true;
            }
            else if(txtFigura.Text == "triángulo")
            {

                    lblA.Text = "B/L";
                    lblB.Text = "H";
                    txtA.Visible = true;
                    lblB.Visible = true;
                    txtB.Visible = true;

            }
            else
            {
                MessageBox.Show("Error, selecciona una figura valida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFigura.Focus();
                lblArea.Text = "El área es: ";
                lblPerimetro.Text = "El perímetro es: ";
                lblA.Text = "1";
                lblB.Text = "2";
                txtA.Text = "";
                txtB.Text = "";
                txtFigura.Text = "";
                txtB.Visible = true;
                lblB.Visible = true;
                btnCalcular.Enabled = false;
                txtA.Enabled = false;
                txtB.Enabled = false;
            }

        }

        private void btbLimpiar_Click(object sender, EventArgs e)
        {

            DialogResult msj = MessageBox.Show("¿Deseas limpiar los campos?", "Limpiar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (msj == DialogResult.OK)
            {
                MessageBox.Show("Campos vacios!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                txtFigura.Focus();
                lblArea.Text = "El área es: ";
                lblPerimetro.Text = "El perímetro es: ";
                lblA.Text = "1";
                lblB.Text = "2";
                txtA.Text = "";
                txtB.Text = "";
                txtFigura.Text = "";
                txtB.Visible = true;
                lblB.Visible = true;
                btnCalcular.Enabled = false;
                txtA.Enabled = false;
                txtB.Enabled = false;
            }
            else {

            }

            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {

                v1 = Convert.ToDouble(txtA.Text);
            if (txtB.TextLength == 0)
                v2 = 0;
            else
                v2 = Convert.ToDouble(txtB.Text);

            if (txtFigura.Text == "cuadrado")
            {
                area = v1 * v1;
                perimetro = v1 + v1 + v1 + v1;
            }
            else if (txtFigura.Text == "rectangulo")
            {
                area = v1 * v2;
                perimetro = v1 + v2 + v1 + v2;
            }
            else if (txtFigura.Text == "rectángulo")
            {
                area = v1 * v2;
                perimetro = v1 + v2 + v1 + v2;
            }
            else if (txtFigura.Text == "triangulo")
            {
                area = (v1 * v2) / 2;
                perimetro = v1 + v1 + v1;
            }
            else if (txtFigura.Text == "triángulo")
            {
                area = (v1 * v2) / 2;
                perimetro = v1 + v1 + v1;
            }
            else {

                area = 0;
                perimetro = 0;
            }
                MessageBox.Show("Area y perimetro calculado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblArea.Text = "El área es: " + area;
            lblPerimetro.Text = "El perímetro es: " + perimetro;

            }
            catch {
                MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                txtA.Text = "";
                txtB.Text = "";


            }
            


        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtFigura_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
