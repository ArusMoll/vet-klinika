using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp3
{
    
        public class Animal
        {
        public string type,photo;
        public int id;
        public Animal()
            {
            type = "cat";
            }
            public Animal(string p)
            {
            type = p;
            }
        }
        public class Disease
        {
        public string name,photo;
        public int power,id;

        public Disease()
            {
                power = 1;
            }
            public Disease(int p)
            {
            power = p;
            }

        }
    public class Doctor
    {
        public int Bonus,id;
        public string name,photo;
        public Doctor()
        {
              Bonus = 1;
        }
        public Doctor(int p)
        {
                Bonus = p;
        }
    }
    public abstract class AbstractLevel
        {
            public Animal animal;
            public Disease dis;
            public Doctor doc;
            public abstract Animal createAnimal();
            public abstract Disease createDisease();
            public abstract Doctor createDoctor();
            public abstract void Play();
        }

        public class AnimalTypeLevel1 : Animal
        {
            public AnimalTypeLevel1()
            {
            photo = "b8ac584-endangered-animals-tim-flach-5a45fa2a48ab2--700.jpg";
            type = "Микита";
            id = 1;
            }
        }
    public class DiseasePowerLevel1 : Disease
    {
        public  DiseasePowerLevel1()
        {
            photo = "tema.png";
            id = 1;
            name = "disease1";
            power = 100;
        }
    }
    public class  DiseasePowerLevel2 : Disease
    {
        public DiseasePowerLevel2()
        {
            photo = "tema.png";
            id = 2;
            name = "disease2";
            power = 200;
        }
    }
    public class DoctorBonusLevel1 : Doctor
    {
        public DoctorBonusLevel1()
        {
            id=1;
            Bonus = 3;
            name = "grisha";
            photo = "ec6ca868bb41ca06768573b07341f4e4.jpg";
        }
    }
    public class DoctorBonusLevel2 : Doctor
    {
        public DoctorBonusLevel2()
        {
            id = 2;
            Bonus = 1;
            name = "Андрій";
            photo = "oleksandr-medvedenko-109.png";
        }
    }
    public class AnimalTypeLevel2 : Animal
    {
        public AnimalTypeLevel2()
        {
            photo = "f7a75256688a31f1b63e727f96c33c7f_w640.jpg";
            type = "Денис";
            id = 2;
        }
    }
    public class Level1 : AbstractLevel
     {
            public override Animal createAnimal()
            {
                return new AnimalTypeLevel1();
            }
            public override Disease createDisease()
            {
                return new DiseasePowerLevel1();
            }
            public override Doctor createDoctor()
            {
                return new DoctorBonusLevel1();
            }
            public override void Play()
            {
            animal = createAnimal();
            dis = createDisease();
            doc = createDoctor();
            }
    }
    public class Level2 : AbstractLevel
    {
            public override Animal createAnimal()
            {
                return new AnimalTypeLevel2();
            }
            public override Disease createDisease()
            {
                return new DiseasePowerLevel2();
            }
            public override Doctor createDoctor()
            {
                return new DoctorBonusLevel2();
            }
            public override void Play()
            {
            animal = createAnimal();
            dis = createDisease();
            doc = createDoctor();
            }
     }

}


