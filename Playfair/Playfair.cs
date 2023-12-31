namespace Playfair
{
    public partial class Playfair : Form
    {
        public Playfair()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string keyText = keyTextInput.Text;
            string plaintext = plainTextInput.Text;
            string encryptedText = PlayfairCipherEncrypt(plaintext, keyText);

            encryptOutput.Text = encryptedText;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string keyText = keyTextInput.Text;
            string encryptedText = plainTextInput.Text;
            string decryptedText = PlayfairCipherDecrypt(encryptedText, keyText);

            decryptOutput.Text = decryptedText;
        }
        private string PlayfairCipherEncrypt(string plaintext, string key)
        {

            plaintext = plaintext.Replace(" ", "").ToUpper();
            key = key.ToUpper();


            char[,] matrix = GenerateMatrix(key);

            plaintext = AdjustPlaintext(plaintext);

            string encryptedText = EncryptText(plaintext, matrix);

            return encryptedText;
        }

        private char[,] GenerateMatrix(string key)
        {
            key = key.Replace("J", "I");

            key = new string(key.Distinct().Where(char.IsLetter).ToArray()).ToUpper();

            char[,] matrix = new char[5, 5];
            int index = 0;

            foreach (char c in key)
            {
                matrix[index / 5, index % 5] = c;
                index++;
            }

            char letter = 'A';
            for (int i = index; i < 25; i++)
            {
                while (key.Contains(letter) || letter == 'J')
                {
                    letter++;
                }
                matrix[i / 5, i % 5] = letter;
                letter++;
            }
            DisplayMatrix(matrix);
            return matrix;
        }
        private void DisplayMatrix(char[,] matrix)
        {
            Button[] btn = {button1,button2,button3,button4,button5,
            button6,button7,button8,button9,button10,
            button11,button12,button13,button14,button15,
            button16,button17,button18,button19,button20,
            button21,button22,button23,button24,button25};
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int index = (i * 5) + j;
                    btn[index].Text = matrix[i, j].ToString();
                }
            }
        }
        private string AdjustPlaintext(string plaintext)
        {
            string adjustedText = "";
            for (int i = 0; i < plaintext.Length; i += 2)
            {
                char char1 = plaintext[i];
                char char2 = (i + 1 < plaintext.Length) ? plaintext[i + 1] : 'X';

                adjustedText += char1;

                if (char1 == char2)
                {
                    adjustedText += 'X';
                    i--;
                }
                else
                {
                    adjustedText += char2;
                }
            }

            if (adjustedText.Length % 2 != 0)
            {
                adjustedText += 'X';
            }

            return adjustedText;
        }


        private string EncryptText(string plaintext, char[,] matrix)
        {
            string encryptedText = "";

            for (int i = 0; i < plaintext.Length; i += 2)
            {
                char char1 = plaintext[i];
                char char2 = plaintext[i + 1];

                int[] index1 = GetCharIndex(char1, matrix);
                int[] index2 = GetCharIndex(char2, matrix);

                int row1 = index1[0];
                int col1 = index1[1];
                int row2 = index2[0];
                int col2 = index2[1];

                if (row1 == row2)
                {
                    encryptedText += matrix[row1, (col1 + 1) % 5];
                    encryptedText += matrix[row2, (col2 + 1) % 5];
                }
                else if (col1 == col2)
                {
                    encryptedText += matrix[(row1 + 1) % 5, col1];
                    encryptedText += matrix[(row2 + 1) % 5, col2];
                }
                else
                {
                    encryptedText += matrix[row1, col2];
                    encryptedText += matrix[row2, col1];
                }
            }

            return encryptedText;
        }

        private int[] GetCharIndex(char c, char[,] matrix)
        {
            int[] index = new int[2];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == c)
                    {
                        index[0] = i;
                        index[1] = j;
                        return index;
                    }
                }
            }

            return index;
        }
        private string PlayfairCipherDecrypt(string encryptedText, string key)
        {
            encryptedText = encryptedText.Replace(" ", "").ToUpper();
            key = key.ToUpper();

            char[,] matrix = GenerateMatrix(key);

            if (encryptedText.Length % 2 != 0)
            {
                encryptedText += 'X';
            }
            string decryptedText = DecryptText(encryptedText, matrix);

            return decryptedText;
        }

        private string DecryptText(string encryptedText, char[,] matrix)
        {
            string decryptedText = "";

            for (int i = 0; i < encryptedText.Length; i += 2)
            {
                char char1 = encryptedText[i];
                char char2 = encryptedText[i + 1];

                int[] index1 = GetCharIndex(char1, matrix);
                int[] index2 = GetCharIndex(char2, matrix);

                int row1 = index1[0];
                int col1 = index1[1];
                int row2 = index2[0];
                int col2 = index2[1];

                if (row1 == row2)
                {
                    decryptedText += matrix[row1, (col1 + 4) % 5];
                    decryptedText += matrix[row2, (col2 + 4) % 5];
                }
                else if (col1 == col2)
                {
                    decryptedText += matrix[(row1 + 4) % 5, col1];
                    decryptedText += matrix[(row2 + 4) % 5, col2];
                }
                else
                {
                    decryptedText += matrix[row1, col2];
                    decryptedText += matrix[row2, col1];
                }
            }

            return decryptedText;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            keyTextInput.Text = string.Empty;
            plainTextInput.Text = string.Empty;
            encryptOutput.Text = string.Empty;
            decryptOutput.Text = string.Empty;
        }

    }
}
