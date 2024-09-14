using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1___NET.DataAccessLayer.DataClass
{
    public abstract class Animal
    {
        public int AnimalID;
        public string AnimalType;
        public int AnimalAmount;
        public string Sound;
        public Animal()
        {
            AnimalID = 0;
            AnimalType = string.Empty;
            AnimalAmount = 0;
            Sound = string.Empty;
        }
    }
}
