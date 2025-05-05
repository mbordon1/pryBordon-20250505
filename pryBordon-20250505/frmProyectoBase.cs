using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBordon_20250505
{
    public partial class frmProyectoBase : Form
    {
        public frmProyectoBase()
        {
            InitializeComponent();
        }

        private void frmProyectoBase_Load(object sender, EventArgs e)
        {
            string [] heroes = { "Superman", "Batman", "Wonderwoman", "Aquaman" };
            cmbSuperheroe.Items.AddRange(heroes);

        }

        private void cmbSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string heroeSeleccionado = cmbSuperheroe.SelectedItem.ToString();

            switch (heroeSeleccionado)
            {
                case "Superman":
                    picSuperHeroe.Image = Properties.Resources.Superman;
                    break;
                case "Batman":
                    picSuperHeroe.Image = Properties.Resources.Batman;
                    break;
                case "Wonderwoman":
                    picSuperHeroe.Image = Properties.Resources.Wonderwoman;
                    break;
                case "Aquaman":
                    picSuperHeroe.Image = Properties.Resources.Aquaman;
                    break;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string heroe = cmbSuperheroe.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(heroe))
            {
                MessageBox.Show("Selecciona un héroe primero.");
                return;
            }

            int fuerza = (int)numFuerza.Value;
            int resistencia = (int)numResistencia.Value;

            string rutaArchivo = "SuperheroesGuardados.txt";
            string linea = $"{heroe}, Fuerza: {fuerza}, Resistencia: {resistencia}";

            File.AppendAllText(rutaArchivo, linea + Environment.NewLine);
            MessageBox.Show("Información guardada correctamente.");
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            cmbSuperheroe.SelectedIndex = -1;
            picSuperHeroe.Image = null;
            numFuerza.Value = 1;
            numResistencia.Value = 1;
        }
    }
}
