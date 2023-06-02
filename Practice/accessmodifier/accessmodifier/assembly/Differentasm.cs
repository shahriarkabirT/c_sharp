using System;
namespace PrivateProtected.assembly
{
    class DifferentAsm
    {
        public string s0 = "1.public member";
        private protected string s = "2.private protected member";
        internal string s1 = "3.internal member";
        protected string s2 = "4.protected member";
        protected internal string s3 = "5.protected internal member";
        private string s4 = "6.private member";

    }
    public class NonDerivedClass
    {
        public string s0 = "1.public member";
        private protected string s = "2.private protected member";
        internal string s1 = "3.internal member";
        protected string s2 = "4.protected member";
        protected internal string s3 = "5.protected internal member";
        private string s4 = "6.private member";
    }


}

