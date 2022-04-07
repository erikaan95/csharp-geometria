using FiguraGeometrica;

Console.WriteLine("csharp-geometria");

Console.WriteLine("Per favore, inserisci i dati i valori (base e altezza) per generare un Rettangolo: ");
string baseRettangolo = Console.ReadLine();

Console.WriteLine("Inserisci l'altezza del rettangolo: ");
string altezzaRettangolo = Console.ReadLine();

Console.WriteLine("Inserisci il perimetro del rettangolo: ");
int perimetroRettangolo = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'area del rettangolo: ");
string areaRettangolo = Console.ReadLine();

// Creo un oggetto Rettangolo //
Rettangolo IlMioRettangolo = new Rettangolo(baseRettangolo, altezzaRettangolo,);

IlMioRettangolo.StampaRettangolo();

IlMioRettangolo.AssegnaUnaBase("20 cm");

IlMioRettangolo.AssegnaUnaAltezza("10 cm");

IlMioRettangolo.AssegnaUnPerimetro("60 cm");

IlMioRettangolo.AssegnaUnArea("200 cm2");
