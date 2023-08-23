using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456","Modelo 1", "111111111",64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("1554512","Modelo 2", "22222222",128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");