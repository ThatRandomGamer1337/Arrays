using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Arrays");
            Console.WriteLine();

            // weapons
            // 0 = pistol
            // 1 = shotgun
            // 2 = rifle
            // 3 = sniper
            // 4 = rocket launcher
            int weapon;
            weapon = 0;

            string[] weaponName;
            weaponName = new string[5];
            weaponName[0] = "Pistol";
            weaponName[1] = "Shotgun";
            weaponName[2] = "Assault Rifle";
            weaponName[3] = "Sniper Rifle";
            weaponName[4] = "Rocket Launcher";

            // ammo array
            int[] ammo;
            ammo = new int[5];
            ammo[0] = 6; // pistol
            ammo[1] = 8; // shotgun
            ammo[2] = 30; // rifle
            ammo[3] = 5; // sniper
            ammo[4] = 10; // rocket launcher


            // simulated gameplay / test
           
            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);
            Console.WriteLine();

            weapon = 1;

            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);
            Console.WriteLine();

            weapon = 2;

            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);
            Console.WriteLine();

            weapon = 3;

            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);
            Console.WriteLine();

            weapon = 4;

            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);
            Console.WriteLine();

            weapon = 0;

            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);
            Console.WriteLine();

            Console.ReadKey(true);

        }


    }
}
