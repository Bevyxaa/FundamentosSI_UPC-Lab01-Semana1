using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjEmpresa
{
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emple = new Empleado();
            emple.Nombre = txtNombre.Text;
            emple.Categoria = cbCategoria.Text;
            emple.MinutosTardanza = int.Parse(txtMinutos.Text);
            emple.LlamadasAtencion = int.Parse(txtLLamadas.Text);

            //
            switch (emple.Categoria)
            {
                case "A": emple.Pago = 2500; break;
                case "B": emple.Pago = 1500; break;
                case "C": emple.Pago = 1000; break;
                case "D": emple.Pago = 900; break;
            }
            if (emple.MinutosTardanza == 0 && emple.LlamadasAtencion == 00)
            {
                emple.Pago = emple.Pago + emple.Pago * 0.15;
            }
            else
            {
                double descontarMinutosTardanza = emple.MinutosTardanza * 5;
                double descontarLlamadasAtencion = emple.LlamadasAtencion * 10;
                emple.Pago = emple.Pago - descontarMinutosTardanza - descontarLlamadasAtencion;
            }
            ListViewItem fila = new ListViewItem(emple.Nombre);
            fila.SubItems.Add(emple.Categoria);
            fila.SubItems.Add(emple.MinutosTardanza.ToString());
            fila.SubItems.Add(emple.LlamadasAtencion.ToString());
            fila.SubItems.Add(emple.Pago.ToString());

            ListViewEmpleados.Items.Add(fila);
            if (lblTotal.Text == "")
            {
                lblTotal.Text = "1";
            }
            else
            {
                lblTotal.Text = (int.Parse(lblTotal.Text) + 1).ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
