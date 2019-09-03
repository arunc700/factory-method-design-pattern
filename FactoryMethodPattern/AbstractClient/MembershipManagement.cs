using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern.AbstractClient
{
    public abstract class MembershipManagement
    {
        public Member CerateMembership(string type)
        {
            Member member = CreateMember(type);           
            member.Register();
            member.Notify();
            return member;
        }

        public abstract Member CreateMember(string type);
    }
}
