using System;


namespace ElSoldado
{
    internal class Soldado//internal es que todas las clases en el proyecto pueden acceder a el
    {
        private Arma arma;
        public void RecogerArma(Arma arma)
        {
            if (this.arma != null)
            {
                Console.WriteLine("EL SOLDADO TIENE UN ARMA ENCIMA, PRIMERO DEJE EL ARMA PARA AGARRAR OTRA");
            }
            else
            {
                Console.WriteLine("HA RECOGIDO UN ARMA NUEVA");
            }
        }
        public void DejarArma()
        {
            if (this.arma != null)
            {
                arma = null;
                Console.WriteLine("ha dejado el arma que poseia");
            }
            else
            {
                Console.WriteLine("parece que el soldado no tiene un arma consigo");
            }
        }
        public void DispararArma()
        {
            if (this.arma != null)//si arma es diferente a nada
            {
                string sonidoDisparo = arma.Disparar();
                Console.WriteLine("el arma hace "+sonidoDisparo);
            }
            else
            {
                Console.WriteLine("parece que el soldado no tiene ningun arma en sus manos");
            }
        }
        public void VerArma()
        {
            if (this.arma != null)
            {
                Console.WriteLine(arma.Nombre);
            }
            else
            {
                Console.WriteLine("parece que el soldado no tiene nigun arma encima");
            }
        }

            
        
    }
}
