using DataAccess.Implementation;
using DataAccess.Models;
using System.Security.Principal;

namespace EmployeeManagerConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int repoId = int.Parse(Console.ReadLine());


            var roleRepository = new RoleRepository();

            int actionId = int.Parse(Console.ReadLine());


            if(actionId == 4)
            {
                //todo: enter Role properties fromc console

                Role payload = new Role();


                roleRepository.Add(payload);

            }
        }
    }
}