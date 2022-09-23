using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("99999", "nokia 10", "imei", 10000);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da cobrinha");

Iphone iphone = new Iphone("888888", "iphone xr", "imei", 64000);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Fruit Ninja");