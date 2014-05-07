using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Strategy
    /// </summary>
    public interface GoAlgorithm
    {
        String go();
    }

    /// <summary>
    /// ConcreteStrategyA
    /// </summary>
    public class GoByDrivingAlgorithm : GoAlgorithm
    {
        public String go()
        {
            return "Estou dirigindo.";
        }
    }

    /// <summary>
    /// ConcreteStrategyB
    /// </summary>
    public class GoByFlyingAlgorithm : GoAlgorithm
    {
        public String go()
        {
            return "Estou voando.";
        }
    }

    /// <summary>
    /// ConcreteStrategyC
    /// </summary>
    public class GoByFlyingFastAlgorithm : GoAlgorithm
    {
        public String go()
        {
            return "Estou voando rápido.";
        }
    }
}
