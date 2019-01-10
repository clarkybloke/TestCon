using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Items;

namespace TestCon
{
    class Program
    
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            
            //create the container builder
            var builder = new ContainerBuilder();
            builder.RegisterType<LogToScreen>().As<ILogger>();
            Container = builder.Build();
            //

            IList<Items.Item> wList = new List<Items.Item>();

            var toLog = Container.Resolve<ILogger>();
//            var toLog = new Logger(new LogToScreen());

            wList.Add(new Items.ShortSword(){Name="Short Sword",Description = "Bronze",Endurance = 100,Strength = 20,Weight = 2, DiceType = 10, DiceNumber = 3});
            wList.Add(new Items.ShortSword(){Name="Short Sword",Description = "Iron",Endurance = 110,Strength = 25,Weight = 2, DiceType = 10, DiceNumber = 3});
            wList.Add(new Items.ShortSword(){Name="Short Sword",Description = "Steel",Endurance = 120,Strength = 30,Weight = 2, DiceType = 10, DiceNumber = 3});

            var itemQuery =
                from thing in wList
                where thing.Endurance > 100
                select thing;

            foreach( Items.Item thing in itemQuery)
            {
                toLog.Write($"This is a test { thing.Name } - {thing.Description}");
            }

            toLog.Write($"This is a test { Items.Dice.Throw(6,3)}");

            new RJCObject<string>(toLog).ShowDetails();

            new RJCObject<int>(toLog).ShowDetails();

            new RJCObject<ShortSword>(toLog).ShowDetails();

            Console.ReadKey();
        }
    }
}
