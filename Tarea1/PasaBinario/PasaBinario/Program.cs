using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1;

    class Program
{ 
        public static void Main(string[] args)
        {
        string frase = "";
        Console.WriteLine("El codigo corresponde a : perro ");
        frase = Console.ReadLine();
        for (int x=0; x <frase.Length;x++)
        {
            Console.WriteLine(frase[x].ToString() + "->" + Convertir(frase[x]));
        }
        Console.ReadKey();
        }
        public static String Convertir (char letra)
        {
        int i = 0, d = 0;
        string bin = "";
        while (true)
        {
            if ((char)i == letra)
                break;
            else
                i++;
        }
        while (i!=0)
        {
            d = i % 2;
            i /= 2;
            bin = d.ToString() + bin;
        }
        return bin;
    }

}

// C# code to implement Vigenere Cipher
/*using System;
using System.Text;

/*class GFG
{

    // This function generates the key in
    // a cyclic manner until it's length isi'nt
    // equal to the length of original text
    /*static String generateKey(String str, String key)
	{
		int x = str.Length;

		for (int i = 0; ; i++)
		{
			if (x == i)
				i = 0;
			if (key.Length == str.Length)
				break;
			key += (key[i]);
		}
		return key;
	}

	// This function returns the encrypted text
	// generated with the help of the key
	static String cipherText(String str, String key)
	{
		String cipher_text = "";

		for (int i = 0; i < str.Length; i++)
		{
			// converting in range 0-25
			int x = (str[i] + key[i]) % 26;

			// convert into alphabets(ASCII)
			x += 'A';

			cipher_text += (char)(x);
		}
		return cipher_text;
	}

	// This function decrypts the encrypted text
	// and returns the original text
	static String originalText(String cipher_text, String key)
	{
		String orig_text = "";

		for (int i = 0; i < cipher_text.Length &&
								i < key.Length; i++)
		{
			// converting in range 0-25
			int x = (cipher_text[i] -
						key[i] + 26) % 26;

			// convert into alphabets(ASCII)
			x += 'A';
			orig_text += (char)(x);
		}
		return orig_text;
	}

	// Driver code
	public static void Main(String[] args)
	{
		String str = "Mi nombre es Steven y estoy en ATI";
		String keyword = "TECCR";

		String key = generateKey(str, keyword);
		String cipher_text = cipherText(str, key);

		Console.WriteLine("Ciphertext : "
			+ cipher_text + "\n");

		Console.WriteLine("Original/Decrypted Text : "
			+ originalText(cipher_text, key));
		Console.ReadKey();
	}
		
}*/

/*using System;

namespace invertirCadena
{
    class Program
    {
        /**
         * Definimos la funcion Mid que devuelve parte de una cadena
         * Recibe:
         *  - una cadena
         *  - la posicion inicial
         *  - la longitud a devolver
         */
  /* public static string Mid(string param, int startIndex, int length)
   {
       string result = param.Substring(startIndex, length);
       return result;
   }

   static void Main(string[] args)
   {
       string frase, invertida = "";
       int posicion = 0;

       Console.Write("Indica el texto telefonico a convertir en texto: ");
       frase = Console.ReadLine();

       posicion = frase.Length;
       while (posicion > 0)
       {
           // en cada ciclo del bucle obtenemos una letra empezando por el
           // final para invertir la cadena.
           invertida = invertida + Mid(frase, posicion - 1, 1);
           posicion = posicion - 1;
       }

       Console.WriteLine("El resultado en texto : " + invertida);
       Console.ReadKey();
   }
}
}
/*using System;

namespace VigenereCipher
{
class VCipher
{
   public string encrypt(string txt, string pw, int d)
   {
       int pwi = 0, tmp;
       string ns = "";
       txt = txt.ToUpper();
       pw = pw.ToUpper();
       foreach (char t in txt)
       {
           if (t < 65) continue;
           tmp = t - 65 + d * (pw[pwi] - 65);
           if (tmp < 0) tmp += 26;
           ns += Convert.ToChar(65 + (tmp % 26));
           if (++pwi == pw.Length) pwi = 0;
       }

       return ns;
   }
};

class Program
{
   static void Main(string[] args)
   {
       VCipher v = new VCipher();

       string s0 = "Cuidado con el estudiante",
              pw = "VIGENERECIPHER";

       Console.WriteLine("Frase: "+ s0 + "\n" + "Pass: " + pw + "\n");
       string s1 = v.encrypt(s0, pw, 1);
       Console.WriteLine("Encriptado: " + s1);
       s1 = v.encrypt(s1, "VIGENERECIPHER", -1);
       Console.WriteLine("Desencriptado: " + s1);
       Console.WriteLine("\nPresione una tecla para continuar...");
       Console.ReadKey();
   }
}
}*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cesar
{
    class Program
    {
        static string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

        public static void Main(string[] args)
        {

            String mensaje = "Mi nombre es Steven";

            //se cifra el mensaje
            string tmp = cifrar(mensaje, 3);


            Console.WriteLine("Mensaje cifrado: \"{0}\" \n\n", tmp);//se muestra en pantalla

            //se descifra el mensaje
            Console.WriteLine("Mensaje descifrado: \"{0}\" \n\n", descifrar(tmp, 3));

            //si se descifra con un desplazamiento diferente al que se uso para cifrar
            //el mensaje sera el equivocado
           // Console.WriteLine("Mensaje descifrado con desplazamiento equivocado:\n \"{0}\"", descifrar(tmp, 3));

            Console.Read();
        }


        static string cifrar(string mensaje, int desplazamiento)
        {
            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                //recorre caracter a caracter el mensaje a cifrar
                for (int i = 0; i < mensaje.Length; i++)
                {
                    int posCaracter = getPosABC(mensaje[i]);
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
                        cifrado += mensaje[i];
                    }
                }

            }
            return cifrado;
        }

        /* 
 * El descifrado cesar es el procedimiento inverso al cifrado
 
        static string descifrar(string mensaje, int desplazamiento)
        {
            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                for (int i = 0; i < mensaje.Length; i++)
                {
                    int posCaracter = getPosABC(mensaje[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter - desplazamiento;
                        while (pos < 0)
                        {
                            pos = pos + abc.Length;
                        }
                        cifrado += abc[pos];
                    }
                    else
                    {
                        cifrado += mensaje[i];
                    }
                }

            }
            return cifrado;
        }

        /* obtiene la posicion del caracter pasado como parametro 
 * en la variable abc que es nuestro abecedario de cifrado/descifrado
 
        static int getPosABC(char caracter)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if (caracter == abc[i])
                {
                    return i;
                }
            }
            return -1;
        }


    }
}*/
