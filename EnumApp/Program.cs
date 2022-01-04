// See https://aka.ms/new-console-template for more information

using EnumApp;

Console.WriteLine("Start");

MyEnum m = new MyEnum();

m.SetValue(SomeEnum.First);
Console.WriteLine($"Value: {m.Value} Type: {m.EnumType}");
m.SetValue(AnotherEnum.ThirdVal);
Console.WriteLine($"Value: {m.Value} Type: {m.EnumType}");
m.SetValue(BadEnum.Seven);
Console.WriteLine($"Value: {m.Value} Type: {m.EnumType}");
