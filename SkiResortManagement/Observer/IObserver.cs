using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortManagement
{
    public interface IObserver
    {
        void Update(List<string> key);
    }
}
