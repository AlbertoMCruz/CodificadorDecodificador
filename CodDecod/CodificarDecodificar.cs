/**
 * @file CodificarDecodificar.cs
 * @version 1.0
 * @brief Menú con distintos tipos de codificación y decodificación
 */
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

/**
 * @brief Codificación para escítala
 */
        private void button2_Click(object sender, EventArgs e)
        {
            /**
             * @brief Abrir archivo de texto
             */
            /**
             * @param open.ShowDialog() Abrir un archivo de texto con OpenFileDialog 
             */
            open.ShowDialog();
            string rutas = @open.FileName;
            /**
             * @param unicodeString Guardamos el archivo en una cadena de texto
             */
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            /**
             * @brief Mostramos un mensaje con la cadena del texto capturado
             */
            MessageBox.Show(unicodeString, "TEXTO ORIGINAL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /**
             * @param caras Variable tipo entero, para guardar la primer dimensión de la escítala 
             */
            int caras = 0;
            caras = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de columnas", "DIMENSIÓN DEL CILINDRO"));
            /**
             * @brief Calcularemos la dimension minima que puede insertar el usuario
             */
            /**
             * @param larcad Variable tipo entero, para determinar el largo de la cadena 
             */
            /**
             * @param fi1 Didivimos el largo de la cadena entre la primera dimensión del usuario 
             */
            int larcad = unicodeString.Length;
            int fi1 = larcad / caras;
            /**
             * @param modd Variable tipo entero, para determinar el módulo del largo de la cadena
             * entre la primera dimensión del usuario
             */
            int modd = larcad % caras;
            /**
             * @brief Aumentamos una fila si el mod de el largo de la cadena y la primera dimension es mayor a 0
             */
            if (modd > 0)
            {
                fi1 = fi1 + 1;
            }

            /**
             * @brief Le pedimos al usuario la segunda dimensión
             * y le mostramos la dimension minima recomendada
             */
            /**
             * @param res1 Dimension 2 ingresada por el usuario 
             */
            int res1 = 0;
            res1 = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de filas\nNUMERO MÍNIMO RECOMENDADO: "+fi1, "DIMENSIÓN DEL CILINDRO"));
            /**
             * @brief Impresion de error si la segunda dimension es menor a la recomendada
             */
            while(res1<fi1){
                MessageBox.Show("El número de filas no puede ser menor al\nmínimo recomendado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                res1 = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de filas\nNUMERO MÍNIMO RECOMENDADO: "+fi1, "DIMENSIÓN DEL CILINDRO"));
            }


            /**
             * @brief Realizamos operaciones para determinar cuantos espacios sobraran
             * en la matriz
             */
            /**
             * @param mul Variable tipo entero, multiplicando las dos dimensiones para obtener el numero 
             * de celdas de la matriz
             */
            int mul = res1 * caras;
            /**
             * @param res2 Variable de tipo entero, que guarda el número de espacios en blanco
             * que quedaran en la matriz
             */
            int res2 = mul - larcad;
            /**
             * @brief Llenamos los espacios con un espacio en blanco
             */
            /**
             * @param spa Variable tipo string, la cual nos guardara el número de espacios
             * que bebemos agregarle
             */
            string spa = "";
            if (res2 > 0)
            {
                for (int h = 0; h < res2; h++)
                {
                    spa = spa + " ";
                }
            }

            /**
             * @brief Agregamos los espacios a nuestra cadena sumando la variable spa
             */
            unicodeString = unicodeString + spa;

            /**
             * @brief Creamos la matriz para insertar la cadena de texto
             */
            /**
             * @param char[,]mat1 Matriz tipo caracter
             */
            char[,] mat1 = new char[res1, caras];
            /**
             * @param k Variable tipo entero, para recorrer la cadena de texto
             */
            int k = 0;
            /**
             * @brief Llenamos la matriz con la cadena de texto
             */
            for (int i = 0; i < res1; i++)
            {
                for (int j = 0; j < caras; j++)
                {
                    mat1[i, j] = unicodeString[k];
                    k++;
                }
            }

            /**
             * @brief Imprimimos el arreglo
             */
            /**
             * @param c Variable tipo string, para concatenar la matriz
             */
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

            /**
             * @brief Concatenamos la codificación escítala
             */
            /**
             * @param e1 Variable tipo string, para concatenar
             */
            string e1 = "";
            for (int j = 0; j < caras; j++)
            {
                for (int i = 0; i < res1; i++)
                {
                    e1 = e1 + mat1[i, j];
                }
            }
            /**
             * @brief Mostramos la escítala en cuadro de dialogo
             */
            MessageBox.Show(e1, "ESCÍTALA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /**
             * @brief Guardamos la codificación en un archivo de texto
             */
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, e1);
        }

