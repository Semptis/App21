var number = 445665545454;
var numberInString = number.ToString();
char[] letters= numberInString.ToCharArray();
int[] lettersCounter = new int[10];

foreach(char c in letters)
{
    lettersCounter[c - '0'] = lettersCounter[c - '0'] + 1;
}

for (int i = 0;i < 10; i++)
{
    Console.WriteLine(i + " " + "=>" + " " + lettersCounter[i]);
}

