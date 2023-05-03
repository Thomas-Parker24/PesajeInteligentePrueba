using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool isNew = true;
        public Form1(Contexto context)
        {
            InitializeComponent();
            TablaDatos.DataSource = context.Empresas.ToList();
            TituloEditor.Text = isNew ? "Creando nueva Empresa" : "Editando Empresa";
        }

        private void AgregarButton(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            isNew = true;
        }

        private void CancelarButton(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cancelar la operación?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                tabControl1.SelectedIndex = 0;
                LimpiarCampos();
            }
        }

        private void GuardarButton(object sender, EventArgs e)
        {
            int codigoInt = 0;
            if (string.IsNullOrEmpty(nombreTxt.Text) || string.IsNullOrEmpty(codigoTxt.Text) || string.IsNullOrEmpty(direccionTxt.Text)
                || string.IsNullOrEmpty(telefonoTxt.Text) || string.IsNullOrEmpty(ciudadTxt.Text) || string.IsNullOrEmpty(departamentoTxt.Text) ||
                string.IsNullOrEmpty(paisTxt.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos para añadir una nueva empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Int32.TryParse(codigoTxt.Text.Trim(), out codigoInt))
            {
                MessageBox.Show("El código no debe contener caracteres especiales o letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Empresa nuevaEmpresa = new Empresa();

                nuevaEmpresa.Nombre = nombreTxt.Text.Trim();
                nuevaEmpresa.Codigo = codigoInt;
                nuevaEmpresa.Direccion = direccionTxt.Text.Trim();
                nuevaEmpresa.Telefono = telefonoTxt.Text.Trim();
                nuevaEmpresa.Ciudad = ciudadTxt.Text.Trim();
                nuevaEmpresa.Departamento = departamentoTxt.Text.Trim();
                nuevaEmpresa.Pais = paisTxt.Text.Trim();
                nuevaEmpresa.Creacion = DateTime.Now;
                nuevaEmpresa.Modificacion = DateTime.Now;

                Contexto contextoNew = new Contexto();
                contextoNew.Empresas.Add(nuevaEmpresa);
                contextoNew.SaveChanges();

                LimpiarCampos();
                MessageBox.Show("Elemento añadido a la base de datos correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.SelectedIndex = 0;
                TablaDatos.DataSource = contextoNew.Empresas.ToList();
            }
        }

        public void LimpiarCampos()
        {
            nombreTxt.Text = "";
            codigoTxt.Text = "";
            direccionTxt.Text = "";
            telefonoTxt.Text = "";
            ciudadTxt.Text = "";
            departamentoTxt.Text = "";
            paisTxt.Text = "";
        }
    }
}
