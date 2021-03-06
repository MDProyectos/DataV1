﻿using System;

namespace Data_V1
{
    class Program
    { 
        //private static string[] ValidCedula = new string[]{"0","1","2","3","4","5","6","7","8","9"};
        static void Main(string[] args)
        {
            string register = "";
            bool pass = true;
            bool pass2 = true;
            do{
                register= AddNewRegister();
                pass = true;
                Console.WriteLine("Grabar(G), Continuar(C), Salir(S)?");
                do{
                    pass2 = true;
                    string option = Console.ReadLine();
                    //option = option.ToLower();
                    switch(option)
                    {
                        case "g":
                            break;
                        case "c":
                            pass = false;
                            break;
                        case "s":
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("La opcion no es valida");
                            pass2 = false;
                            continue;
                    }
                }while(!pass2);
            }while(!pass);

            //string cedula = ReadCedula();
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Mario David\Desktop\ejercicios\Data V1\Save4.txt", true))
            {
                file.WriteLine(register);
            }
            Console.WriteLine("Se ha guardado exitosamente.");
            Console.ReadKey();
        }

        private static string AddNewRegister()
        {
            
            string cedula = ReadCedula();
            string name = ReadName();
            string lastName = ReadLastName();
            int age = ReadAge();
            decimal save = ReadSave();
            string password = ReadPassword();
            
            return cedula + "," + name + "," + lastName + "," + age + "," + save + "," + password;
        }
        
        private static string ReadCedula()
        {
            bool pass = true;
            string cedulaNumber = "";
            do{
                pass = true;
                Console.WriteLine("Escibe tu Cedula:");
               
                cedulaNumber = Console.ReadLine();

                if(cedulaNumber.Length != 11)
                {    
                    pass = false;
                    Console.WriteLine("Tienen que ser 11 numeros");
                    continue;
                }
            }while(!pass);
            return cedulaNumber;
        }
        private static string ReadName()
        {
            bool pass = true;
            string name = "";
            do{
                pass = true;
                Console.WriteLine("Escibe tu nombre:");
               
             name = Console.ReadLine();

                if (name.Length == 0 )
                {    
                    pass = false;
                    Console.WriteLine("No puede dejarlo vacio");
                    continue;
                }
            }while(!pass);
            return name;
            
        }
        private static string ReadLastName()
        {
            bool pass = true;
            string lastName = "";
            do{
                pass = true;
                Console.WriteLine("Escibe tu apelido:");
               
                lastName = Console.ReadLine();

                if (lastName.Length == 0 )
                {    
                    pass = false;
                    Console.WriteLine("No puede dejarlo vacio");
                    continue;
                }
            }while(!pass);
            return lastName;
        }
        private static int ReadAge()
        {
            bool pass = true;
            int age = 0;
            do{
                pass = true;
                Console.WriteLine("Escibe tu edad:");
                try
                {
                    age = Convert.ToInt16(Console.ReadLine());
                }catch
                {
                    pass = false;
                    Console.WriteLine("Tiene que ser un numero entero");
                    continue;
                }
                if (age == 0 )
                {    
                    pass = false;
                    Console.WriteLine("No puede dejarlo vacio");
                    continue;
                }

            }while(!pass);
            return age;
        }
        private static decimal ReadSave()
        {
            bool pass = true;
            decimal save = 0;
            do{
                pass = true;
                Console.WriteLine("Escribe cuanto quieres ahorrar:");
                try
                {
                    save = Convert.ToDecimal(Console.ReadLine());
                }catch
                {
                    pass = false;
                    Console.WriteLine("Tiene que ser un numero, con un maximo de dos decimal");
                    continue;
                }
                if (save == 0 )
                {    
                    pass = false;
                    Console.WriteLine("No puede dejarlo vacio");
                    continue;
                }

            }while(!pass);
            return save;
        }
        private static string ReadPassword()
        {
            bool pass = true;
            string password = "";
            string confirmPassword = "";
            do{
                pass = true;
                Console.WriteLine("Escibe la contraseña:");
               
                password = Console.ReadLine();

                if (password.Length == 0 )
                {    
                    pass = false;
                    Console.WriteLine("No puede dejarlo vacio");
                    continue;
                }
                if (password.Length < 7 )
                {    
                    pass = false;
                    Console.WriteLine("Tiene que ser tener mas de 6 caracteres.");
                    continue;
                }
                Console.WriteLine("Confirme la contraseña:");
               
                confirmPassword = Console.ReadLine();
                if(password != confirmPassword)
                {
                    pass = false;
                    Console.WriteLine("Las contraseñas no son iguales");
                    continue;
                }

            }while(!pass);
            return password;
        }
    }
}
