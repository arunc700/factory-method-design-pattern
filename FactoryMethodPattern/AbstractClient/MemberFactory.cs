using DesignPattern.FactoryMethodPattern.Branches.India;
using DesignPattern.FactoryMethodPattern.ConcreteClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern.AbstractClient
{
    public static class MemberFactory
    {
        public static MembershipManagement CreateMember(string location)
        {
            MembershipManagement member;
            if (location == "India")
            {
                member = new IndiaMembershipManager();
            }
            else
            {
                member = new UKMembershipManager();
            }


            return member;
        }
    }
}
