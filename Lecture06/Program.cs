// See https://aka.ms/new-console-template for more information

string playerName = Console.ReadLine();

int indexInValid;
Validate(playerName, 20, out indexInValid);
bool Validate(string str, int sizeToCheck, out int indexInValid)
{
    indexInValid = -1;
    
    if (str.Length > sizeToCheck)
    {
        return false;
    }

    for (int i = 0; i < str.Length; i++)
    {
        if (!IsASCII(str[i]))
        {
            indexInValid = i;
            return false;
        }
    }

    return true;
}

bool IsASCII(char c)
{
    if ((c >= 'A' && c <= 'Z') || // is upper case
        (c >= 'a' && c <= 'z')) // is lower case
        return true;
    
    return false;
}
