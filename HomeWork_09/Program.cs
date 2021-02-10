using HomeWork_09.Models;
using System;

namespace HomeWork_09
{
    class Program
    {
        static void Main(string[] args)
        {
            var flash = new Flash
            {
                SpeedOfUSB = 5,
                StorageCapacity = 8192 //мб
            };
            var dvd = new DVD
            {
                SpeedOfRecording = 6,
                OneSidedType = 5120, //мб
                TwoSidedType = 9216 //мб
            };
            var hdd = new HDD
            {
                SpeedOfUSB = 4,
                CountOfSections = 2,
                CapacityOfSections = 3072 //мб            
            };

            int fileCapacity = 780; //мб
            int totalStorageCapacity = (flash.GetStorageCapacity() + dvd.GetStorageCapacity() + hdd.GetStorageCapacity());
            Console.WriteLine($"Общее количество памяти всех устройств: {totalStorageCapacity}");
            Console.WriteLine("Копирование данных");
            Console.ReadLine();
            
            DateTime dateTime = new DateTime();
            var dateOne = dateTime.Millisecond;

            for (int i = 0, j = fileCapacity; i < totalStorageCapacity / 1024; i++)
            {
                flash.IsDataCopying(fileCapacity);
                dvd.IsDataCopying(fileCapacity);
                hdd.IsDataCopying(fileCapacity);
                fileCapacity += j;
            }

            var dateTwo = dateTime.Millisecond;
            var timeResult = dateOne - dateTwo;
            Console.WriteLine($"Затраченное время на копирование {timeResult} миллисекунд");

            Console.WriteLine(flash.GetAvailableStorageCapacity());
            Console.WriteLine(dvd.GetAvailableStorageCapacity());
            Console.WriteLine(hdd.GetAvailableStorageCapacity());

            int requiredStorageCapacity = 578560; //мб
            int countOfDVDDevices = requiredStorageCapacity / dvd.GetStorageCapacity();
            Console.WriteLine($"Необходимо следующее количество внешних устройств DVD - {countOfDVDDevices}");
            int countOfFlashDevices = requiredStorageCapacity / flash.GetStorageCapacity();
            Console.WriteLine($"Необходимо следующее количество внешних устройств Flash - {countOfFlashDevices}");
            int countOfHDDDevices = requiredStorageCapacity / hdd.GetStorageCapacity();
            Console.WriteLine($"Необходимо следующее количество внешних устройств HDD - {countOfHDDDevices}");
        }
    }
}
