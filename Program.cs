using DesafioPOO.Models;

Iphone iphone = new Iphone("16", "Plus", "956303480948781", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Nokia nokia = new Nokia("8", "Sirocco", "999303480948781", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");