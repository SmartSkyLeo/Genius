using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxySubject : Subject
    {
        RealSubject realsubject = new RealSubject();
        public override void Request()
        {
            if (realsubject == null) {
                realsubject = new RealSubject();
            }
            realsubject.Request();
        }
    }
}
