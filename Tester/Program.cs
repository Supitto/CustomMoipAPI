using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.IO;
using System.Net;
using CMA;
using System.Xml;
using System.Text;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> fbf78412a04e221d94675d1cd0d6da8c26824019

namespace Tester
{
    class Program
    {
<<<<<<< HEAD
        static int Main(string[] args)
        {
            Console.WriteLine("Primeiro criamos os XML de identificação da compra");
            //Cria um XML esqueleto conforme o exemplo da documentação Moip
            XmlDocument ID = XML.ReturnBasicAuthXML();
            //Prenche o ID - os dados usados são do exemplo
            
            //Tipo de Transação
            ID.ChildNodes[0].ChildNodes[0].Attributes[0].Value = "Transparente";
            
            //Adciona os valores
            {
                XmlNode valor = ID.CreateElement("Valor");
                valor.Attributes.Append(ID.CreateAttribute("moeda"));
                valor.Attributes[0].Value = "BRL";
                valor.InnerText = "100.00";
            }

            //Atribui ID Proprio
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[2].InnerText = "ABC1234";

            //Atribui dados do pagador
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[0].InnerText = "Nome Sobrenome";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[1].InnerText = "email@cliente.com.br";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[2].InnerText = "id_usuario";
            //Atribui dados de endereco
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[3].ChildNodes[0].InnerText = "Rua do Zézinho Coração";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[3].ChildNodes[0].InnerText = "45";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[3].ChildNodes[0].InnerText = "z";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[3].ChildNodes[0].InnerText = "Palhaço Jão";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[3].ChildNodes[0].InnerText = "São Paulo";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[3].ChildNodes[0].InnerText = "SP";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[3].ChildNodes[0].InnerText = "BRA";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[3].ChildNodes[0].InnerText = "01230-000";
            ID.ChildNodes[0].ChildNodes[0].ChildNodes[3].ChildNodes[3].ChildNodes[0].InnerText = "(11)8888-8888";

            Console.WriteLine("Agora Criamos nossa requisição de autenticação");
            //Ambiente em qual a requisição vai ocorrer
            string Ambiente = "https://desenvolvedor.moip.com.br/sandbox";
            string SelfKey = "";
            string SelfToken = "";
            string Basic = Convert.ToBase64String(Encoding.Unicode.GetBytes(SelfKey + ":" + SelfToken));
            string payload = ID.OuterXml;
            byte[] payloadb = Encoding.Unicode.GetBytes(payload);

            WebRequest AUTH = WebRequest.Create(Ambiente+ "/ws/alpha/EnviarInstrucao/Unica");
            AUTH.Method = "POST";
            AUTH.Headers.Add("Authorization: Basic "+Basic);
            AUTH.ContentType = "application/xml";
            AUTH.ContentLength = payloadb.Length;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Stream DataStream;
            try
            {
                DataStream = AUTH.GetRequestStream();
                DataStream.Write(payloadb, 0, payloadb.Length);
                DataStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return 0;
            }
            Console.WriteLine("Requisição criada");


            Console.WriteLine("Enviando requisição ...");
            WebResponse RespostaAUTH;
            string Resposta;
            try
            {
                RespostaAUTH = AUTH.GetResponse();
                DataStream = RespostaAUTH.GetResponseStream();
                Resposta = new StreamReader(DataStream).ReadToEnd();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return 0;
            }
            Console.WriteLine("Requisição retornou com sucesso");


            Console.WriteLine("Lendo o status interno da resposta");
            XmlDocument resp = new XmlDocument();
            resp.LoadXml(Resposta);
            string Token = "";
            if(resp.ChildNodes[0]["Resposta"]["Status"].InnerText == "Falha")
            {
                Console.WriteLine("A requisição não pode te fornecer um token");
                Console.WriteLine("Causa : " + resp.ChildNodes[0]["Resposta"]["Erro"].InnerText);
                Console.ReadKey();
                return 0;
            }

            Token = resp.ChildNodes[0]["Resposta"]["Token"].InnerText;
            Console.WriteLine("Token recuperado com sucesso");
            Console.WriteLine("Token : " + Token);
            Console.WriteLine("Daqui pra frente o navegador fica responsavel");

            Console.ReadKey();
            return 0;
=======
        static void Main(string[] args)
        {
>>>>>>> fbf78412a04e221d94675d1cd0d6da8c26824019
        }
    }
}
