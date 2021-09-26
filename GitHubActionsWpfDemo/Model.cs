using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubActionsWpfDemo
{
    public class Model
    {
        public int FixValue { get; } = 10;

        public int Calc(int x) => x * FixValue;
    }
}
