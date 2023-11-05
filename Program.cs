using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("47-99998889", modelo: "Tejorola", imei: "55997733", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Excel");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("47-99999777", modelo: "Iphone plus", imei: "33355577", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Photoshop");