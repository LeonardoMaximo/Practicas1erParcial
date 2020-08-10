using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaHerencia.Clases;

namespace PracticaHerencia
{
    public partial class Form1 : Form
    {
        private int boy_extra;
        private int payaso_extra;
        private int botarga_extra;
        private int regalo_extra;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtBE.Visible = false;
            txtPE.Visible = false;
            txtRE.Visible = false;
            lblBE.Visible = false;
            lblPE.Visible = false;
            lblRE.Visible = false;

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtBE.Visible = true;
            txtPE.Visible = true;
            txtRE.Visible = true;
            lblBE.Visible = true;
            lblPE.Visible = true;
            lblRE.Visible = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            

            if (rbPB.Checked==true)
            {
                txtResultado.Text = "";
                if (String.IsNullOrEmpty(txtNE.Text))
                    boy_extra = 0;
                else
                    boy_extra = Convert.ToInt32(txtNE.Text);
                
                Paquete_Basico basico = new Paquete_Basico();
                basico = new Paquete_Basico(600,0,boy_extra);
                basico.costo_servicio();
                txtResultado.Text= basico.costo_servicio().ToString();
            }
            else
            {
                txtResultado.Text = "";
                if (String.IsNullOrEmpty(txtPE.Text))
                    payaso_extra = 0;
                else
                    payaso_extra = Convert.ToInt32(txtPE.Text);

                if (String.IsNullOrEmpty(txtBE.Text))
                    botarga_extra = 0;
                else
                    botarga_extra = Convert.ToInt32(txtBE.Text);

                if (String.IsNullOrEmpty(txtRE.Text))
                    regalo_extra = 0;
                else
                    regalo_extra = Convert.ToInt32(txtRE.Text);
                Paquete_Plus plus = new Paquete_Plus(0,1000,payaso_extra,botarga_extra,regalo_extra);
                plus.Resultado();
                txtResultado.Text = plus.Resultado().ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
