namespace lab7repaso
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1mantenimiento = new System.Windows.Forms.Button();
            this.button2alta = new System.Windows.Forms.Button();
            this.button3baja = new System.Windows.Forms.Button();
            this.button4palta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1mantenimiento
            // 
            this.button1mantenimiento.Location = new System.Drawing.Point(74, 324);
            this.button1mantenimiento.Name = "button1mantenimiento";
            this.button1mantenimiento.Size = new System.Drawing.Size(114, 66);
            this.button1mantenimiento.TabIndex = 1;
            this.button1mantenimiento.Text = "Ordenar por Mantenimiento";
            this.button1mantenimiento.UseVisualStyleBackColor = true;
            this.button1mantenimiento.Click += new System.EventHandler(this.button1mantenimiento_Click);
            // 
            // button2alta
            // 
            this.button2alta.Location = new System.Drawing.Point(228, 324);
            this.button2alta.Name = "button2alta";
            this.button2alta.Size = new System.Drawing.Size(117, 37);
            this.button2alta.TabIndex = 2;
            this.button2alta.Text = "Cuota mas alta";
            this.button2alta.UseVisualStyleBackColor = true;
            // 
            // button3baja
            // 
            this.button3baja.Location = new System.Drawing.Point(228, 367);
            this.button3baja.Name = "button3baja";
            this.button3baja.Size = new System.Drawing.Size(117, 37);
            this.button3baja.TabIndex = 3;
            this.button3baja.Text = "Cuota mas baja";
            this.button3baja.UseVisualStyleBackColor = true;
            // 
            // button4palta
            // 
            this.button4palta.Location = new System.Drawing.Point(383, 324);
            this.button4palta.Name = "button4palta";
            this.button4palta.Size = new System.Drawing.Size(126, 66);
            this.button4palta.TabIndex = 4;
            this.button4palta.Text = "Propietario cuota mas alta";
            this.button4palta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4palta);
            this.Controls.Add(this.button3baja);
            this.Controls.Add(this.button2alta);
            this.Controls.Add(this.button1mantenimiento);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1mantenimiento;
        private System.Windows.Forms.Button button2alta;
        private System.Windows.Forms.Button button3baja;
        private System.Windows.Forms.Button button4palta;
    }
}

