using System.Xml;

namespace CMA
{
    public static class XML
    {
        public static XmlDocument ReturnBasicAuthXML()
        {
            XmlDocument returnedDoc = new XmlDocument();
            {
                XmlNode EnviarInstrucao = returnedDoc.CreateElement("EnviarInstrucao");
                {
                    XmlNode InstrucaoUnica = returnedDoc.CreateElement("InstrucaoUnica");
                    InstrucaoUnica.Attributes.Append(returnedDoc.CreateAttribute("TipoValidacao"));
                    {
                        XmlNode Razao = returnedDoc.CreateElement("Razao");
                        InstrucaoUnica.AppendChild(Razao);
                    }
                    {
                        XmlNode Valores = returnedDoc.CreateElement("Valores");
                        InstrucaoUnica.AppendChild(Valores);
                    }
                    {
                        XmlNode ID = returnedDoc.CreateElement("IdProprio");
                        InstrucaoUnica.AppendChild(ID);
                    }
                    {
                        XmlNode Pagador = returnedDoc.CreateElement("Pagador");
                        {
                            Pagador.AppendChild(returnedDoc.CreateElement("Nome"));
                            Pagador.AppendChild(returnedDoc.CreateElement("Email"));
                            Pagador.AppendChild(returnedDoc.CreateElement("IdPagador"));
                            XmlNode EnderecoCobranca = returnedDoc.CreateElement("EnderecoCobranca");
                            {
                                EnderecoCobranca.AppendChild(returnedDoc.CreateElement("Logradouro"));
                                EnderecoCobranca.AppendChild(returnedDoc.CreateElement("Numero"));
                                EnderecoCobranca.AppendChild(returnedDoc.CreateElement("Complemento"));
                                EnderecoCobranca.AppendChild(returnedDoc.CreateElement("Bairro"));
                                EnderecoCobranca.AppendChild(returnedDoc.CreateElement("Cidade"));
                                EnderecoCobranca.AppendChild(returnedDoc.CreateElement("Estado"));
                                EnderecoCobranca.AppendChild(returnedDoc.CreateElement("Pais"));
                                EnderecoCobranca.AppendChild(returnedDoc.CreateElement("CEP"));
                                EnderecoCobranca.AppendChild(returnedDoc.CreateElement("TelefoneFixo"));
                            }
                            Pagador.AppendChild(EnderecoCobranca);
                        }
                        InstrucaoUnica.AppendChild(Pagador);
                    }
                    EnviarInstrucao.AppendChild(InstrucaoUnica);
                }
                returnedDoc.AppendChild(EnviarInstrucao);
            }


            return returnedDoc;
        }
    }
}
