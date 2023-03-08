using System.Text.RegularExpressions;

string texto;
texto = Console.ReadLine();
texto = texto.Trim();

//Questão (a)
string texto1 = Regex.Replace(texto, @"\s", "");
Console.WriteLine($"A quantidade de caracteres presente em {texto} é {texto1.Length}");

//Questão (b)
Console.Write("A quantidade de vogais " + ContarVogal(texto));
Console.Write("\nA quantidade de consoante " + ContarCons(texto));
int ContarVogal(string texto)
{
    int qtdvog = 0;
    texto = texto.ToLower();
    for(int i = 0; i < texto.Length; i++)
    {
        if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'o' 
            || texto[i] == 'i' || texto[i] == 'u')
        {
           qtdvog += 1 ;
        }
    }
    return qtdvog;
}
//Questão (c)
int ContarCons(string texto)
{
    int qtdcons = 0;
    texto = texto.ToLower();
    for (int i = 0; i < texto.Length; i++)
    { 
        if (texto[i] == 'b' || texto[i] == 'c' || texto[i] == 'd'
        || texto[i] == 'f' || texto[i] == 'g' || texto[i] == 'h' || texto[i] == 'j' || texto[i] == 'k'
        || texto[i] == 'l' || texto[i] == 'm' || texto[i] == 'n' || texto[i] == 'p' || texto[i] == 'q'
        || texto[i] == 'r' || texto[i] == 's' || texto[i] == 't' || texto[i] == 'v' || texto[i] == 'w' 
        || texto[i] == 'x' || texto[i] == 'y' || texto[i] == 'z')
    {
        qtdcons += 1;
    }
    }
    return qtdcons;
}
//Questão (d)
void AlternarMaiuMin(string x)
{
    for(int i = 0; i < x.Length; i = i + 2)
    {
        x = x.ToUpper();
    }
}