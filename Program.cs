using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();
            soldiers.Add(new Soldier("Гончаров Даниил", "рядовой", "АК-47М", 5));
            soldiers.Add(new Soldier("Буров Андрей", "рядовой", "АК-47М", 6));
            soldiers.Add(new Soldier("Воробьев Иван", "сержант", "АК-47М", 8));
            soldiers.Add(new Soldier("Ларин Александр", "лейтенант", "АК-47М", 7));
            soldiers.Add(new Soldier("Герасимов Егор", "младший лейтенант", "АК-47М", 9));

            var soldiersId = soldiers.Select(soldier => new
            {
                Name = soldier.Name,
                MilitaryRank = soldier.MilitaryRank,
            }).ToList();

            foreach (var soldierId in soldiersId)
            {
                Console.WriteLine($"Имя: {soldierId.Name}. Звание: {soldierId.MilitaryRank}");
            }
        }
    }


    class Soldier
    {
        public string Name { get; private set; }
        public string MilitaryRank { get; private set; }
        public string Weapon { get; private set; }
        public int TermOfService { get; private set; }

        public Soldier(string name, string militaryRank, string weapon, int termOfService)
        {
            Name = name;
            MilitaryRank = militaryRank;
            Weapon = weapon;
            TermOfService = termOfService;
        }
    }
}
