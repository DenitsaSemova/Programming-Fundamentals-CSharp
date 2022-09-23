using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace P11DragonArmy___Classes__fromDictionaries___Ex_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //key type
            //dragon - name -> sorted dictionary
            //damage, health, armour

            Dictionary<string, SortedDictionary<string, Dragon>> army = new Dictionary<string, SortedDictionary<string, Dragon>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                string[] data = input.Split();

                string type = data[0];
                string name = data[1];
                string damageStr = data[2];
                string healthStr = data[3];
                string armorStr = data[4];

                //try catch 
                //try - ako ne e int (v sluchaq moje da e null)
                //catch - zadava default value

                int damage;
                try
                {
                    damage = int.Parse(damageStr);
                }
                catch (Exception)
                {

                    damage = 45;
                }

                //2ri variant za proverka

                if (int.TryParse(healthStr, out int health) == false)
                {
                    health = 250;
                }

                //3ti variant za proverka - ternaren operator

                int armor = armorStr == "null" ? 10 : int.Parse(armorStr);

                Dragon dragon = new Dragon()
                {
                    Name = name,
                    Damage = damage,
                    Health = health,
                    Armor = armor,
                };

                if (army.ContainsKey(type) == false)
                {
                    army.Add(type, new SortedDictionary<string, Dragon>());
                }

                // type -> <name, new Dragon>
                //ako go ima go prezapisva, zashtoto ni trqbvat novite stoinosti
                //ako go nqma prosto zapiswa nov drakon

                army[type][dragon.Name] = dragon;

            }

            foreach (var t in army)
            {
                var damageAv = t.Value.Select(d => d.Value.Damage).Average();
                var healthAv = t.Value.Select(d => d.Value.Health).Average();
                var armorAv = t.Value.Select(d => d.Value.Armor).Average();

                Console.WriteLine($"{t.Key}::({damageAv:f2}/{healthAv:f2}/{armorAv:f2})");

                foreach (var d in t.Value.OrderBy(d => d.Value.Name))
                {
                    Console.WriteLine($"-{d.Value.Name} -> damage: {d.Value.Damage}, health: {d.Value.Health}, armor: {d.Value.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; } //= 45; - taka se zadava default value (ako ne zadadem stoinost shte dobavi neq)
        public int Armor { get; set; }
        public int Health { get; set; }
    }
}
