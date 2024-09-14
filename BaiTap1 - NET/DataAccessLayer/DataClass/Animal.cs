using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1___NET.DataAccessLayer.DataClass
{
    public class Animal
    {
        public int AnimalID;
        public string AnimalType;
        public int AnimalAmount;
        public string Sound;

        public Animal()
        {
            AnimalID = 0;
            AnimalAmount = 0;
            AnimalType = Sound = string.Empty;
        }

        public virtual float ProduceMilk() { return 0; }
        public virtual int GiveBirth() { return 0; }
        public virtual void MakeSound() { }
    }
    public class Cow: Animal, IMilkable, IGiveBirth, ISoundable
    {
        private int maxProduceMilk = 20;
        private int maxGiveBirth = 1;
        public override float ProduceMilk()
        {
            Random random = new Random();
            return (float)random.Next(0,maxProduceMilk);
        }
        public override int GiveBirth()
        {
            Random random = new Random();
            return random.Next(0,maxGiveBirth);
        }
        public override void MakeSound()
        {
            Debug.WriteLine(Sound);
        }
    }
    public class Sheep : Animal, IMilkable, IGiveBirth, ISoundable
    {
        private int maxProduceMilk = 15;
        private int maxGiveBirth = 2;
        public override float ProduceMilk()
        {
            Random random = new Random();
            return (float)random.Next(0, maxProduceMilk);
        }
        public override int GiveBirth()
        {
            Random random = new Random();
            return random.Next(0, maxGiveBirth);
        }
        public override void MakeSound()
        {
            Debug.WriteLine(Sound);
        }
    }
    public class Goat : Animal, IMilkable, IGiveBirth, ISoundable
    {
        private int maxProduceMilk = 10;
        private int maxGiveBirth = 3;
        public override float ProduceMilk()
        {
            Random random = new Random();
            return (float)random.Next(0, maxProduceMilk);
        }
        public override int GiveBirth()
        {
            Random random = new Random();
            return random.Next(0, maxGiveBirth);
        }
        public override void MakeSound()
        {
            Debug.WriteLine(Sound);
        }
    }
}
