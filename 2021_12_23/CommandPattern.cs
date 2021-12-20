using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.test();
        }
    }

    #region Test
    public class Test
    {
        public void test()
        {
            Light light = new Light();

            Command turnOn = new TurnOn(light);
            Command brighter = new Brighter(light);
            Command darker = new Darker(light);

            Invoker invoker = new Invoker();

            invoker.addCommand(turnOn);
            invoker.addCommand(brighter);
            invoker.addCommand(brighter);
            invoker.addCommand(brighter);
            invoker.addCommand(darker);

            invoker.execute();
        }
    }
    #endregion

    #region Invoker
    public class Invoker
    {
        private List<Command> commandList = new List<Command>();

        public void addCommand(Command command)
        {
            commandList.Add(command);
        }

        public void execute()
        {
            foreach(var command in commandList)
            {
                command.execute();
            }
        }
    }
    #endregion

    #region ICommand
    public abstract class Command
    {
        Light light;

        public Command(Light light)
        {
            this.light = light;
        }

        public abstract void execute();
    }
    #endregion

    #region Concrete Command
    public class TurnOn : Command
    {
        Light light;

        public TurnOn(Light light) : base(light)
        {
            this.light = light;
        }

        public override void execute()
        {
            light.TurnOn();
        }
    }

    public class TurnOff : Command
    {
        Light light;

        public TurnOff(Light light) : base(light)
        {
            this.light = light;
        }

        public override void execute()
        {
            light.TurnOff();
        }
    }

    public class Brighter : Command
    {
        Light light;

        public Brighter(Light light) : base(light)
        {
            this.light = light;
        }

        public override void execute()
        {
            light.Brighter();
        }
    }

    public class Darker : Command
    {
        Light light;

        public Darker(Light light) : base(light)
        {
            this.light = light;
        }

        public override void execute()
        {
            light.Darker();
        }
    }
    #endregion

    #region Receiver
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("打開燈");
        }

        public void TurnOff()
        {
            Console.WriteLine("關燈");
        }

        public void Brighter()
        {
            Console.WriteLine("亮度提高");
        }

        public void Darker()
        {
            Console.WriteLine("亮度降低");
        }
    }
    #endregion
}
