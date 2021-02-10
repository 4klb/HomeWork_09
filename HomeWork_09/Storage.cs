using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_09
{
    public abstract class Storage
    {
        private string Name { get; set; }
        private string Model { get; set; }

        public abstract int GetStorageCapacity();

        public abstract bool IsDataCopying(int file);

        public abstract int GetAvailableStorageCapacity();

        public abstract string GetTotalInformation();

    }
}
