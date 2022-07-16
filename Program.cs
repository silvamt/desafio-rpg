using desafio_rpg.src.Entities;

Knight arus = new Knight("Arus", 42, 429, 72, "Knight");
Ninja wedge = new Ninja("Wedge", 42, 292, 89, "Ninja");
WhiteWizard jennie = new WhiteWizard("Jenica", 42, 325, 474, "White Wizard");
BlackWizard topapa = new BlackWizard("Topapa", 42, 106, 611, "Black Wizard");

Console.WriteLine("---------------------------------------");
Console.WriteLine($"Apresentação do cavaleiro: {arus.ToString()}");
Console.WriteLine($"Ataque do cavaleiro: {arus.Attack()}");
Console.WriteLine("---------------------------------------");
Console.WriteLine($"Apresentação do ninja: {wedge.ToString()}");
Console.WriteLine($"Ataque do ninja: {wedge.Attack()}");
Console.WriteLine("---------------------------------------");
Console.WriteLine($"Apresentação da feiticeira branca: {jennie.ToString()}");
Console.WriteLine($"Ataque normal da feiticeira branca: {jennie.Attack()}");
Console.WriteLine($"Ataque especial da feiticeira branca: {jennie.Attack(10)}");
Console.WriteLine("---------------------------------------");
Console.WriteLine($"Apresentação da feiticeiro negro: {topapa.ToString()}");
Console.WriteLine($"Ataque normal do feiticeiro negro: {topapa.Attack()}");
Console.WriteLine($"Ataque especial do feiticeiro negro: {topapa.Attack(10)}");
Console.WriteLine("---------------------------------------");
