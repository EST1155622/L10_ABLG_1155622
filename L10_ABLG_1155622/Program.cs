using System;

namespace L10_ABLG_1155622
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string contraseña;
            int intentos = 0; 

            for (int i= 0; i<3; i++)
            {
                Console.WriteLine("Ingresa el nombre de usuario correcto: ");
                usuario = Console.ReadLine();

                Console.WriteLine("Ingresa  la contraseña correcta: ");
                contraseña = Console.ReadLine();

                bool ingreso = Login(usuario, contraseña,ref intentos);
                if (ingreso == true)
                {
                    Console.WriteLine("Verdadero");
                    break;  
                }else
                {
                    if (intentos== 3)
                    {
                        Console.WriteLine("Limite alcanzado");
                    }else
                    {
                        Console.WriteLine("Intentelo de nuevo"); 
                    }
                }

                
            }
         
        }

        static bool Login (string usuario, string contraseña, ref int intentos)
        {
            if (usuario == "usuario1" && contraseña == "asdasd")
            {
                return true; 
            }
            else
            {
                intentos++; 
                return false; 
            }
        }
    }
}