/**
 * @brief Decodificación para escítala
 */
        private void button1_Click(object sender, EventArgs e)
        {
            /**
             * @brief Abrimos el archivo de texto con la codificacion escítala
             */
            /**
             * @param open.ShowDialog() Abrir un archivo de texto con OpenFileDialog 
             */
            open.ShowDialog();
            string rutas = @open.FileName;
            /**
             * @param unicodeString Guardamos el archivo en una cadena de texto
             */
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            /**
             * @brief Mostramos un mensaje con la cadena del texto capturado
             */
            MessageBox.Show(unicodeString, "ESCÍTALA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            /**
             * @brief Pedimos el número original de caras para que 
             * el descifrado sea correcto
             */
            /**
             * @param caras Variable tipo entero, para guardar la primer dimensión de la escítala 
             */
            int caras = 0;
            caras = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero original 1", "CARAS DEL CILINDRO"));
            int res1 = 0;
            res1 = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero original 2", "DIMENSIÓN DEL CILINDRO"));
            
            /**
             * @brief Determinamos automaticamente la segunda dimensión de la escítala
             */
            /**
             * @param larcad Variable tipo entero, para determinar el largo de la cadena 
             */
            /**
             * @param fi1 Didivimos el largo de la cadena entre la primera dimensión del usuario 
             */
            int larcad = unicodeString.Length;
           // int res1 = larcad / caras;
            /**
             * @brief Creamos la matriz para descifrar la escítala
             */
            /**
             * @param char[,]mat1 Matriz tipo caracter
             */
            char[,] mat1 = new char[res1, caras];
            /**
             * @param k Variable tipo entero, para recorrer la cadena de texto
             */
            int k = 0;
            /**
             * @brief Llenamos la matriz
             */
            for (int j = 0; j < caras; j++)
            {
                for (int i = 0; i < res1; i++)
                {
                    mat1[i, j] = unicodeString[k];
                    k++;
                }
            }
            /**
             * @brief Impresión de la matriz decodificada
             */
            /**
             * @param c Variable tipo string, para concatenar la matriz
             */
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
            /**
             * @brief Guardamos la decodificación en un archivo de texto
             */
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, c);

        }

