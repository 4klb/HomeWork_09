using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_09.Models
{
    public class Flash : Storage
    {
        public int SpeedOfUSB { get; set; }
        public int StorageCapacity { get; set; }

        private int fileCapacity;

        public override bool IsDataCopying(int file)
        {
            if (file < this.StorageCapacity)
            {
                Console.WriteLine($"Скопированно {file} мегабайт в Flash");
                this.fileCapacity = file;
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно памяти в Flash");
                return false;
            }           
        }

        public override int GetAvailableStorageCapacity()
        {
            int result = this.StorageCapacity - this.fileCapacity;
            Console.WriteLine($"Оставшаяся свободная память на Flash");
            return result;
        }

        public override int GetStorageCapacity()
        {
            return this.StorageCapacity;
        }

        public override string GetTotalInformation()
        {
            return $"Полная информация: скорость {this.SpeedOfUSB}, объем пямяти {this.StorageCapacity}";
        }
    }
}
