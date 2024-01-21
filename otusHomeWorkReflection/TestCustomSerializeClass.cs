using otusHomeWorkReflection.Class;
using System.Diagnostics;

namespace otusHomeWorkReflection
{
    public class TestCustomSerializeClass(F f) : ISerializeTest
    {
        private readonly Stopwatch _stopWatch = new();
        public string SerializedText { get; set; }
        public int AmountIterations { get; set; } = 100000;

        /// <summary>
        /// сериализация 
        /// </summary>
        public void Serialize()
        {      
            _stopWatch.Start();
            for (int i = 0; i < AmountIterations; i++)
            {
                SerializedText = CustomSerializeClass.Serialize(f);
            }
            _stopWatch.Stop();
            Console.WriteLine(@"Серилизация(собственная): " + _stopWatch.Elapsed.TotalMilliseconds);
        }

        /// <summary>
        /// десериализация 
        /// </summary>
        public void Deserialization()
        {
            _stopWatch.Start();
            for (int i = 0; i < AmountIterations; i++)
            {
                var deserializationObject = (F)CustomSerializeClass.Deserialize<F>(SerializedText);
            }
            _stopWatch.Stop();
            Console.WriteLine(@"Десерилизация(собственная): " + _stopWatch.Elapsed.TotalMilliseconds);
        }
    }
}