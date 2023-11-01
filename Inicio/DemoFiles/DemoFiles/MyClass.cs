using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DemoFiles
{
    [Serializable()] // This class can be serialized
    public class MyClass : ISerializable
    {
        public int MyFirstProperty { get; set; }
        public string MySecondProperty { get; set; }
        
        public MyClass(int a, string b)
        {
            this.MyFirstProperty = a;
            this.MySecondProperty = b;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MyFirstProperty", this.MyFirstProperty);
            info.AddValue("MySecondProperty", this.MySecondProperty);
            
        }

        public MyClass(SerializationInfo info, StreamingContext context)
        {
            this.MyFirstProperty = (int)info.GetValue("MyFirstProperty", typeof(int));
            this.MySecondProperty = (string)info.GetValue("MySecondProperty", typeof(string));
            
        }
    }
}
