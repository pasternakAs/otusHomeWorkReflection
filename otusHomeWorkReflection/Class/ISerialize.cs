using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusHomeWorkReflection.Class
{
    interface ISerializeTest
    {
        string SerializedText { get; set; }
        int AmountIterations { get; set; }

        void Serialize();
        void Deserialization();
    }
}