/**
 * @brief Codificación ASCII
 */
        private void codascii_Click(object sender, EventArgs e)
        {
            /**
             * @brief Creamos un nuevo objeto de la clase ASCIIEncoding
             */
            ASCIIEncoding ascii = new ASCIIEncoding();
            open.ShowDialog();
            /**
             * @param rutas Variable tipo string en la cual se guardara los datos del archivo
             */
            string rutas = @open.FileName;
            /**
             * @brief Guardamos el archivo en un string
             */
            /**
             * @param string unicodeString Variable tipo string que nos permite guardar el archivo
             */
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            MessageBox.Show(unicodeString, "TEXTO ORIGINAL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            /**
             * @brief Codificamos la cadena a ASCII
             */
            Byte[] encodedBytes = ascii.GetBytes(unicodeString);
            /**
             * @param Byte[]encodedBytes Matriz del tipo Byte donde se guarda la codificación 
             */
            /**
             * @brief Impresion de la codificación
             */
            /**
             * @param String c Variable tipo String nos sirve para concaquetar cadenas de texto  
             */
            String c = "";
            /**
             * @param Byte b Variable tipo Byte que nos sirve para recorrer una matriz tipo Byte uno por uno  
             */
            foreach (Byte b in encodedBytes)
            {
                c = c + b + " ";
            }
            MessageBox.Show(c, "CODIFICACIÓN ASCII", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /**
              * @brief Guardamos la codificación en un archivo de texto
              */

            save.ShowDialog();
            /**
             * @param string guardar Variable que nos permite guardar en un archivo 
             */
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, c);
        }

/**
 * @brief Decodificación ASCII
 */
        private void decodascii_Click(object sender, EventArgs e)
        {
            /**
             * @brief Creamos un nuevo objeto de la clase ASCIIEncoding
             */
            ASCIIEncoding ascii = new ASCIIEncoding();
            /**
             * @brief Abrimos un archivo con codificación ASCII
             */
            open.ShowDialog();
            /**
             * @param rutas Variable tipo string en la cual se guardara los datos del archivo
             */
            string rutas = @open.FileName;
            /**
             * @brief Guardamos el archivo en un string
             */
            string asciistring = System.IO.File.ReadAllText(@rutas);
            /**
             * @brief Creamos una matriz de tipo entero
             */
            /**
             * @param  int[]matascii Una matriz de tipo entero que sera igual al tamaño de los datos del archivo 
             */
            int [] matascii = new int[asciistring.Length];
            /**
             * @param b Variable de tipo string que nos sive para guardar un caracter y convertirlo 
             */
            string b = "";
            /**
             * @param j Variable de tipo entero la cual nos sirve para recorrer la matriz 
             */
            int j=0;
            /**
             * @brief Llenaremos la matriz convirtiendo la cadena en enteros
             */
            for (int i = 0; i < asciistring.Length; i++)
            {
                /**
                 * @brief Omitimos los espacios en blanco
                 */
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
            /**
             * @brief Imprimimos la codificación
             */
            string inm = "";
            /**
             * @param inm Variable de tipo string que nos permite guardar los datos de la matriz   
             */
            for (int h = 0; h < matascii.Length;h++ )
            {
                if (matascii[h] != 0)
                {
                    inm = inm + matascii[h] + " ";
                }
                
            }

            MessageBox.Show(inm, "CODIFICACIÓN ASCII", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            /**
             * @brief Creamos una matriz de tipo byte
             */
            /**
             * @param Byte[]m1 Matriz de tipo Byte donde sera igual a al tamaño de la matriz anterior 
             */
            Byte[] m1 = new byte[matascii.Length];
            int k = 0;
            /**
             * @brief Llenamos la matriz tipo byte con la matriz tipo entero
             */
            /**
             * @param k Variable de tipo entero que nos permite recorrer  
             */
            while (k < matascii.Length)
            {
                byte n = Convert.ToByte(matascii[k]);
                m1[k] = n;
                k++;
            }

            /**
             * @brief Decodificamos la matriz
             */
            String decodedString = ascii.GetString(m1);
            MessageBox.Show(decodedString, "TEXTO DECODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /**
             * @brief Guardamos la decodificación en un archivo de texto
             */
            save.ShowDialog();
            /**
             * @param guardar Variable de tipo string que nos permite guardar nuestro texto decodificado en un archivo   
             */
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, decodedString);

           
        }

/**
 * @brief Codificación morse
 */
        private void codmor_Click(object sender, EventArgs e)
        {
            /**
             * @brief Creamos un diccionario del tipo caracter-cadena
             */
            Dictionary<char, string> morse = new Dictionary<char, string>()
            {
                /**
                 * @brief Asignamos a cada letra y numero un valor
                 */
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
            /**
              * @brief Abrimos un archivo que contenga un texto
              */
            /**
             * @param open.ShowDialog() Abrir un archivo de texto con OpenFileDialog 
             */
            open.ShowDialog();
            string rutas = @open.FileName;
            /**
             * @brief Guardamos el archivo de texto en una cadena
             */
            /**
             * @param unicodeString Guardamos el archivo en una cadena de texto
             */
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            MessageBox.Show(unicodeString, "TEXTO ORIGINAL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            /**
             * @brief Convertimos la cadena a mayúsculas
             */
            unicodeString = unicodeString.ToUpper();
            /**
             * @brief Ciclo para eliminar el \r de nuestra cadena de texto
             */
            /**
            * @param j es una variable de tipo entero: contador para recorrer la cadena de texto
            */
            int j = 0;
            string unicodeString2 = "";
            /**
             * @brief Quitamos los return de la cadena de texto
             */
            while (j < unicodeString.Length)
            {
                if (unicodeString[j] != '\r')
                    unicodeString2 = unicodeString2 + unicodeString[j];
                j++;
            }


            /**
             * @brief se compara la cadena de texto con nuestro diccionario y a la ves sustituye el texto por el codigo morse
             */
            
            
            
            /**
            * @param codmorse es una variable de tipo String. 
            */
            String codmorse = "";
            /**
             * @brief Obtenemos el largo de la cadena
             */
            /**
            * @param t es una variable de tipo int. 
            */
            int t = unicodeString2.Length;
            /**
             * @brief Creamos nueva matriz para guardar la codificación
             */
            /**
            * @param string[] arrmorse es una variable de tipo String: 
            */
            string[]arrmorse = new string[t];
            /**
             * @brief For para llenar la matriz y codificar la cadena de texto
             */
            for (int i = 0; i < unicodeString2.Length; i++)
            {
            /**
             * @brief leemos la cadena en la posición i
             */
                char c = unicodeString2[i];
                /**
                 * @brief Convertimos el caracter obtenido en el valor que definimos en el
                 * diccionario
                 */
                if (morse.ContainsKey(c))
                {
                    /**
                     * @brief Guardamos la codificación en la matriz y un string para imprimirlo
                     */
                    codmorse = codmorse + morse[c] + " ";
                    arrmorse[i] = morse[c];
                }
            }
            /**
             * @brief Impresión de la codificación
             */
            MessageBox.Show(codmorse, "CODIFICACION MORSE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /**
             * @brief Guardamos la codificación en un archivo de texto
             */
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, codmorse);

        }

/**
 * @brief Decodificación morse
 */
        private void decodmor_Click(object sender, EventArgs e)
        {
            /**
             * @brief Creación de diccionario de datos de tipo string - char
             */
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
            /**
             * @brief Abrimos archivo con codificación morse
             */
            /**
             * @param open.ShowDialog() Abrir un archivo de texto con OpenFileDialog 
             */
            open.ShowDialog();
            string rutas = @open.FileName;
            /**
             * @brief Guardamos el archivo de texto en una cadena de texto
             */
            /**
             * @param unicodeString Guardamos el archivo en una cadena de texto
             */
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            MessageBox.Show(unicodeString, "CODIFICACIÓN MORSE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /**
             * @brief Obtenemos el largo de la cadena de texto
             */
            /**
            * @param t es una variable de tipo entero: obtenemos el largo de la cadena de texto
            */
            int t = unicodeString.Length;
            /**
             * @brief Definimos una matriz para guardar la cadena
             */
            string[] arrmorse = new string[t];

            string d = "";
            int j = 0;
            /**
             * @brief Con este ciclo quitaramos los espacios contenidos en la cadena
             */
            for (int i = 0; i < unicodeString.Length; i++)
            {
                if (unicodeString[i] != ' ')
                {
                    d += unicodeString[i];
                }
                else
                {
                    /**
                     * @brief Guardamos el valor obtenido en la posición del arreglo indicado
                     */
                    arrmorse[j] = d;
                    j++;
                    d = "";
                }

            }

            /**
             * @brief Utilizamos este ciclo para verificar si existen
             * null en la cadena
             */
            int cont2 = 0;
            for (int o = 0; o < arrmorse.Length;o++ )
            {
                if(arrmorse[o]!=null){
                    cont2++;
                }
            }


            /**
             * @brief Decodificaremos la cadena
             */
            /**
             * @param decodmorse es una variable de tipo String. 
             */
            String decodmorse = "";
            for (int i = 0; i < cont2; i++)
            {
                /**
                * @brief Comparamos la posición del arreglo con nuestro diccionario
                */
                /**
                 * @param  b es una variable de tipo String. 
                 */
                string b = arrmorse[i];
                if (abc.ContainsKey(b))
                    /**
                    * @brief Guardamos el valor decodificado en un string
                    */
                    decodmorse = decodmorse + abc[b];
            }
            /**
             * @brief Mostramos el texto decodificado
             */
            MessageBox.Show(decodmorse, "TEXTO DECODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            /**
             * @brief Con este algoritmo agregaremos el \r(return) 
             * para que detecte los saltos de linea
             */
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
            /**
             * @brief Guardamos el texto decodificado en un archivo de texto
             */
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, unicodeString3);
        }

/**
 * @brief Codificación César
 */
        private void codce_Click(object sender, EventArgs e)
        {
            /**
             * @brief Agregamos en una cadena los valores que va a detectar la codificación
             */
            /**
             * @param abc es una variable de tipo String
             */
            string abc = "1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            /**
             * @brief Abrimos un archivo de texto
             */
            /**
               * @param open.ShowDialog() Abrir un archivo de texto con OpenFileDialog 
               */
            open.ShowDialog();
            string rutas = @open.FileName;
            /**
             * @brief Lo guardamos en una cadena
             */
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            /**
             * @brief Le pedimos al usuario que ingrese el desplazamiento
             */
            /**
               * @param desplazamiento es una variable de tipo int. 
               */
            /**
              * @param cifrado es una variable de tipo String. 
              */
            int desplazamiento = 0;
            desplazamiento = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el desplazamiento", "DEZPLAZAMIENTO DE CIFRADO"));

            MessageBox.Show(unicodeString, "TEXTO ORIGINAL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
             /**
             * @brief Recorremos el string para cifrarlo
             */
                for (int i = 0; i < unicodeString.Length; i++)
                {
                    /**
                    * @brief Verificamos que el caracter existe en nuestro string abc definido
                    */
                    /**
                      * @param posCaracter es una variable de tipo  Int. 
                      */
                    int posCaracter = getPosABC(unicodeString[i]);
                    
                    if (posCaracter != -1) 
                    {
                        /**
                         * @brief SUMAMOS el desplazamiento al caracter
                         */
                        /**
                           * @param pos es una variable de tipo Int. 
                           */
                        int pos = posCaracter + desplazamiento;
                        while (pos >= abc.Length)
                        {
                            /**
                            * @brief Asignamos el caracter segun el desplazamiento(cifrado)
                            */
                            pos = pos - abc.Length;
                        }
                        /**
                         * @brief Concatenamos el cifrado
                         */
                        cifrado += abc[pos];
                    }
                    else
                    {
                        /**
                         * @brief Si no existe el caracter se pasa al string cifrado de
                         * manera igual
                        */
                        cifrado += unicodeString[i];
                    }
                }

            }
            /**
             * @brief Mostramos el mensaje cifrado
             */
            MessageBox.Show(cifrado, "CODIFICACIÓN CÉSAR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /**
             * @brief Guardamos el mensaje de cifrado en un archivo de teto
             */
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, cifrado);
        }

        /**
         * @brief Se recorre el string que definimos con los valores para cifrar
         */
        static int getPosABC(char caracter)
        {
            string abc = "1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            for (int i = 0; i < abc.Length; i++)
            {
                /**
                * @brief Determinamos la posición del caracter para cifrar
                */
                if (caracter == abc[i])
                {
                    /**
                     * @return i Regresa la posición obtenida del caracter detectado
                     */
                    return i;
                }
            }
            /**
             * @return -1 Regresamos este valor para indicar que el caracter no existe en nuestro diccionario
             */
            return -1;
        }

/**
 * @brief Decodificación César
 */
        private void decodce_Click(object sender, EventArgs e)
        {
            /**
             * @brief Agregamos en una cadena los valores que va a detectar la codificación
             */
            /**
               * @param abc es una variable de tipo String. 
               */
            string abc = "1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            /**
            * @brief Abrimos un archivo de texto
            */
            /**
             * @param open.ShowDialog() Abrir un archivo de texto con OpenFileDialog 
             */
            open.ShowDialog();
            string rutas = @open.FileName;
            /**
             * @brief Lo guardamos en una cadena
             */
            /**
               * @param unicodeString es una variable de tipo String. 
               */
            string unicodeString = System.IO.File.ReadAllText(@rutas);
            
            /**
             * @brief Le pedimos al usuario que ingrese el desplazamiento ORIGINAL
             */
            /**
               * @param dezplazamiento es una variable de tipo Int. 
               */
            int desplazamiento = 0;
            desplazamiento = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el desplazamiento ORIGINAL", "DEZPLAZAMIENTO DE DESCIFRADO"));
            
            MessageBox.Show(unicodeString, "CODIFICACIÓN CÉSAR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                /**
                 * @brief Recorremos el string para descifrarlo
                 */
                for (int i = 0; i < unicodeString.Length; i++)
                {
                    /**
                   * @brief Verificamos que el caracter existe en nuestro string abc definido
                   */
                    int posCaracter = getPosABC(unicodeString[i]);
                    if (posCaracter != -1)
                    {
                        int pos = posCaracter - desplazamiento;
                        while (pos >= abc.Length)
                        {
                        /**
                         * @brief RESTAMOS el desplazamiento al caracter
                         */
                            pos = pos - abc.Length;
                        }
                        /**
                         * @brief Concatenamos el cifrado
                         */
                        cifrado += abc[pos];
                    }
                    else
                    {
                        /**
                         * @brief Si no existe el caracter se pasa al string descifrado de
                         * manera igual
                        */
                        cifrado += unicodeString[i];
                    }
                }

            }
            /**
             * @brief Mostramos el mensaje descifrado
             */
            MessageBox.Show(cifrado, "TEXTO DESCIFRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /**
             * @brief Guardamos el mensaje descifrado en un archivo de texto
             */
            save.ShowDialog();
            string guardar = @save.FileName;
            System.IO.File.WriteAllText(@guardar, cifrado);
        }
/**
 * @brief Salir de la aplicación
 */
        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
