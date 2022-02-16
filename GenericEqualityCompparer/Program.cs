

using GenericEqualityCompparer;

var str1 = new TestClass { Test = "Test1" };
var str2 = new TestClass { Test = "Test2" };
var str3 = new TestClass { Test = "Test1" };
var str4 = str2;

var compare = new GenericComparer<TestClass, string>(x => x.Test);

Console.WriteLine("Same value: " + compare.Equals(str1, str3));
Console.WriteLine("Different value: " + compare.Equals(str1, str2));
Console.WriteLine("Same reference: " + compare.Equals(str4, str2));