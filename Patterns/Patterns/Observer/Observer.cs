using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public class PhoneDisplay : IObserver 
    {
        public void Update(float temperature) 
        {
            Console.WriteLine($"Phone display: {temperature}°C");
        }
    }
    public class ComputerDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Computer display: {temperature}°C");
        }
    }
}
