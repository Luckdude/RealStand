using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStand
{
    public partial class RealStand : Form
    {
        public RealStand()
        {
            InitializeComponent();
            SidePanel.Hide();
        }
        //----------------------------------------------------------------------------Data e Hora no Menu Principal------------------------------------------------------------------------------
        private void RealStand_Load(object sender, EventArgs e)
        {
            //hora no menu
            timer1.Start();
            lblHoraMenu.Text = DateTime.Now.ToLongTimeString();

            //data no menu
            lblDataMenu.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer 
            lblHoraMenu.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        //------------------------------------------------------------------------------------Mover a Form-----------------------------------------------------------------------------------

        //Créditos: https://www.youtube.com/watch?v=0XKboCsfsTc;

        int TogMove;
        int MValX;
        int MValY;

        private void pBMoverForm_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pBMoverForm_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pBMoverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        //----------------------------------------------------------------------------Botões para Fechar e Minimizar-----------------------------------------------------------------------------
        private void buttonSairMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonMinimizarMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Mensagens de pop up ao dar hover nos botões
        ToolTip t1 = new ToolTip();
        private void buttonSairMenu_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Fechar", buttonSairMenu);
        }

        private void buttonMinimizarMenu_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Minimizar", buttonMinimizarMenu);
        }

        //--------------------------------------------------------------------------Botões CLIENTE / OFICINA / ALUGUER / VENDAS---------------------------------------------------------------------
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = buttonClientes.Height;
            SidePanel.Top = buttonClientes.Top;

            panelMenu.Controls.Clear();
            FormClientes formClientes = new FormClientes();
            formClientes.TopLevel = false;
            panelMenu.Controls.Add(formClientes);
            formClientes.Show();
            
        }

        private void buttonOficina_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = buttonOficina.Height;
            SidePanel.Top = buttonOficina.Top;

            panelMenu.Controls.Clear();
            FormOficina formOficina = new FormOficina();
            formOficina.TopLevel = false;
            panelMenu.Controls.Add(formOficina);
            formOficina.Show();

        }

        private void buttonAluguer_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = buttonAluguer.Height;
            SidePanel.Top = buttonAluguer.Top;

            panelMenu.Controls.Clear();
            FormAluguer formAluguer = new FormAluguer();
            formAluguer.TopLevel = false;
            panelMenu.Controls.Add(formAluguer);
            formAluguer.Show();
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = buttonVendas.Height;
            SidePanel.Top = buttonVendas.Top;

            panelMenu.Controls.Clear();
            FormVendas formVendas = new FormVendas();
            formVendas.TopLevel = false;
            panelMenu.Controls.Add(formVendas);
            formVendas.Show();

        }

        
    }
}
