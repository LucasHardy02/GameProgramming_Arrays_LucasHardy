using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace GameProgramming_Arrays_LucasHardy
{
    internal class Program
    {
        static string[] gunNames = { "Pistol", "Assault Rifle", "Shotgun", "SMG", "Minigun" };
        static int[] gunAmmo = new int[5];

        static int[] maxGunAmmo = new int[5];
        static void Main(string[] args)
        {
            gunAmmo[0] = 16;
            gunAmmo[1] = 30;
            gunAmmo[2] = 5;
            gunAmmo[3] = 25;
            gunAmmo[4] = 100;
            
            maxGunAmmo[0] = 16;
            maxGunAmmo[1] = 30;
            maxGunAmmo[2] = 5;
            maxGunAmmo[3] = 25;
            maxGunAmmo[4] = 100;
          








            Console.WriteLine(gunNames[0]);
            Console.WriteLine("has");
            Console.WriteLine(gunAmmo[0]);
            Console.WriteLine("ammo");
            Console.ReadKey();
            Console.Clear();

            

            ShootBullets("Pistol");
            ShootBullets("Pistol");
            ShootBullets("Pistol");



            Console.WriteLine(gunNames[0]);
            Console.WriteLine("has");
            Console.WriteLine(gunAmmo[0]);
            Console.WriteLine("ammo");
            Console.ReadKey();
            Console.Clear();

            ReloadGun("Pistol");

            Console.WriteLine(gunNames[0]);
            Console.WriteLine("has");
            Console.WriteLine(gunAmmo[0]);
            Console.WriteLine("ammo");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"You switch to {gunNames[2]}");
            Console.WriteLine();

            Console.WriteLine(gunNames[2]);
            Console.WriteLine("has");
            Console.WriteLine(gunAmmo[2]);
            Console.WriteLine("ammo");
            Console.ReadKey();
            Console.Clear();

            ShootBullets("Shotgun");

            Console.WriteLine(gunNames[2]);
            Console.WriteLine("has");
            Console.WriteLine(gunAmmo[2]);
            Console.WriteLine("ammo");
            Console.ReadKey();
            Console.Clear();

            ReloadGun("Shotgun");

            Console.WriteLine(gunNames[2]);
            Console.WriteLine("has");
            Console.WriteLine(gunAmmo[2]);
            Console.WriteLine("ammo");
            Console.ReadKey();
            Console.Clear();

        }

        static void ReloadGun(string gunName)
        {
            int indexOfGunName = Array.IndexOf(gunNames, gunName);

            gunAmmo[indexOfGunName] += 1000;

            if (gunAmmo[indexOfGunName] > maxGunAmmo[indexOfGunName])
            {
                gunAmmo[indexOfGunName] = maxGunAmmo[indexOfGunName];
            }

            Console.WriteLine("You reloaded your gun");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

        }

        

        static void ShootBullets(string gunName)
        {
            int indexOfGunName = Array.IndexOf(gunNames, gunName);

            gunAmmo[indexOfGunName] -= 1;

            if (gunAmmo[indexOfGunName] < 0)
            {
                gunAmmo[indexOfGunName] = 0;
            }

            Console.WriteLine("You Shot a bullet.");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();


        }

        static void ShowHUD()
        {
            Console.WriteLine("{0,0}{1,10}", "Current Weapon:", "Weapon Ammo:");
            Console.WriteLine("{0,0}{1,10}", gunName[indexOfGunName], gunAmmo[indexOfGunName]);


        }



    }






}
