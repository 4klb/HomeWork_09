using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_09.Models
{
    public class DVD : Storage
    {
        public int SpeedOfRecording { get; set; }
        public int OneSidedType { get; set; }
        public int TwoSidedType { get; set; }

        private int fileCapacity;

        public override bool IsDataCopying(int file)
        {
            if (file < (this.OneSidedType))
            {
                Console.WriteLine($"Скопированно {file} мегабайт в DVD");
                this.fileCapacity = file;
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно памяти в DVD");
                return false;
            }
        }

        public override int GetAvailableStorageCapacity()
        {
            int result = this.OneSidedType - this.fileCapacity;
            Console.WriteLine($"Оставшаяся свободная память на DVD");
            return result;
        }

        public override int GetStorageCapacity()
        {
            return OneSidedType;
        }

        public override string GetTotalInformation()
        {
            return $"Полная информация: скорость записи {this.SpeedOfRecording}, тип (Односторонний/Двухсторонний) {this.OneSidedType} мб /{this.TwoSidedType} мб";
        }
    }
}

