using System;
using System.IO;


namespace ArdalisRating
{
    public class FilePolicySource
    {
        public String GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
