using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("1234", "A1b44", "321514A412", 4);
nokia.Ligar();
nokia.InstalarAplicativo("ZapZap");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("1234", "A1b44", "321514A412", 4);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");



