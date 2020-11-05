using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using Excepciones;
namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;
            XmlTextWriter writer = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer.Serialize(writer, datos);
                retorno = true;
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
            finally
            {
                if (!(writer is null))
                    writer.Close();
            }
            return retorno;
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlTextReader reader = null;
            datos = default(T);
            try
            {
                if (File.Exists(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    reader = new XmlTextReader(archivo);
                    datos = (T)serializer.Deserialize(reader);
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            finally
            {
                if (!(reader is null))
                    reader.Close();
            }
            return false;
        }
    }
}
