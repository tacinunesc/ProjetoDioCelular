using ProjetoDioCelular.Models;

//realiza os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("67894534675", "C20", 12453456, 32);
Smartphone iphone = new Iphone("364523478564", "XR", 90781232,64);
Smartphone moto = new Motorola("12342589564", "Moto E6 Plus", 63489756,32);

nokia.Ligar();
nokia.InstalarAplicativo("Cobrinha");
Console.WriteLine("Número");
nokia.MostrarNumero();
Console.WriteLine("Novo número");
nokia.Numero = "12453456";
nokia.MostrarNumero();
Console.WriteLine("Modelo");
nokia.MostrarModelo();

//iphone.InstalarAplicativo("Facebook");
//iphone.MostrarNumero();
//iphone.ReceberLigacao();
//iphone.MostrarModelo();

//moto.InstalarAplicativo("Whatsapp");
//moto.MostrarNumero();
//moto.MostrarModelo();