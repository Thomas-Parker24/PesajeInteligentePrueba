using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCompanyEditor : Form
    {
        bool isNew = true;

        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }


        public FormCompanyEditor()
        {
            InitializeComponent();
        }

        public FormCompanyEditor(int id, string nombre, bool isNew, Empresa aux)
        {
            this.isNew = isNew;
            this.IdEmpresa = id;
            this.Nombre = nombre;

            InitializeComponent();

            nombreTxt.Text = aux.Nombre;
            codigoTxt.Text = aux.Codigo.ToString();
            direccionTxt.Text = aux.Direccion;
            telefonoTxt.Text = aux.Telefono;
            ciudadTxt.Text = aux.Ciudad;
            departamentoTxt.Text = aux.Departamento;
            paisTxt.Text = aux.Pais;

            TituloEditor.Text = isNew ? "Creando nueva Empresa" : $"Editando Empresa{nombre}";
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

        private void CancelarButton(object sender, EventArgs e)
        {
            Contexto context = new Contexto();
            var result = MessageBox.Show("¿Desea cancelar la operación?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LimpiarCampos();
                TituloEditor.Text = "Creando nueva Empresa";
                this.Close();
            }
        }

        private void GuardarButton(object sender, EventArgs e)
        {
            bool success = false;
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
                Contexto contextoNew = new Contexto();

                nuevaEmpresa.Nombre = nombreTxt.Text.Trim();
                nuevaEmpresa.Codigo = codigoInt;
                nuevaEmpresa.Direccion = direccionTxt.Text.Trim();
                nuevaEmpresa.Telefono = telefonoTxt.Text.Trim();
                nuevaEmpresa.Ciudad = ciudadTxt.Text.Trim();
                nuevaEmpresa.Departamento = departamentoTxt.Text.Trim();
                nuevaEmpresa.Pais = paisTxt.Text.Trim();
                nuevaEmpresa.Modificacion = DateTime.Now;

                if (isNew)
                {
                    try
                    {
                        nuevaEmpresa.Creacion = DateTime.Now;
                        contextoNew.Empresas.Add(nuevaEmpresa);
                        contextoNew.SaveChanges();

                        LimpiarCampos();
                        MessageBox.Show("Elemento añadido a la base de datos correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        success = true;

                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
                else
                {
                    try
                    {

                        Empresa EmpresaEdit = contextoNew.Empresas.Where(U => U.EmpresaID == IdEmpresa).SingleOrDefault();
                        nuevaEmpresa.EmpresaID = EmpresaEdit.EmpresaID;
                        nuevaEmpresa.Creacion = EmpresaEdit.Creacion;

                        if (EmpresaEdit != null)
                        {
                            contextoNew.Empresas.AddOrUpdate(nuevaEmpresa);
                            contextoNew.SaveChanges();
                            MessageBox.Show("Elemento actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            success = true;
                        }

                    }
                    catch (Exception)
                    {
                        return;
                    }

                }

            }
            if (success)
            {
                this.Close();
            }
        }
    }
}
