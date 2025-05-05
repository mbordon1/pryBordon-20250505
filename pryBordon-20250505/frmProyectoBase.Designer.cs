namespace pryBordon_20250505
{
    partial class frmProyectoBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCrearPersonaje = new System.Windows.Forms.GroupBox();
            this.cmbSuperheroe = new System.Windows.Forms.ComboBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblResistencia = new System.Windows.Forms.Label();
            this.numFuerza = new System.Windows.Forms.NumericUpDown();
            this.numResistencia = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.picSuperHeroe = new System.Windows.Forms.PictureBox();
            this.gbCrearPersonaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuperHeroe)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCrearPersonaje
            // 
            this.gbCrearPersonaje.Controls.Add(this.btnCrear);
            this.gbCrearPersonaje.Controls.Add(this.numResistencia);
            this.gbCrearPersonaje.Controls.Add(this.numFuerza);
            this.gbCrearPersonaje.Controls.Add(this.lblResistencia);
            this.gbCrearPersonaje.Controls.Add(this.lblFuerza);
            this.gbCrearPersonaje.Controls.Add(this.lblSeleccionar);
            this.gbCrearPersonaje.Controls.Add(this.cmbSuperheroe);
            this.gbCrearPersonaje.Location = new System.Drawing.Point(13, 13);
            this.gbCrearPersonaje.Name = "gbCrearPersonaje";
            this.gbCrearPersonaje.Size = new System.Drawing.Size(215, 170);
            this.gbCrearPersonaje.TabIndex = 0;
            this.gbCrearPersonaje.TabStop = false;
            this.gbCrearPersonaje.Text = "Crear personaje";
            // 
            // cmbSuperheroe
            // 
            this.cmbSuperheroe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuperheroe.FormattingEnabled = true;
            this.cmbSuperheroe.Location = new System.Drawing.Point(6, 46);
            this.cmbSuperheroe.Name = "cmbSuperheroe";
            this.cmbSuperheroe.Size = new System.Drawing.Size(188, 21);
            this.cmbSuperheroe.TabIndex = 0;
            this.cmbSuperheroe.SelectedIndexChanged += new System.EventHandler(this.cmbSeleccionar_SelectedIndexChanged);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(6, 27);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(112, 13);
            this.lblSeleccionar.TabIndex = 1;
            this.lblSeleccionar.Text = "Seleccionar personaje";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(6, 81);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(39, 13);
            this.lblFuerza.TabIndex = 2;
            this.lblFuerza.Text = "Fuerza";
            // 
            // lblResistencia
            // 
            this.lblResistencia.AutoSize = true;
            this.lblResistencia.Location = new System.Drawing.Point(6, 114);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Size = new System.Drawing.Size(62, 13);
            this.lblResistencia.TabIndex = 3;
            this.lblResistencia.Text = "Resistencia";
            // 
            // numFuerza
            // 
            this.numFuerza.Location = new System.Drawing.Point(74, 79);
            this.numFuerza.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFuerza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFuerza.Name = "numFuerza";
            this.numFuerza.Size = new System.Drawing.Size(120, 20);
            this.numFuerza.TabIndex = 4;
            this.numFuerza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numResistencia
            // 
            this.numResistencia.Location = new System.Drawing.Point(74, 107);
            this.numResistencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numResistencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numResistencia.Name = "numResistencia";
            this.numResistencia.Size = new System.Drawing.Size(120, 20);
            this.numResistencia.TabIndex = 5;
            this.numResistencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(95, 133);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(99, 31);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // picSuperHeroe
            // 
            this.picSuperHeroe.Location = new System.Drawing.Point(234, 13);
            this.picSuperHeroe.Name = "picSuperHeroe";
            this.picSuperHeroe.Size = new System.Drawing.Size(203, 170);
            this.picSuperHeroe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSuperHeroe.TabIndex = 1;
            this.picSuperHeroe.TabStop = false;
            // 
            // frmProyectoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 207);
            this.Controls.Add(this.picSuperHeroe);
            this.Controls.Add(this.gbCrearPersonaje);
            this.Name = "frmProyectoBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Base";
            this.Load += new System.EventHandler(this.frmProyectoBase_Load);
            this.gbCrearPersonaje.ResumeLayout(false);
            this.gbCrearPersonaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuperHeroe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCrearPersonaje;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.NumericUpDown numResistencia;
        private System.Windows.Forms.NumericUpDown numFuerza;
        private System.Windows.Forms.Label lblResistencia;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.ComboBox cmbSuperheroe;
        private System.Windows.Forms.PictureBox picSuperHeroe;
    }
}