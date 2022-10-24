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

            // ammo array
            int[] ammo;
            ammo = new int[5];
            ammo[0] = 6; // pistol
            ammo[1] = 8; // shotgun
            ammo[2] = 30; // rifle
            ammo[3] = 5; // sniper
            ammo[4] = 10; // rocket launcher


            // simulated gameplay
            Console.WriteLine(ammo[weapon]);
            weapon = 3;
            Console.WriteLine(ammo[weapon]);

            Console.ReadKey(true);

        }

        static void ShowCurrentWeaponAmmo()
        {

        }



    }
}
