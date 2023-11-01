using System;
using System.Linq;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            Random rnd = new Random();
            return new string(Enumerable.Range(0, 10).OrderBy(r => rnd.Next()).Take(4).Select(i => i.ToString()[0]).ToArray());
        }
    }
}