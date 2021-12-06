using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammCourse
{
    class BDEnt 
    {
        private static Entities1 _contxt;
        public static Entities1 GetContext()
        {
            if (_contxt == null)
                _contxt = new Entities1();
            return _contxt;
        }
    }
}
