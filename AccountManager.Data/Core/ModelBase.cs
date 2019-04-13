using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManager.Data.Core
{
    public class ModelBase<T>
    {
        public T Id { get; set; }
    }
}
