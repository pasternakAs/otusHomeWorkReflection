using Newtonsoft.Json;
using otusHomeWorkReflection.Class;
using System.Diagnostics;

namespace otusHomeWorkReflection
{
    public class TestNewtonsoftSerializeClass(F f) : ISerializeTest
    {
        private readonly Stopwatch _stopWatch = new();
        public string SerializedText { get; set; }
        public int AmountIterations { get; set; } = 100000;

        /// <summary>
        ///  сериализация Newtonsoft.Json
        /// </summary>
        public void Serialize()
        {
            _stopWatch.Start();
            for (int i = 0; i < AmountIterations; i++)
            {
                SerializedText = JsonConvert.SerializeObject(f);
            }
            _stopWatch.Stop();
            Console.WriteLine(@"Серилизация(Newtonsoft.Json): " + _stopWatch.Elapsed.TotalMilliseconds);
        }

        /// <summary>
        /// десериализация Newtonsoft.Json
        /// </summary>
        public void Deserialization()
        {
            _stopWatch.Start();
            for (int i = 0; i < AmountIterations; i++)
            {
                var deserializationObject = JsonConvert.DeserializeObject<F>(SerializedText);
            }
            _stopWatch.Stop();
            Console.WriteLine(@"Десерилизация(Newtonsoft.Json): " + _stopWatch.Elapsed.TotalMilliseconds);
        }
    }
}