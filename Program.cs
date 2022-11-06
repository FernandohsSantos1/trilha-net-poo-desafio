using DesafioPOO.Models;

Console.WriteLine("Iniciando programa...\n");

//Instânciando o iphone e o nokia:
Iphone celularIphone = new Iphone(numero: "3333-4444", modelo: "3GS", imei: "1234", memoria: 512);
Nokia celularNokia = new Nokia(numero: "4444-5555", modelo: "C01 Plus", imei: "4321", memoria: 512);

//Chamando seus respectivos métodos:
Console.WriteLine("Celular Iphone:");
celularIphone.Ligar();
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Discord");

Console.WriteLine("\nCelular Nokia:");
celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("WhatsApp");