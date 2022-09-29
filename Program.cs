// See https://aka.ms/new-console-template for more information


//1.skriv och fråga efter ett långt tal
//2. fånga in svaret i en variabel
//3. skriv ut svaret ca 15 gånger
//4. läs av ett random tal från 1-9 som då ger dig
//start och stopp, (OBS! från vänster till höger!)
//5. Dom använda talen får endast användas 1 gång!
//6. Byt färg på alla tal mellan start och stopp, sen
//ändra tillbaka till "defult" färgen.
//7. skriv ut en ny lista med dom upplysta talen i
//8. Addera ihop alla upplysta tal så du får en
//totalsumma.
//9. Skriv ut totalsumman



/* * skriv och be användaren mata in ett tal som du sen sparar i en variabel, då användaren kanske matar in en bokstav eller något
 * så vill man inte att systemet ska crasha.
 * * Skanna sedan av svaret för start och stop värden, från början till slut, Men det får inte vara en bokstav emellan start och stoppet. 
 * * Skriv sedan ut en ny rad med svaret med allt mellan start och stop värdet i en annan färg .
 * * Sök sedan efter nästa nummer från starten och kolla om den har en matchande partner utan att ha en bokstav emellan varandra.
 * * Skriv ut alla värden som uppfyller kraven i en ny rad med ursprungssvaret fast med alla dom nya "paren" med en annan färg och resten i defult färgen.
 * 
 * * Sen när alla värden är utmarkerade och utkrivna med en annan färg, så spara alla värden i en egen variabel (int).
 * * Addera sedan alla variablar med varandra för att få ut en totalsumma och skriv ut den i consolen.
 * 
 * Skapa en metod som konverterar värdet till en int fram till (om) det kommer något annat än en int och gör det till en substring (Char.isDigit med break;)
 * Skapa en metod som hittar sin "kamrat" (samma nummer) med int/char[0] osv / aka start och stop punkt för att byta färgen
 * 
 * 
 * 
 * 
 */


//Skriver och ber användaren för ett nummer samt fångar det i en variabel (1 & 2)
using System.Runtime.CompilerServices;

Console.WriteLine("Mata in ett nummer: ");
string totalNumber = Console.ReadLine();



ConsoleColor defColor = ConsoleColor.Gray;
ConsoleColor redColor = ConsoleColor.Red;


int startindex = 0;
int endlength = 0;
int indexlength = 0;
string ColorPart;
long TotalColarPartNumbers = 0;



for (int i = 0; i < totalNumber.Length; i++)
{

    if (char.IsDigit(totalNumber[i]))
    {

        startindex = i;
        endlength = totalNumber.IndexOf(totalNumber[i], i + 1);
        if (endlength != -1 && char.IsDigit(totalNumber, endlength))
        {

            indexlength = (endlength - startindex) + 1;
            GetStartandStopIndex(); 
        }
        else
        {
            continue;
        }
        
    }
    else
    {
        continue;
    }
}


void GetStartandStopIndex()
{
    string Indexlength = indexlength.ToString();
    for (int i = 0; i < indexlength; i++)
    {
        ColorPart = totalNumber.Substring(startindex, indexlength);
        if (checkPartForDigits())
        {
            continue;
        }
        else
        {
            Console.Write(totalNumber.Substring(0, startindex));
            Console.ForegroundColor = redColor;
            Console.Write(ColorPart);
            Console.ForegroundColor = defColor;
            Console.WriteLine(totalNumber.Substring(endlength + 1));

            long ColorPartNumber = Int64.Parse(ColorPart);
           
            TotalColarPartNumbers += ColorPartNumber;

            break;
        }
    }

    
    return;
}

bool checkPartForDigits()
{
    for (int i = 0; i < indexlength; i++)
    {
        
        if (!char.IsDigit(ColorPart, i))
        {
            return true;
        }
    }
  return false;
}

Console.WriteLine();
Console.Write($"The total number of all the colored numbers is: ");
Console.ForegroundColor = redColor;
Console.Write(TotalColarPartNumbers);
Console.ForegroundColor = defColor;
Console.WriteLine();