using DesignPattern.FactoryMethodPattern.AbstractClient;
using DesignPattern.FactoryMethodPattern.Branches.India;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern.ConcreteClient
{
    public class IndiaMembershipManager : MembershipManagement
    {
        public override Member CreateMember(string type)
        {
            Member member;
            if (type == "A")
            {
                member = new AnualMembership();
            }
            else if (type == "L")
            {
                member = new LifeTimeMembership();
            }
            else
            {
                member = new TempMembership();
            }

            return member;
        }
    }
}
