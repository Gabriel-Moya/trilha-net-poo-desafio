using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ListarInformacoes();

Console.WriteLine();

Smartphone iphone = new Iphone(numero: "498567", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ListarInformacoes();
