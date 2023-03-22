using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo C12", imei: "999999999", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Facebook");
System.Console.WriteLine();
System.Console.WriteLine("Especificações:");
nokia.EspecificacoesFabrica();
System.Console.WriteLine("-------------------------------------------");


System.Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "456", modelo: "Iphone SE 2020", imei: "088888888", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Safari");
iphone.InstalarAplicativo("Telegram");
System.Console.WriteLine();
System.Console.WriteLine("Especificações:");
iphone.EspecificacoesFabrica();

