using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Bank
{
    public class ClassBanco
    {
        public struct Customer
        {
            public int customerid;
            public string name;
        }
        public struct Account
        {
            public int number;
            public int customer;
            public int balance;
        }
        public enum Monedas : int
        {
            GS = 0,
            USD = 1
        }
        public string MenuPrincipal()
        {
            string resp = "";
            Console.Beep();
            Console.Clear();
            Console.WriteLine("SISTEMA BANCARIO ORIENTADO A OBJETOS");
            Console.WriteLine(" ");
            Console.WriteLine("1. Crear un cliente");
            Console.WriteLine("2. Crear una cuenta");
            Console.WriteLine("3. Crear un operacion");
            Console.WriteLine("4. Listar Operaciones");
            Console.WriteLine("99. Salir");
            Console.WriteLine(" ");
            resp = Console.ReadLine();
            return resp;
        }
        static void Main()
        {
            Accounts cuentas = new Accounts();
            ClassCustomers clientes = new ClassCustomers();
            ClassBanco banco = new ClassBanco();
            string respuesta = "";

            while (respuesta != "99")
            {
                respuesta = banco.MenuPrincipal();

                if (respuesta == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Crear un Cliente");
                    Console.WriteLine("Ingrese nombre de cliente : ");
                    clientes.NewCustomer(Console.ReadLine());
                }
                else if (respuesta == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Crear una Cuenta");
                    Console.WriteLine("Ingrese un numero de cuenta");
                }
                else if (respuesta == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Crear una Operacion");
                }
                else if (respuesta == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Listar Operaciones");
                }
            }
        }
        public class Accounts
        {
            List<Account> ListCuentas = new List<Account>();
            // Define Methds
            public void Open()
            {
                // aca va el texto para abrir una cuenta bancaria
            }
            public void Deposit()
            {
                // aca va el codigo para depositar en una cuenta
            }
            public void Withdraw()
            {
                // aca va el codigo para depositar
            }
        }
        public class ClassCustomers
        {
            public List<Customer> clientes = new List<Customer>();
            public void NewCustomer(string CustomerName)
            {
                int cant_clientes = clientes.Count + 1;
                clientes.Add(new Customer() { customerid = cant_clientes, name = CustomerName });
                Console.WriteLine($"***    {cant_clientes.ToString()}  , {CustomerName}");
                Console.ReadKey();
            }
        }
        public class Operations
        {
            //
        }
    }
}