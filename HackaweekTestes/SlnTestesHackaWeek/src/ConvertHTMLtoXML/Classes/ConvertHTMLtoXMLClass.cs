using System;
using System.IO;
using System.Xml;

namespace ConvertHTMLtoXML.Classes
{
    public class ConvertHTMLtoXMLClass
    {
        public static void ConverterHTML()
        {
            // Carrega o arquivo HTML
            var path = @"D:/dev/devs2blu/HackaweekTestes/nfse.html";
            string html = File.ReadAllText(path);

            // Cria um objeto XmlTextWriter para escrever o XML
            XmlTextWriter writer = new XmlTextWriter("teste.xml", System.Text.Encoding.UTF8);

            // Configura as opções do XmlTextWriter
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 4;

            // Escreve a tag raiz do XML
            writer.WriteStartElement("html");

            // Cria um objeto XmlReader para ler o HTML
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            XmlReader reader = XmlReader.Create(new StringReader(html), settings);

            // Copia o conteúdo do HTML para o XML
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        writer.WriteStartElement(reader.Name);
                        writer.WriteAttributes(reader, true);
                        if (reader.IsEmptyElement)
                            writer.WriteEndElement();
                        break;
                    case XmlNodeType.Text:
                        writer.WriteString(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        writer.WriteEndElement();
                        break;
                }
            }

            // Fecha a tag raiz do XML
            writer.WriteEndElement();

            // Fecha os objetos XmlTextWriter e XmlReader
            writer.Close();
            reader.Close();
        }
    }
}
