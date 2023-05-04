using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormCompanyList : Form
    {
        bool isNew = true;
        public FormCompanyList(Contexto context)
        {
            InitializeComponent();
            this.Text = "Formulario lista de compañías";
            TablaDatos.DataSource = context.Empresas.ToList();
            TablaDatos.Columns[0].Visible = false;
        }

        private void AgregarButton(object sender, EventArgs e)
        {
            Form formularioNew = new FormCompanyEditor();
            formularioNew.FormClosed += ActualizarTabla;
            formularioNew.ShowDialog();



        }

        //private void CancelarButton(object sender, EventArgs e)
        //{
        //    var result = MessageBox.Show("¿Desea cancelar la operación?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (result == DialogResult.Yes)
        //    {
        //        tabControl1.SelectedIndex = 0;
        //        LimpiarCampos();
        //        TituloEditor.Text = "Creando nueva Empresa";
        //    }
        //}

        //private void GuardarButton(object sender, EventArgs e)
        //{
        //    int codigoInt = 0;
        //    if (string.IsNullOrEmpty(nombreTxt.Text) || string.IsNullOrEmpty(codigoTxt.Text) || string.IsNullOrEmpty(direccionTxt.Text)
        //        || string.IsNullOrEmpty(telefonoTxt.Text) || string.IsNullOrEmpty(ciudadTxt.Text) || string.IsNullOrEmpty(departamentoTxt.Text) ||
        //        string.IsNullOrEmpty(paisTxt.Text))
        //    {
        //        MessageBox.Show("Debe rellenar todos los campos para añadir una nueva empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if (!Int32.TryParse(codigoTxt.Text.Trim(), out codigoInt))
        //    {
        //        MessageBox.Show("El código no debe contener caracteres especiales o letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    else
        //    {
        //        Empresa nuevaEmpresa = new Empresa();
        //        Contexto contextoNew = new Contexto();

        //        nuevaEmpresa.Nombre = nombreTxt.Text.Trim();
        //        nuevaEmpresa.Codigo = codigoInt;
        //        nuevaEmpresa.Direccion = direccionTxt.Text.Trim();
        //        nuevaEmpresa.Telefono = telefonoTxt.Text.Trim();
        //        nuevaEmpresa.Ciudad = ciudadTxt.Text.Trim();
        //        nuevaEmpresa.Departamento = departamentoTxt.Text.Trim();
        //        nuevaEmpresa.Pais = paisTxt.Text.Trim();
        //        nuevaEmpresa.Modificacion = DateTime.Now;

        //        if (isNew) {
        //            try
        //            {
        //                nuevaEmpresa.Creacion = DateTime.Now;
        //                contextoNew.Empresas.Add(nuevaEmpresa);
        //                contextoNew.SaveChanges();

        //                LimpiarCampos();
        //                MessageBox.Show("Elemento añadido a la base de datos correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
        //            }
        //            catch (Exception)
        //            {
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            try
        //            {
        //                int IdEmpresa = Int16.Parse(TablaDatos.CurrentRow.Cells[0].Value.ToString());

        //                Empresa EmpresaEdit = contextoNew.Empresas.Where(U => U.EmpresaID == IdEmpresa).SingleOrDefault();
        //                nuevaEmpresa.EmpresaID = EmpresaEdit.EmpresaID;
        //                nuevaEmpresa.Creacion = EmpresaEdit.Creacion;

        //                if (EmpresaEdit != null)
        //                {
        //                    contextoNew.Empresas.AddOrUpdate(nuevaEmpresa);
        //                    contextoNew.SaveChanges();
        //                    MessageBox.Show("Elemento actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                }

        //            }
        //            catch (Exception)
        //            {
        //                return;
        //            }

        //        }

        //        tabControl1.SelectedIndex = 0;
        //        TablaDatos.DataSource = contextoNew.Empresas.ToList();


        //    }
        //}


        private void ModificarButton(object sender, EventArgs e)
        {
            if (TablaDatos.Rows.GetRowCount(DataGridViewElementStates.Selected) > 1)
            {
                MessageBox.Show("Solo puede modificar un registro a la vez\nElimine la selección múltiple e intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (TablaDatos.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
            {
                int empresaID = Int16.Parse(TablaDatos.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Vas a actualizar la empresa: " + TablaDatos.CurrentRow.Cells[1].Value.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Contexto context = new Contexto();

                Empresa aux = context.Empresas.Where(u => u.EmpresaID == empresaID).SingleOrDefault();

                TituloEditor.Text = $"Editando Empresa {aux.Nombre}";
                isNew = false;

                Form ActualizarForm = new FormCompanyEditor(empresaID, aux.Nombre ,isNew, aux);

                ActualizarForm.FormClosed += ActualizarTabla;
                
                ActualizarForm.ShowDialog();
            }
        }

        public void ActualizarTabla(object sender, FormClosedEventArgs e) {

            Contexto context = new Contexto();
            TablaDatos.DataSource = context.Empresas.ToList();

        }


        private void EliminarButton(object sender, EventArgs e)
        {
            int filas = Int16.Parse(TablaDatos.Rows.GetRowCount(DataGridViewElementStates.Selected).ToString());
            Contexto context = new Contexto(); 

            if (filas <= 0)
            {
                MessageBox.Show("Debe seleccionar al menos una fila para proceder", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int x = 0; x < filas; x++)
                {
                    string nombre = TablaDatos.SelectedRows[x].Cells[1].Value.ToString();
                    int id = Int16.Parse(TablaDatos.SelectedRows[x].Cells[0].Value.ToString());

                    var result = MessageBox.Show($"¿Desea eliminar los registros de la empresa {nombre}?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Empresa empresaAux = context.Empresas.Where(U => U.EmpresaID == id).FirstOrDefault();
                        context.Empresas.Remove(empresaAux);
                        
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show($"No se eliminó el registro asociado a la empresa {nombre}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    


                    //string nombre = TablaDatos.SelectedRows[x].Cells[1].Value.ToString();
                    //int id = Int16.Parse(TablaDatos.SelectedRows[x].Cells[0].Value.ToString());
                    //var result = MessageBox.Show($"¿Desea eliminar los registros de la empresa {nombre}?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    //if (result == DialogResult.Yes)
                    //{
                    //    Empresa empresaAux = context.Empresas.Where(U => U.EmpresaID == id).FirstOrDefault();

                    //    if (empresaAux != null)
                    //    {
                    //        context.Empresas.Remove(empresaAux);
                    //        context.SaveChanges();
                    //    }

                    //    TablaDatos.DataSource = context.Empresas.ToList();

                    //}
                    //else
                    //{
                    //    MessageBox.Show($"No se eliminó el registro asociado a la empresa {nombre}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
                context.SaveChanges();
            }

            TablaDatos.DataSource = context.Empresas.ToList();

        }

        private void Filtrado(object sender, EventArgs e)
        {
            Contexto context = new Contexto();

            if (!string.IsNullOrEmpty(Filtro.Text))
            {
                TablaDatos.DataSource = context.Empresas.Where(U => U.Nombre.Contains(Filtro.Text)).ToList();
            }
            else
            {
                TablaDatos.DataSource = context.Empresas.ToList();
            }
        }
    }
}
