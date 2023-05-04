namespace WindowsFormsApp1
{
    partial class FormCompanyList
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompanyList));
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Filtro = new System.Windows.Forms.TextBox();
            this.TablaDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Filtrado por nombre de Empresa";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.EliminarButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ModificarButton);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AgregarButton);
            // 
            // Filtro
            // 
            this.Filtro.Location = new System.Drawing.Point(346, 66);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(100, 20);
            this.Filtro.TabIndex = 7;
            this.Filtro.TextChanged += new System.EventHandler(this.Filtrado);
            // 
            // TablaDatos
            // 
            this.TablaDatos.AllowUserToAddRows = false;
            this.TablaDatos.AllowUserToDeleteRows = false;
            this.TablaDatos.AllowUserToOrderColumns = true;
            this.TablaDatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TablaDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.TablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TablaDatos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.TablaDatos.Location = new System.Drawing.Point(12, 186);
            this.TablaDatos.Name = "TablaDatos";
            this.TablaDatos.ReadOnly = true;
            this.TablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaDatos.Size = new System.Drawing.Size(776, 231);
            this.TablaDatos.TabIndex = 6;
            // 
            // FormCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.TablaDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompanyList";
            this.Text = "Formulario vista de Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Filtro;
        private System.Windows.Forms.DataGridView TablaDatos;
    }
}

