using System.Security.Cryptography.X509Certificates;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            args:
            try
            {
                Console.WriteLine("Capacity:");
                int capacity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("bullets:");
                int bullets = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("discharge:");
                int discharge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("mode:");
                string mode = Console.ReadLine();
                Weapon weapon = new Weapon(capacity, bullets, discharge, mode);

            again:
                Console.WriteLine("0 - menu\n1 - Shoot\n2 - Fire\n3 - Get Remain Bullet Count\n4 - Reload \n5 - Change Fire Mode\n6 - Cancel");
                while (true)
                {
                    Console.WriteLine("Choise: ");
                    int choise = Convert.ToInt16(Console.ReadLine());
                    switch (choise)
                    {
                        case 0:
                            goto again;
                        case 1:
                            weapon.Shoot();
                            break;
                        case 2:
                            weapon.Fire();
                            break;
                        case 3:
                            weapon.GetRemainBulletCount();
                            break;
                        case 4:
                            weapon.Reload();
                            break;
                        case 5:
                            weapon.ChangeFireMode();
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("there isn't option like this");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input\n");
                goto args;
            }
                


            /*
              0 - İnformasiya almaq üçün
              1 - Shoot metodu üçün
              2 - Fire metodu üçün
              3 - GetRemainBulletCount metodu üçün
              4 - Reload metodu üçün
              5 - ChangeFireMode metodu üçün
              6 - Proqramdan dayandırmaq üçün
                   qısayoldur.
            */
        }
    }
}