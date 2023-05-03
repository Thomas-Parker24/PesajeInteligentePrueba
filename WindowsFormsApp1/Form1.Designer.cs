namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TablaDatos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TituloEditor = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.paisTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.departamentoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ciudadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.label8);
            this.TabPage.Controls.Add(this.button3);
            this.TabPage.Controls.Add(this.button2);
            this.TabPage.Controls.Add(this.button1);
            this.TabPage.Controls.Add(this.textBox1);
            this.TabPage.Controls.Add(this.TablaDatos);
            this.TabPage.Location = new System.Drawing.Point(4, 22);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage.Size = new System.Drawing.Size(792, 427);
            this.TabPage.TabIndex = 0;
            this.TabPage.Text = "Listado de compañías";
            this.TabPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ModificarButton);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AgregarButton);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // TablaDatos
            // 
            this.TablaDatos.AllowUserToAddRows = false;
            this.TablaDatos.AllowUserToDeleteRows = false;
            this.TablaDatos.AllowUserToOrderColumns = true;
            this.TablaDatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TablaDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.TablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDatos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.TablaDatos.Location = new System.Drawing.Point(8, 183);
            this.TablaDatos.Name = "TablaDatos";
            this.TablaDatos.ReadOnly = true;
            this.TablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaDatos.Size = new System.Drawing.Size(776, 231);
            this.TablaDatos.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TituloEditor);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.paisTxt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.departamentoTxt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ciudadTxt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.telefonoTxt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.direccionTxt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.codigoTxt);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.nombreTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor de compañías";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TituloEditor
            // 
            this.TituloEditor.AutoSize = true;
            this.TituloEditor.Location = new System.Drawing.Point(334, 19);
            this.TituloEditor.Name = "TituloEditor";
            this.TituloEditor.Size = new System.Drawing.Size(35, 13);
            this.TituloEditor.TabIndex = 16;
            this.TituloEditor.Tag = "";
            this.TituloEditor.Text = "label8";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(386, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CancelarButton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GuardarButton);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "País";
            // 
            // paisTxt
            // 
            this.paisTxt.Location = new System.Drawing.Point(372, 328);
            this.paisTxt.Name = "paisTxt";
            this.paisTxt.Size = new System.Drawing.Size(100, 20);
            this.paisTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Departamento";
            // 
            // departamentoTxt
            // 
            this.departamentoTxt.Location = new System.Drawing.Point(372, 288);
            this.departamentoTxt.Name = "departamentoTxt";
            this.departamentoTxt.Size = new System.Drawing.Size(100, 20);
            this.departamentoTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ciudad";
            // 
            // ciudadTxt
            // 
            this.ciudadTxt.Location = new System.Drawing.Point(372, 244);
            this.ciudadTxt.Name = "ciudadTxt";
            this.ciudadTxt.Size = new System.Drawing.Size(100, 20);
            this.ciudadTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teléfono de la empresa";
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Location = new System.Drawing.Point(372, 195);
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(100, 20);
            this.telefonoTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección de la empresa";
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(372, 149);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(100, 20);
            this.direccionTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código de la empresa";
            // 
            // codigoTxt
            // 
            this.codigoTxt.Location = new System.Drawing.Point(372, 99);
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.Size = new System.Drawing.Size(100, 20);
            this.codigoTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la empresa";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(372, 51);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(100, 20);
            this.nombreTxt.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Filtrado por nombre de Empresa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView TablaDatos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoTxt;
        private System.Windows.Forms.Label TituloEditor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox paisTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox departamentoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ciudadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.Label label8;
    }
}

