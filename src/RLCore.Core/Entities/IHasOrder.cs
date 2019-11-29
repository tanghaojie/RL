using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Entities
{
    public interface IHasOrder
    {
        long Order { get; set; }
    }
}
