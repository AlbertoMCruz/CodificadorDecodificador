using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodDecod
{
    public partial class CodificarDecodificar : Form
    {
        public CodificarDecodificar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
            string rutas = @open.FileName;
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            MessageBox.Show(unicodeString, "TEXTO ORIGINAL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            int caras = 0;
            caras = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de columnas", "DIMENSIÓN DEL CILINDRO"));

            int larcad = unicodeString.Length;
            int fi1 = larcad / caras;
            int modd = larcad % caras;

            if (modd > 0)
            {
                fi1 = fi1 + 1;
            }

            int res1 = 0;
            res1 = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de filas\nNUMERO MÍNIMO RECOMENDADO: "+fi1, "DIMENSIÓN DEL CILINDRO"));

            while(res1<fi1){
                MessageBox.Show("El número de filas no puede ser menor al\nmínimo recomendado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                res1 = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de filas\nNUMERO MÍNIMO RECOMENDADO: "+fi1, "DIMENSIÓN DEL CILINDRO"));
            }

            

            int mul = res1 * caras;
            int res2 = mul - larcad;

            string spa = "";
            if (res2 > 0)
            {
                for (int h = 0; h < res2; h++)
                {
                    spa = spa + " ";
                }
            }

            unicodeString = unicodeString + spa;

            char[,] mat1 = new char[res1, caras];
            int k = 0;

            for (int i = 0; i < res1; i++)
            {
                for (int j = 0; j < caras; j++)
                {
                    mat1[i, j] = unicodeString[k];
                    k++;
                }
            }

            string c = "";
            for (int i = 0; i < res1; i++)
            {
                for (int j = 0; j < caras; j++)
                {
                    c = c + mat1[i, j] + " ";
                }
                c = c + "\n";
            }

            MessageBox.Show(c, "TEXTO - MATRIZ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            char[,] mat2 = new char[caras, res1];

            string e1 = "";
            for (int j = 0; j < caras; j++)
            {
                for (int i = 0; i < res1; i++)
                {
                    e1 = e1 + mat1[i, j];
                }
            }

            MessageBox.Show(e1, "ESCÍTALA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, e1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
            string rutas = @open.FileName;
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            MessageBox.Show(unicodeString, "ESCÍTALA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            int caras = 0;
            caras = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de caras original", "CARAS DEL CILINDRO"));

            int larcad = unicodeString.Length;
            int res1 = larcad / caras;

            char[,] mat1 = new char[res1, caras];
            int k = 0;

            for (int j = 0; j < caras; j++)
            {
                for (int i = 0; i < res1; i++)
                {
                    mat1[i, j] = unicodeString[k];
                    k++;
                }
            }

            string c = "";
            for (int i = 0; i < res1; i++)
            {
                for (int j = 0; j < caras; j++)
                {
                    c = c + mat1[i, j] + " ";
                }
               c = c + "\n";
            }

            MessageBox.Show(c, "DECODIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, c);

        }

        private void codascii_Click(object sender, EventArgs e)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            open.ShowDialog();
            string rutas = @open.FileName;
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            MessageBox.Show(unicodeString, "TEXTO ORIGINAL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            // Encode string.
            Byte[] encodedBytes = ascii.GetBytes(unicodeString);
            String c = "";

            foreach (Byte b in encodedBytes)
            {
                c = c + b + " ";
            }
            MessageBox.Show(c, "CODIFICACIÓN ASCII", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, c);
        }

        private void decodascii_Click(object sender, EventArgs e)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            open.ShowDialog();
            string rutas = @open.FileName;
            string asciistring = System.IO.File.ReadAllText(@rutas);
            int [] matascii = new int[asciistring.Length];

            string b = "";
            int j=0;
            for (int i = 0; i < asciistring.Length; i++)
            {
                if (Char.IsDigit(asciistring[i]) && asciistring[i]!=' ')
                {
                    b += asciistring[i];
                }
                else
                {
                    matascii[j] = Convert.ToInt32(b);
                    j++;
                    b = "";
                }
                    
            }

            string inm = "";
            for (int h = 0; h < matascii.Length;h++ )
            {
                if (matascii[h] != 0)
                {
                    inm = inm + matascii[h] + " ";
                }
                
            }

            MessageBox.Show(inm, "CODIFICACIÓN ASCII", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Byte[] m1 = new byte[matascii.Length];
            int k = 0;
            
            while (k < matascii.Length)
            {
                byte n = Convert.ToByte(matascii[k]);
                m1[k] = n;
                k++;
            }

            String decodedString = ascii.GetString(m1);
            MessageBox.Show(decodedString, "TEXTO DECODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, decodedString);

           
        }

        private void codmor_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> morse = new Dictionary<char, string>()
            {
                {'A' , "10"}, {'B' , "0111"}, {'C' , "0101"}, {'D' , "011"},
                {'E' , "1"}, {'F' , "1101"}, {'G' , "001"}, {'H' , "1111"},
                {'I' , "11"}, {'J' , "1000"}, {'K' , "010"}, {'L' , "1011"},
                {'M' , "00"}, {'N' , "01"}, {'O' , "000"}, {'P' , "1001"},
                {'Q' , "0010"}, {'R' , "101"}, {'S' , "111"}, {'T' , "0"},
                {'U' , "110"}, {'V' , "1110"}, {'W' , "100"}, {'X' , "0110"},
                {'Y' , "0100"}, {'Z' , "0011"}, {'0' , "00000"}, {'1' , "10000"},
                {'2' , "11000"}, {'3' , "11100"}, {'4' , "11110"}, {'5' , "11111"},
                {'6' , "01111"}, {'7' , "00111"}, {'8' , "00011"}, {'9' , "00001"},
                {' ' , "/"}, {'\n' , "//"},

            };

            MessageBox.Show("El texto insertado se convertira\n a mayusculas automaticamente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            open.ShowDialog();
            string rutas = @open.FileName;
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            MessageBox.Show(unicodeString, "TEXTO ORIGINAL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            unicodeString = unicodeString.ToUpper();
            int j = 0;
            string unicodeString2 = "";
            while (j < unicodeString.Length)
            {
                if (unicodeString[j] != '\r')
                    unicodeString2 = unicodeString2 + unicodeString[j];
                j++;
            }



            String codmorse = "";
            int t = unicodeString2.Length;
            string[] arrmorse = new string[t];

            for (int i = 0; i < unicodeString2.Length; i++)
            {
                char c = unicodeString2[i];
                if (morse.ContainsKey(c))
                {
                    codmorse = codmorse + morse[c] + " ";
                    arrmorse[i] = morse[c];
                }
            }

            MessageBox.Show(codmorse, "CODIFICACION MORSE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, codmorse);

        }

        private void decodmor_Click(object sender, EventArgs e)
        {
            Dictionary<string, char> abc = new Dictionary<string, char>()
            {
                {"10" , 'A'}, {"0111" , 'B'}, {"0101" , 'C'}, {"011" , 'D'},
                {"1" , 'E'}, {"1101" , 'F'}, {"001" , 'G'}, {"1111" , 'H'},
                {"11" , 'I'}, {"1000" , 'J'}, {"010" , 'K'}, {"1011" , 'L'},
                {"00" , 'M'}, {"01" , 'N'}, {"000" , 'O'}, {"1001" , 'P'},
                {"0010" , 'Q'}, {"101" , 'R'}, {"111" , 'S'}, {"0" , 'T'},
                {"110" , 'U'}, {"1110" , 'V'}, {"100" , 'W'}, {"0110" , 'X'},
                {"0100" , 'Y'}, {"0011" , 'Z'}, {"00000" , '0'}, {"10000" , '1'},
                {"11000" , '2'}, {"11100" , '3'}, {"11110" , '4'}, {"11111" , '5'},
                {"01111" , '6'}, {"00111" , '7'}, {"00011" , '8'}, {"00001" , '9'},
                {"/", ' '}, {"//", '\n'},{"\0", ' '},

            };

            open.ShowDialog();
            string rutas = @open.FileName;
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            MessageBox.Show(unicodeString, "CODIFICACIÓN MORSE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            int t = unicodeString.Length;
            string[] arrmorse = new string[t];

            string d = "";
            int j = 0;
            for (int i = 0; i < unicodeString.Length; i++)
            {
                if (unicodeString[i] != ' ')
                {
                    d += unicodeString[i];
                }
                else
                {
                    arrmorse[j] = d;
                    j++;
                    d = "";
                }

            }

            int cont2 = 0;
            for (int o = 0; o < arrmorse.Length;o++ )
            {
                if(arrmorse[o]!=null){
                    cont2++;
                }
            }
            
            

            String decodmorse = "";
            for (int i = 0; i < cont2; i++)
            {
                string b = arrmorse[i];
                if (abc.ContainsKey(b))
                    decodmorse = decodmorse + abc[b];
            }

            MessageBox.Show(decodmorse, "TEXTO DECODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            j = 0;
            string unicodeString3 = "";
            while (j < decodmorse.Length)
            {
                if (decodmorse[j] == '\n')
                    unicodeString3 = unicodeString3 + "\r" + decodmorse[j];
                else
                    unicodeString3 = unicodeString3 + decodmorse[j];
                j++;
            }

            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, unicodeString3);
        }

        private void codce_Click(object sender, EventArgs e)
        {
            string abc = "1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

            open.ShowDialog();
            string rutas = @open.FileName;
            string unicodeString = System.IO.File.ReadAllText(@rutas);

            int desplazamiento = 0;
            desplazamiento = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el desplazamiento", "DEZPLAZAMIENTO DE CIFRADO"));

            while (desplazamiento > 14 || desplazamiento < 1)
            {
                MessageBox.Show("Para cifrar el mensaje el desplazamiento debe\nser mayor a 0", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                desplazamiento = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el desplazamiento", "DEZPLAZAMIENTO DE CIFRADO"));
            }



            MessageBox.Show(unicodeString, "TEXTO ORIGINAL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                //recorre caracter a caracter el mensaje a cifrar
                for (int i = 0; i < unicodeString.Length; i++)
                {
                    int posCaracter = getPosABC(unicodeString[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter + desplazamiento;
                        while (pos >= abc.Length)
                        {
                            pos = pos - abc.Length;
                        }
                        //concatena al mensaje cifrado
                        cifrado += abc[pos];
                    }
                    else//si no existe el caracter no se cifra
                    {
                        cifrado += unicodeString[i];
                    }
                }

            }

            MessageBox.Show(cifrado, "CODIFICACIÓN CÉSAR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, cifrado);
        }


        static int getPosABC(char caracter)
        {
            string abc = "1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            for (int i = 0; i < abc.Length; i++)
            {
                if (caracter == abc[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private void decodce_Click(object sender, EventArgs e)
        {
            string abc = "1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

            open.ShowDialog();
            string rutas = @open.FileName;
            string unicodeString = System.IO.File.ReadAllText(@rutas);

            int desplazamiento = 0;
            desplazamiento = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el desplazamiento original", "DEZPLAZAMIENTO DE DESCIFRADO"));


            MessageBox.Show(unicodeString, "CODIFICACIÓN CÉSAR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                //recorre caracter a caracter el mensaje a cifrar
                for (int i = 0; i < unicodeString.Length; i++)
                {
                    int posCaracter = getPosABC(unicodeString[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter - desplazamiento;
                        while (pos >= abc.Length)
                        {
                            pos = pos - abc.Length;
                        }
                        //concatena al mensaje cifrado
                        cifrado += abc[pos];
                    }
                    else//si no existe el caracter no se cifra
                    {
                        cifrado += unicodeString[i];
                    }
                }

            }

            MessageBox.Show(cifrado, "TEXTO DESCIFRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, cifrado);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
