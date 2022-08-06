using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Family
    {
        public abstract string Father();
        public abstract string Mother();
        public abstract string Child();
    }
    internal class Areola : Family
    {
        public override string Father()
        {
            return "Fatherfather";
        }
        public override string Mother()
        {
            return "mothermother";
        }

        public override string Child()
        {
        return "Children";
        }            
    }

}
