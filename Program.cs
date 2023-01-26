using DesafioPOO.Models;

// Implementado!!!
Console.WriteLine("Testes do Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "91234-5678", modelo: "Modelo 1", imei: "1111111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine("Número do Nokia: " + nokia.Numero);
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Testes do Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "98765-4321", modelo: "Modelo 2", imei: "222222222", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine("Número do iPhone: " + iphone.Numero);
iphone.InstalarAplicativo("Telegram");