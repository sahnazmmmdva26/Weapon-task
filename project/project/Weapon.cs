using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Weapon
    {

        private int _bulletcapacity; //gulle kapasitesi
        private int _bulletNumbers; //gulle sayi
        private int _dischargeSecond; // bosalma muddeti
        private string _shootingMode; //modu

        public int Bulletcapacity
        {
            get { return _bulletcapacity; }
            set 
            { 
                if (value>0)
                {

                _bulletcapacity = value; 
                }
                else
                {
                    Console.WriteLine("wrong  Bulletcapacity input");
                    value = Convert.ToInt32(Console.ReadLine());

                }
            }
        }

        public int BulletNumbers
        {
            get { return _bulletNumbers; }
            set
            {
                if (value >=0)
                {

                    _bulletNumbers = value;
                }
                else
                {
                    Console.WriteLine("wrong BulletNumbers input");
                    value = Convert.ToInt32(Console.ReadLine());


                }

            }

        }

        public int DischargeSecond
        {
            get { return _dischargeSecond; }
            set
            {
                if (value > 0)
                {

                    _dischargeSecond = value;
                }
                else
                {
                    Console.WriteLine("wrong DischargeSecond input");
                    value = Convert.ToInt32(Console.ReadLine());

                }

            }
        }

        public string ShootingMode   //təkli və ya avtomatik
        {
            get { return _shootingMode; }
            set 
            { 
                if(!string.IsNullOrEmpty(value))
                {
                value= value.ToLower().Trim();
                    if (value == "auto" || value == "single")
                    {
                        _shootingMode = value;
                    }
                    else
                    {
                        Console.WriteLine("wrong ShootingMode input");
                        value= Console.ReadLine();
                    }
                }
                else { Console.WriteLine("wrong ShootingMode input"); }
                
            }
        }
        public Weapon(int bulletcapacity,int bulletNumbers, int dischargeSecond, string shootingMode)
        {
            BulletNumbers= bulletNumbers;
            DischargeSecond= dischargeSecond;
            ShootingMode= shootingMode;
            Bulletcapacity= bulletcapacity;
        }
        public void Shoot()
        {
            if (BulletNumbers == 0)
            {
                Console.WriteLine("empty charger");
            }
            else { 
            BulletNumbers--;
                Console.WriteLine($"Shooted, number of bullets remaining : {BulletNumbers}"); }
        }
        public void Fire()
        {
            if (BulletNumbers == 0)
            {
                Console.WriteLine("empty charger");
            }
            else
            {
                int secondforone = DischargeSecond / Bulletcapacity;
                int result = secondforone * BulletNumbers;
                BulletNumbers = 0;
                Console.WriteLine($"Shooted, DischargeSecond : {result}");
            }
            
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine($"you need {Bulletcapacity- BulletNumbers} bullet");
        }
        public void Reload()
        {
            BulletNumbers = Bulletcapacity;
        }
      
        public void ChangeFireMode()
        {
            if(_shootingMode=="single")
            {
                _shootingMode = "auto";
            }
            if (_shootingMode == "auto")
            {
                _shootingMode = "single";
            }
            Console.WriteLine($"mode: {_shootingMode}");
        }
    }
}
