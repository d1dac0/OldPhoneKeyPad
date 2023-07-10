// See https://aka.ms/new-console-template for more information

Console.WriteLine(OldPhonePad("33#"));
Console.WriteLine(OldPhonePad("227*#"));
Console.WriteLine(OldPhonePad("4433555 555666#"));
Console.WriteLine(OldPhonePad("8 88777444666*664#"));


static string OldPhonePad(string input)
{
    Dictionary<char, string> keypad = new Dictionary<char, string> {
        { '1', "&'(" },
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" },
        { '*', "" },
        { '0', " " },
        { '#', "" }
    };

    string output = "";
    char currentButton = '0';
    int pressCount = 0;
    bool lastCharDeleted = false;

    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];

        if (c == '#')
        {
            // end of input, add last letter if it wasn't deleted
            if (!lastCharDeleted && currentButton != '0')
            {
                string letters = keypad[currentButton];
                output += letters[(pressCount - 1) % letters.Length];
            }
            break;
        }
        else if (c == ' ')
        {
            // pause detected, add current letter and reset
            if (currentButton != '0')
            {
                string letters = keypad[currentButton];
                output += letters[(pressCount - 1) % letters.Length];
                currentButton = '0';
                pressCount = 0;
            }
        }
        else if (c == '*')
        {
            // backspace, remove last character from output
            lastCharDeleted = true;
            if (output.Length > 0)
            {
                if (output[output.Length - 1] == keypad[currentButton][(pressCount - 1) % keypad[currentButton].Length])
                {
                    // if the last character in the output matches the current button's letter, remove it
                    output = output.Substring(0, output.Length - 1);                    
                }
                else
                {
                    // otherwise, reset to the current button's first letter
                    pressCount = 0;
                }
            }
        }
        else if (c == currentButton)
        {
            // same button pressed, increment press count
            pressCount++;
            lastCharDeleted = false;
        }
        else
        {
            // different button pressed, add current letter and switch to new button
            if (currentButton != '0')
            {
                string letters = keypad[currentButton];
                output += letters[(pressCount - 1) % letters.Length];
            }
            currentButton = c;
            pressCount = 1;
            lastCharDeleted = false;
        }
    }

    return output;
}
