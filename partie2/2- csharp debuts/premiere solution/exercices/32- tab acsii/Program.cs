char[] alphabet = new char[26];

for (int i = 0; i < 26; i++)
{
    alphabet[i] = (char)('A' + i);
}

int pad = 1;
foreach (char c in alphabet)
{
    string paddedText = c.ToString().PadLeft( pad, ' ');
    Console.WriteLine($"{paddedText}");
    pad++;
}