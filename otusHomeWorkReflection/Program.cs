using otusHomeWorkReflection;
using otusHomeWorkReflection.Class;
using System.Diagnostics;

Console.WriteLine("Начнем!");
var f = new F().Get();
var testCustom = new TestCustomSerializeClass(f);
testCustom.Serialize();
testCustom.Deserialization();
var testNewtonSoft = new TestNewtonsoftSerializeClass(f);
testNewtonSoft.Serialize();
testNewtonSoft.Deserialization();
Console.ReadLine();