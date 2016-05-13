using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace PilotProject.Infrastructure.Serialization.Impl
{
    internal class SerializationService : ISerializationService
    {
        public void Serialize<T>(T objectToSerialize, string file, string root, string rootNamespace)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(T), root, rootNamespace);
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                Encoding = Encoding.UTF8
            };

            using (FileStream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    serializer.WriteObject(writer, objectToSerialize);
                }
            }
        }

        public T Deserialize<T>(string file, string root, string rootNamespace)
        {
            T deserializedObject;
            using(FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(T), root, rootNamespace);
                deserializedObject = (T)serializer.ReadObject(stream);
            }

            return deserializedObject;
        }
    }
}