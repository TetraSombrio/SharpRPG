using System;
namespace mob
{
    class mob
    {   
       public string name;
        public int hp;
        public int attk;
        public int xp;
        public virtual void creator()
        {
       
        }
    }
    class elf:mob
    {   
        string[] narr = new string[4] {"Эльф - бомж","Эльф - вор","Эльф - барыга","Эльф - гондон" };
      
        public override void creator()
        {
            base.creator();
           Random random = new Random();
            elf elf = new elf();
            elf.name = narr[random.Next(0, 3)];
            elf.hp = random.Next(10,70);
            elf.attk = random.Next();
            elf.xp = random.Next();
            Console.WriteLine($"\nПеред вами {elf.name}\nЗдоровье противника: {elf.hp}\n");
        }

    }
   class program
    {
        static void Main()
        {   elf elf =new elf();
            elf.creator();
        }
    }
   



}