using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMirante.Databases
{
    public class FicharioCafe
    {
        public string diretorio;
        public string mensagem;
        public bool status;
        public FicharioCafe(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }

                diretorio = Diretorio;
                mensagem = "conexão com o fichario do cafe susesso";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "errinho" + ex.Message;
            }
        }
        public void Incluir(string Id, string jsonunit)
        {
            status = true;
            try
            {
                
                if (File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "já existe esse id " + Id;
                    
                    
                }
                else
                {
                    
                        File.WriteAllText(diretorio + "\\" + Id + ".json", jsonunit);
                        status = true;
                        mensagem = "sucesso!";
                    
                    
                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "errinho" + ex.Message;
            }
        }
        
        public string Buscar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    
                    status = false;
                    mensagem = "não existe" + Id;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Id + ".json");
                    status = true;
                    mensagem = "sucesso!";
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "erro ao  buscar"+ ex.Message;
            }
            return  "";
        }

        public void ApagaCafé(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {

                    status = false;
                    mensagem = "não existe" + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");

                    status = true;
                    mensagem = "apagado com sucesso";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "erro ao  buscar" + ex.Message;
            }
            
        }
        public void Alterar(string Id, string jsonunit)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "já existe esse id" + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonunit);
                    status = true;
                    mensagem = "sucesso!";
                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "errinho" + ex.Message;
            }
        }
    }

}
