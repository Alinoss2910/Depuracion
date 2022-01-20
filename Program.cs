using System;
class ArrayExample
{
    static void Main()
    {
        //Escoje una letra de la lista
        char[] letters = { 'a', 'i', 'r', 'a', 'm', ' ', 'l', 'i', 'n', 'a', 'r', 'e', 's' };
        string name = "";// Declara la variable name en cadena vacia
        int[] a = new int[10];
        //bucle for para incrementar i hasta que sea menor que lal longitud de las letras
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];//Le pone a la la variable name letters
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)// Metodo send message que crea una cadena de texto
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}
