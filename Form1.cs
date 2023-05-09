using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatoFuentes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            FontFamily[] fuentes = new InstalledFontCollection().Families;
            foreach (FontFamily x in fuentes)
            {
                lbox_Fuentes.Items.Add(x.Name);
            }

        }
        private void AplicarEstilosDeFuente()
        {
            FontStyle estilo = FontStyle.Regular;

            if (checkBoxNegrita.Checked)
            {
                estilo |= FontStyle.Bold;
            }

            if (checkBoxCursiva.Checked)
            {
                estilo |= FontStyle.Italic;
            }

            if (checkBoxSubrayado.Checked)
            {
                estilo |= FontStyle.Underline;
            }

            labelTexto.Font = new Font(labelTexto.Font.FontFamily, labelTexto.Font.Size, estilo);
        }

        private void buttonAumentar_Click(object sender, EventArgs e)
        {
            this.Width += 10; 
            this.Height += 10;
        }

        private void buttonReducir_Click(object sender, EventArgs e)
        {
            this.Width -= 10;
            this.Height -= 10;
        }

        private void buttonVerdePropiedades_Click(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Green)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void buttonLilaPropiedades_Click(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Purple)
            {
                this.BackColor = Color.Purple;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void buttonRojoPropiedades_Click(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Red)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void lstTamTexto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tamanoSeleccionado = int.Parse(lstTamTexto.SelectedItem.ToString());
            labelTexto.Font = new Font(labelTexto.Font.FontFamily, tamanoSeleccionado);
        }

        private void buttonVerdeTamaño_Click(object sender, EventArgs e)
        {
            if (labelTexto.ForeColor != Color.Green)
            {
                labelTexto.ForeColor = Color.Green;
            }
            else
            {
                labelTexto.ForeColor = Color.Black;
            }
        }

        private void buttonLilaTamaño_Click(object sender, EventArgs e)
        {
            if (labelTexto.ForeColor != Color.Purple)
            {
                labelTexto.ForeColor = Color.Purple;
            }
            else
            {
                labelTexto.ForeColor = Color.Black;
            }
        }

        private void buttonRojoTamaño_Click(object sender, EventArgs e)
        {
            if (labelTexto.ForeColor != Color.Red)
            {
                labelTexto.ForeColor = Color.Red;
            } else
            {
                labelTexto.ForeColor = Color.Black;
            }
        }

        private void buttonOcultar_Click(object sender, EventArgs e)
        {
            labelTexto.Visible = false;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            labelTexto.Visible = true;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxNegrita_CheckedChanged(object sender, EventArgs e)
        {
            AplicarEstilosDeFuente();
        }

        private void checkBoxCursiva_CheckedChanged(object sender, EventArgs e)
        {
            AplicarEstilosDeFuente();
        }

        private void checkBoxSubrayado_CheckedChanged(object sender, EventArgs e)
        {
            AplicarEstilosDeFuente();
        }

        private void lbox_Fuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fuenteNombre = lbox_Fuentes.SelectedItem.ToString();
            Font fuenteActual = labelTexto.Font;
            labelTexto.Font = new Font(fuenteNombre, fuenteActual.Size, fuenteActual.Style);
        }
    }
}
