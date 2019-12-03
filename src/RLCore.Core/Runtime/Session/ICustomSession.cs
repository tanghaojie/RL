using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Runtime.Session
{
    public interface ICustomSession
    {
        string UserEmail { get; }
    }
}
