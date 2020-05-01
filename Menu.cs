using System;
using System.Collections.Generic;

namespace Examen2_camiones
{
    class Menu
    {
        //Bus Station
        //1) Registro IN,Out
        //2) Exportar/Imprimir camiones
        //3) Stats
        //4) Borrar info
        //9) Salir


        private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;

        List<int> mainMenuOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 9});

            List<Camion> camiones = new List<Camion>();
            List<Camion> statsCamiones = new List<Camion>();


        private void DisplayWelcomeMessage() {
            System.Console.WriteLine("\n¡Bienvenido a la Estacion de Autobuses de Isaac! \n ----------------M E N U -------------");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions() {
            System.Console.WriteLine("1) Ingreso de camion");
            System.Console.WriteLine("2) Salida de camion");
            System.Console.WriteLine("3) Exportar - Imprimir camiones");
            System.Console.WriteLine("4) Stats");
            System.Console.WriteLine("5) Borrar info");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        //fuente: confia en TacoPlox 
        private int RequestOption(List<int> validOptions) {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida...
            while(!isUserInputValid) {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                } catch (System.Exception) {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        //registro Check in
        private void RegistroIn() {

            System.Console.WriteLine("Introduzca NOMBRE: ");
            string nameTyped = System.Console.ReadLine();
            System.Console.WriteLine("Introduzca RUTA: (solo una letra Mayusculas) ");
            string rutaTyped = System.Console.ReadLine();
    
            camiones.Add(new Camion(nameTyped, rutaTyped)); 
            statsCamiones.Add(new Camion(nameTyped, rutaTyped));        
       
                System.Console.WriteLine("Camion agregado\n");

        }

        //registro Check Out
        private void RegistroOut() {
            Camion lastCamion = camiones[0];

            camiones.RemoveAt(0);

            System.Console.WriteLine($"Sale camion con {lastCamion} \n");

        }

        private void Export() {
                //TO DO
        }

        private void Stats() {
            System.Console.Write(statsCamiones.name);    //lo imprime mal, como se llama la lista en maquina

            foreach (Camion stat in statsCamiones)
            {
                Console.WriteLine(stat.name);     //corregir
            }
        }

        private void Clear() {
                //TO DO
        }

         public void Display() {
            int selectedOption = 0;


            while (selectedOption != MAIN_MENU_EXIT_OPTION) {
                 DisplayWelcomeMessage();

                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1: // Ingreso camion
                    RegistroIn();
                        break;
                    case 2: // Salida camion
                    RegistroOut();
                        break;
                    case 3: // Exportar Imprimir camiones
                    Export();
                        break;
                    case 4: // Stats
                    Stats();
                        break;
                    case 5: // Clear
                    Clear();
                        break;
                    case 9: // Salir
                    //Exit();
                    selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                        
                    // default:
                }
            }

            //DisplayByeMessage();

        }

    }
}