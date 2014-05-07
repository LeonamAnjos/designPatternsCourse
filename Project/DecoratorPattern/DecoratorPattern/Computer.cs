using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// ConcreteComponent
    /// </summary>
    public class Computer
    {
        //public String descricao()
        public virtual String descricao()
        {
            return "computador";
            //return "computador e um disco";
            //return "computador e um disco e um monitor";
        }
    }

    /// <summary>
    /// Decorator
    /// </summary>
    public abstract class ComputerDecorator : Computer
    {
        private Computer computer;


        protected void SetComputer(Computer c)
        {
            this.computer = c;
        }

        public override String descricao()
        {
            if (computer != null)
            {
                return computer.descricao();
            }
            return String.Empty;
        }
    }

    /// <summary>
    /// ConcreteDecoratorA
    /// </summary>
    public class Disk : ComputerDecorator
    {
        public Disk(Computer c)
        {
            this.SetComputer(c);
        }

        public override String descricao()
        {
            return base.descricao() + " e um disco";
        }
    }


    /// <summary>
    /// ConcreteDecoratorB
    /// </summary>
    public class Monitor : ComputerDecorator
    {
        public Monitor(Computer c)
        {
            this.SetComputer(c);
        }

        public override String descricao()
        {
            return base.descricao() + " e um monitor";
        }

        // Novos Comportamentos
        // Novos estados
    }



}
