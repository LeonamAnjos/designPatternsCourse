using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public abstract class Vehicle
    {
        private GoAlgorithm goAlgorithm;
        
        protected GoAlgorithm GoAlgorithm 
        {
            set 
            { 
                this.goAlgorithm = value; 
            }
        }

        public String go()
        {
            //return "Estou dirigindo.";

            String v = String.Empty;

            if (goAlgorithm != null)
            {
                v = goAlgorithm.go();
            }

            return v;
        }
    }

    /// <summary>
    /// Context
    /// </summary>
    public class StreetRacer : Vehicle
    {
        public StreetRacer()
        {
            GoAlgorithm = new GoByDrivingAlgorithm();
        }
    }

    /// <summary>
    /// Context
    /// </summary>
    public class FormulaOne : Vehicle
    {
        public FormulaOne()
        {
            GoAlgorithm = new GoByDrivingAlgorithm();
        }
    }

    /// <summary>
    /// Context
    /// </summary>
    public class Helicopter : Vehicle
    {
        //new public String go()
        //{
        //    return "Estou voando.";
        //}

        public Helicopter()
        {
            GoAlgorithm = new GoByFlyingAlgorithm();
        }

    }

    /// <summary>
    /// Context
    /// </summary>
    public class Jet : Vehicle
    {
        //new public String go()
        //{
        //    return "Estou voando rápido.";
        //}

        public Jet()
        {
            GoAlgorithm = new GoByFlyingFastAlgorithm();
        }
    }

}
