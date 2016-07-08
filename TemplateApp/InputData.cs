using System.Runtime.Serialization;

namespace OpenGlTemplateApp
{
    /// <summary>
    /// Структура считываемых файлов.
    /// </summary>
    [DataContract]
    internal class InputData
    {
        [DataMember(Name = "dataPoints")]
        public DataPoints Points { get; private set; }

        [DataMember(Name = "dataProperty")]
        public DataProperty Property { get; private set; }
    }
}
