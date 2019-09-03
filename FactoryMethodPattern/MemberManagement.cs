using DesignPattern.FactoryMethodPattern.Branches.India;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern
{
    public static class MemberManagement
    {
        public static Member CreateMember(string type)
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
