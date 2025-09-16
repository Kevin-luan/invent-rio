using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Inventario
{
    public partial class frmCadEquipMobolizado : Form
    {
        MySqlConnection conn;
        public frmCadEquipMobolizado()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu voltar = new frmMenu();
            voltar.Show();
            this.Hide();

        }

        private void btnCadastrarEquip_Click(object sender, EventArgs e)
        {
            string nome, modelo;
            int mobilizado;

            nome = txbNomeEquip.Text;
            modelo = txbMarcaEquip.Text;
            mobilizado= int.Parse(txbMobolizadoEquip.Text);

            if (nome =="" |  modelo=="" | mobilizado<=0)
            {

                MessageBox.Show("O campo nome precisa ser prenchido");

            }
            else
            {
                Cadastrar();
            }
               


           
        }
    
            public void Cadastrar()
        {

            try
            {

            }catch 
            {
            }
        }
    }
}
