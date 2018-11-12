using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolPattern.Monsters
{
    abstract class Monster
    {
        public virtual void Attack()
        {
            Console.WriteLine("Attacking " + GetType().Name);
        }

        public virtual void Defeat()
        {
            Console.WriteLine(GetType().Name + " has been defeated");
        }

        public abstract void Loot();

        public void Engage()
        {
            Attack();
            Defeat();
            Loot();
            Console.WriteLine();
        }
    }
}
