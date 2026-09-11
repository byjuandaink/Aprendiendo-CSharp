using System;

public class Program
{
    public static void Main(string[] args)
    {
        int saldo = 5000000;
        Console.WriteLine("1. Consultar saldo \n2. Depositar dinero \n3. Retirar dinero \n4. Salir \n");
        
        string respuesta = Console.ReadLine();  
        int respuestaInt = Convert.ToInt32(respuesta);
        int passwordAccount = 1234;
        

        if (respuestaInt == 1)
        {
            Console.WriteLine("Saldo actual: " + saldo);
        }
        else if(respuestaInt == 2)
        {
            Console.WriteLine("Cuanto quiere depositar?");
            string cantidadDepositada = Console.ReadLine();
            int cantidadDepositadaInt = Convert.ToInt32(cantidadDepositada);
            saldo = saldo + cantidadDepositadaInt;
            Console.WriteLine("El salfo final es:" + saldo ); 
            /* public void Sumar(int saldo, int cantidadDepositadaInt )
            {
            return saldo + cantidadDepositada
            Console.WriteLine("Tu saldo final es:" + saldo)
            } */
        }
        else if(respuestaInt == 3)
        {
            Console.WriteLine("Cuanto quiere retirar?");
            string cantidadRetirar = Console.ReadLine();
            int cantidadRetirarInt = Convert.ToInt32(cantidadRetirar);
            saldo = saldo - cantidadRetirarInt; 
            /* public int Restar(int cantidadRetirarInt, int saldo){
                return saldo - cantidadRetirar
                Console.WriteLine("Tu salgo final es:" + saldo)
            } */
        }
        else if(respuestaInt == 4)
        {
            Console.WriteLine("Listo entonces vete a la chingada");
        }



         
    }
}