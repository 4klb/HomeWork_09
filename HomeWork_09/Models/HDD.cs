using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_09.Models
{
    public class HDD : Storage
    {
        public int SpeedOfUSB { get; set; }
        public int CountOfSections { get; set; }
        public int CapacityOfSections { get; set; }

        private int fileCapacity;
        public override bool IsDataCopying(int file)
        {
            if (file < (this.CapacityOfSections * this.CountOfSections))
            {
                Console.WriteLine($"Скопированно {file} мегабайт в HDD");
                this.fileCapacity = file;
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно памяти в HDD");
                return false;
            }
        }

        public override int GetAvailableStorageCapacity()
        {
            int result = (this.CapacityOfSections * this.CountOfSections) - this.fileCapacity;
            Console.WriteLine($"Оставшаяся свободная память на HDD");
            return result;
        }

        public override int GetStorageCapacity()
        {
            return this.CapacityOfSections * this.CountOfSections;
        }

        public override string GetTotalInformation()
        {
            return $"Полная информация: скорость {this.SpeedOfUSB}, количество разделов {this.CountOfSections}, объем разделов {this.CapacityOfSections}";
        }
    }
}
