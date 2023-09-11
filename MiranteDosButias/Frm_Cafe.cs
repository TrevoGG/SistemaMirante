using BibliotecaMirante;
using System;
using System.Windows.Forms;
using BibliotecaMirante.Databases;
using System.IO;

namespace MiranteDosButias
{
    public partial class Frm_Cafe : Form
    {
        public Frm_Cafe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CalculaGastoCafe_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(Tbx_Brutocafe.Text, out double totalB) &&
                    double.TryParse(Tbx_GastoCafe.Text, out double totalg))
                {
                    Tbx_TotalLivreCafe.Text = (totalB - totalg).ToString();
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira somente  valores numéricos .", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cafe.Unit C = new Cafe.Unit();
                C = LituraFormulario();
                C.Valida();

                string cafjson = Cafe.SerealizedClassUnity(C);

                FicharioCafe F = new FicharioCafe("C:\\Users\\gui_z\\OneDrive\\Área de Trabalho\\Projeto Mirante\\fichariocafe");

                if (F.status)
                {
                    F.Incluir(C.Id, cafjson);
                    MessageBox.Show("ok" + F.mensagem, "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro" + F.mensagem, "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                          
            }
            catch (Exception ex)
            {
                MessageBox.Show($"erro{ex}");
            }

        }

        Cafe.Unit LituraFormulario()
        {
            Cafe.Unit c = new Cafe.Unit();

            string data = Tbx_Data.Text;

            c.Data = data;

            string id = Tbx_Id.Text;

            c.Id = id;

            string tl = Tbx_TotalLivreCafe.Text;

            c.TotalLivre = tl;

            string tb = Tbx_Brutocafe.Text;

            c.TotalBruto = tb;

            string g = Tbx_GastoCafe.Text;

            c.Gastos = g;

            return c;

        }
        void EscreveFormulario(Cafe.Unit C)
        {

            Tbx_Data.Text = C.Data;
            Tbx_Id.Text = C.Id;
            Tbx_TotalLivreCafe.Text = C.TotalLivre;
            Tbx_Brutocafe.Text = C.TotalBruto;
            Tbx_GastoCafe.Text = C.Gastos;

        }

        private void Tsb_Abrir_Click(object sender, EventArgs e)

        {
            try
            {
                if (Tbx_Id.Text == "")
                {
                    MessageBox.Show("Erro", "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FicharioCafe F = new FicharioCafe("C:\\Users\\gui_z\\OneDrive\\Área de Trabalho\\Projeto Mirante\\fichariocafe");
                    string cafejson = F.Buscar(Tbx_Id.Text);
                    if (F.status)
                    {
                        Cafe.Unit C = new Cafe.Unit();
                        C = Cafe.DeserealizedClassUnity(cafejson);
                        EscreveFormulario(C);
                    }
                    else
                    {
                        MessageBox.Show("Erro, não existe", "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }

        }

        private void excluirToolStripButton_Click(object sender, EventArgs e)
        {
                     
            try
            {
                if (Tbx_Id.Text == "")
                {
                    MessageBox.Show("Erro ", "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FicharioCafe F = new FicharioCafe("C:\\Users\\gui_z\\OneDrive\\Área de Trabalho\\Projeto Mirante\\fichariocafe");

                    if (F.status)
                    {
                        DialogResult result = MessageBox.Show("Deseja realmente apagar? ", "Mirante Dos Butiás", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            F.ApagaCafé(Tbx_Id.Text);
                            if (F.status)
                            {

                                MessageBox.Show("ok " + F.mensagem, "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Erro " + F.mensagem, "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("cancelado");
                        }
                            
                           

                    }
                    else
                    {
                        MessageBox.Show("Erro, não existe", "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }

        }

        private void AlterarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Tbx_Id.Text == "")
            {
                MessageBox.Show("Erro ", "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Cafe.Unit C = new Cafe.Unit();
                    C = LituraFormulario();
                    C.Valida();

                    string cafjson = Cafe.SerealizedClassUnity(C);

                    FicharioCafe F = new FicharioCafe("C:\\Users\\gui_z\\OneDrive\\Área de Trabalho\\Projeto Mirante\\fichariocafe");
                    if (F.status)
                    {
                        F.Alterar(C.Id, cafjson);
                        MessageBox.Show("ok" + F.mensagem, "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Erro" + F.mensagem, "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show($"INICIADO{cafjson}");


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"erro{ex}");
                }
            }
        }
    }
}
