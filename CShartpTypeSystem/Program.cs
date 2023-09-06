// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ciao utente!");
Console.WriteLine("Come ti chiami?");

string nome = Console.ReadLine();

Console.WriteLine("Benvenuto " + nome + ", piacere di conoscerti!");

Console.Write("Dimmi quanti numeri vincenti vuoi inserire: ");

int quantitaNumeriVincenti = int.Parse(Console.ReadLine());

int[] numeriVincenti = new int[quantitaNumeriVincenti];

for(int i = 0; i < numeriVincenti.Length; i++)
{
	Console.Write($"Inserisci il {i+1} numero: ");
	numeriVincenti[i] = int.Parse(Console.ReadLine());
}

int[] numeriVincentiOriginali = (int[])numeriVincenti.Clone();


// Sommo 1 a tutti i numeri vincenti
for(int i = 0; i < numeriVincenti.Length; i++)
{
	numeriVincenti[i] = numeriVincenti[i] + 1;
}

Console.WriteLine("I numeri della lotteria estratti originali erano: ");

for (int i = 0; i < numeriVincentiOriginali.Length; i++)
{
	Console.Write(numeriVincentiOriginali[i]);
	if (numeriVincentiOriginali[i] % 2 == 0)
	{
		Console.WriteLine(" - pari");
	}
	else
	{
		Console.WriteLine(" - dispari");
	}
}

Console.WriteLine("I numeri della lotteria estratti sommati 1 sono: ");

for (int i = 0; i < numeriVincenti.Length; i++)
{
	Console.Write(numeriVincenti[i]);
	if (numeriVincenti[i] % 2 == 0)
	{
		Console.WriteLine(" - pari");
	}
	else
	{
		Console.WriteLine(" - dispari");
	}
}

Console.WriteLine("Alla prossima giocata!");

int a = 1;
int b = int.Parse(Console.ReadLine());
int risultato = a + b;
