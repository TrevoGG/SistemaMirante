using BibliotecaMirante.Classes;
using BibliotecaMirante.Databases;
using System;
using System.IO;
using System.Windows.Forms;

namespace MiranteDosButias
{
    public partial class Frm_Portaria : Form
    {
        public Frm_Portaria()
        {
            InitializeComponent();
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {

            try
            {
                Portaria.Unit P = new Portaria.Unit();
                P = LituraFormulario();
                P.Valida();

                string cafjson = Portaria.SerealizedClassUnity(P);

                string caminhoDaAreaDeTrabalho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FicharioPortaria");

                // Verifica se a pasta já existe, se não, a cria
                if (!Directory.Exists(caminhoDaAreaDeTrabalho))
                {
                    Directory.CreateDirectory(caminhoDaAreaDeTrabalho);
                }

                FicharioPortaria F = new FicharioPortaria(caminhoDaAreaDeTrabalho);

                if (F.status)
                {
                    F.Incluir(P.Id, cafjson);
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

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbx_PortariaId.Text == "")
                {
                    MessageBox.Show("Erro", "Mirante Dos Butiás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FicharioPortaria F = new FicharioPortaria("C:\\Users\\gui_z\\OneDrive\\Área de Trabalho\\Projeto Mirante\\fichariocafe");
                    string cafejson = F.Buscar(Tbx_PortariaId.Text);
                    if (F.status)
                    {
                        Portaria.Unit C = new Portaria.Unit();
                        C = Portaria.DeserealizedClassUnity(cafejson);
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
        Portaria.Unit LituraFormulario()
        {
            Portaria.Unit p = new Portaria.Unit();

            string data = Mtbx_DataPortaria.Text;

            p.Data = data;

            string id = Tbx_PortariaId.Text;

            p.Id = id;

            string t = Tbx_PortariaTotal.Text;

            p.Total = t;

            return p;

        }
        void EscreveFormulario(Portaria.Unit C)
        {

            Mtbx_DataPortaria.Text = C.Data;
            Tbx_PortariaId.Text = C.Id;
            Tbx_PortariaTotal.Text = C.Total;



        }
    }

}

