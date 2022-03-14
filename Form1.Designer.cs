namespace Laboratorio_7___Laboratorio_de_repaso_3
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCuotaMantenimiento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPropietarioCuotaMasAlta = new System.Windows.Forms.Label();
            this.labelCuotaMasAlta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3MantenimientosMasAltos = new System.Windows.Forms.Button();
            this.button3MantenimientosMasBajos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(37, 33);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(656, 340);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonCuotaMantenimiento
            // 
            this.buttonCuotaMantenimiento.Location = new System.Drawing.Point(731, 138);
            this.buttonCuotaMantenimiento.Name = "buttonCuotaMantenimiento";
            this.buttonCuotaMantenimiento.Size = new System.Drawing.Size(136, 39);
            this.buttonCuotaMantenimiento.TabIndex = 1;
            this.buttonCuotaMantenimiento.Text = "Cuota de Mantenimiento";
            this.buttonCuotaMantenimiento.UseVisualStyleBackColor = true;
            this.buttonCuotaMantenimiento.Click += new System.EventHandler(this.buttonCuotaMantenimiento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuota más alta";
            // 
            // labelPropietarioCuotaMasAlta
            // 
            this.labelPropietarioCuotaMasAlta.AutoSize = true;
            this.labelPropietarioCuotaMasAlta.Location = new System.Drawing.Point(417, 418);
            this.labelPropietarioCuotaMasAlta.Name = "labelPropietarioCuotaMasAlta";
            this.labelPropietarioCuotaMasAlta.Size = new System.Drawing.Size(72, 13);
            this.labelPropietarioCuotaMasAlta.TabIndex = 3;
            this.labelPropietarioCuotaMasAlta.Text = "Fulano de Tal";
            // 
            // labelCuotaMasAlta
            // 
            this.labelCuotaMasAlta.AutoSize = true;
            this.labelCuotaMasAlta.Location = new System.Drawing.Point(537, 418);
            this.labelCuotaMasAlta.Name = "labelCuotaMasAlta";
            this.labelCuotaMasAlta.Size = new System.Drawing.Size(31, 13);
            this.labelCuotaMasAlta.TabIndex = 4;
            this.labelCuotaMasAlta.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ordenar por:";
            // 
            // button3MantenimientosMasAltos
            // 
            this.button3MantenimientosMasAltos.Location = new System.Drawing.Point(725, 203);
            this.button3MantenimientosMasAltos.Name = "button3MantenimientosMasAltos";
            this.button3MantenimientosMasAltos.Size = new System.Drawing.Size(149, 39);
            this.button3MantenimientosMasAltos.TabIndex = 6;
            this.button3MantenimientosMasAltos.Text = "3 Mantenimientos mas altos";
            this.button3MantenimientosMasAltos.UseVisualStyleBackColor = true;
            this.button3MantenimientosMasAltos.Click += new System.EventHandler(this.button3MantenimientosMasAltos_Click);
            // 
            // button3MantenimientosMasBajos
            // 
            this.button3MantenimientosMasBajos.Location = new System.Drawing.Point(725, 269);
            this.button3MantenimientosMasBajos.Name = "button3MantenimientosMasBajos";
            this.button3MantenimientosMasBajos.Size = new System.Drawing.Size(149, 39);
            this.button3MantenimientosMasBajos.TabIndex = 7;
            this.button3MantenimientosMasBajos.Text = "3 Mantenimientos mas bajos";
            this.button3MantenimientosMasBajos.UseVisualStyleBackColor = true;
            this.button3MantenimientosMasBajos.Click += new System.EventHandler(this.button3MantenimientosMasBajos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.button3MantenimientosMasBajos);
            this.Controls.Add(this.button3MantenimientosMasAltos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCuotaMasAlta);
            this.Controls.Add(this.labelPropietarioCuotaMasAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCuotaMantenimiento);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCuotaMantenimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPropietarioCuotaMasAlta;
        private System.Windows.Forms.Label labelCuotaMasAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3MantenimientosMasAltos;
        private System.Windows.Forms.Button button3MantenimientosMasBajos;
    }
}

