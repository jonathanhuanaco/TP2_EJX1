using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Menu
    {
        Rifle _rifle;
        Revolver _revolver;
        Escopeta _escopeta;
        Soldado _soldado;
        public Menu(ref Soldado soldado,ref Rifle rifle,ref Escopeta escopeta,ref Revolver revolver)
        {
            _soldado = soldado;
            _rifle = rifle;
            _escopeta = escopeta;
            _revolver = revolver;

            mostrarMenuPrincipal();

        }
        private void mostrarMenuPrincipal()
        {
            
            string opcion;
            bool salir = false;
            do
            {
                Console.WriteLine("-==Bienvenido al campo de entrenamiento, Soldado ==-");
                Console.WriteLine("¿que desea hacer?");
                Console.WriteLine("(presione el numero correspondiente a la opcion del menu)");
                Console.WriteLine("1- Recoger arma.");
                Console.WriteLine("2- Dejar arma.");
                Console.WriteLine("3- Disparar.");
                Console.WriteLine("4- Ver arma en uso.");
                Console.WriteLine("5- Salir");
                opcion = Console.ReadLine();
                SeleccionarAccion(opcion, ref salir);
            } while (salir == false);
        }
        private void SeleccionarAccion(String opcion,ref bool salir)
        {
            switch (opcion)
            {
                case"1":
                    MenuRecogerArma();
                    salir = false;
                    break;
                case "2":
                    _soldado.DejarArma();
                    Console.ReadKey();
                    salir = false;
                    break;
                case "3":
                    _soldado.DispararArma();
                    Console.ReadKey();
                    salir = false;
                    break;
                case "4":
                    _soldado.VerArma();
                    Console.ReadKey();
                    salir = false;
                    break;
                case "5":
                    Environment.Exit(2);
                    break;
                default:
                    Console.WriteLine("la opcion ingresada es incalida, por favor reintente");
                    Console.ReadKey();
                    salir = false;
                    break;

            }
        }
        private void MenuRecogerArma()
        {
            string opcion;
            bool opcionValida = false;
            do {
                Console.WriteLine("Por favor, escoja el arma que desea utilizar: ");
                Console.WriteLine("1- Revolver");
                Console.WriteLine("2- Rifle");
                Console.WriteLine("3- Escopeta");
                Console.WriteLine("4- Volver atras");
                opcion = Console.ReadLine();
                SeleccionarArma(opcion, ref opcionValida);
            } while(opcionValida==false);
        }
        private void SeleccionarArma(string opcion,ref bool opcionValida)
        {
            switch (opcion)
            {
                case "1":
                    _soldado.RecogerArma(_revolver);
                    opcionValida = true;
                    Console.ReadKey();
                    break;
                case "2":
                    _soldado.RecogerArma(_rifle);
                    opcionValida = true;
                    Console.ReadKey();
                    break;
                case"3":
                    _soldado.RecogerArma(_escopeta);
                    opcionValida = true;
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("EL SOLDADO NO RECOGIO NINGUN ARMA, VOLVIENDO AL MENU PRINCIPAL...");
                    Console.ReadKey();
                    opcionValida = true;
                    break;
                default:Console.WriteLine("la opcion ingresada es incorrecta,reintente.");
                    Console.ReadKey();
                    opcionValida = false;
                    break;
            }
        }
    }
}
