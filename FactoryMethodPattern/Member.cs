using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern
{
    /// <summary>
    /// Products 
    /// </summary>
    public abstract class Member
    {
        public abstract void Register();
        public abstract void Notify();
    }
}
