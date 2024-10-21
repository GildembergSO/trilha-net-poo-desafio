using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia ("81991919292", "Tijolinho", "14321", 32);
Console.WriteLine ($"Smartphone Nokia");
nokia.Ligar ();
nokia.InstalarAplicativo ("Instagram");

Console.WriteLine ("___________________________________________");

Smartphone iphone = new Iphone ("83996789890", "S6 Pro MAX", "12341", 64);
Console.WriteLine ($"Smartphone iPhone");
iphone.Ligar ();
iphone.InstalarAplicativo ("Whatsapp");