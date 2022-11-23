using Celular.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Nokia nokia = new Nokia(numero: "(11) 12345-1234");
Iphone iphone = new Iphone(numero: "(11) 12345-1234");

nokia.instalarAplicativo("nokia app");

iphone.instalarAplicativo("iphone app");