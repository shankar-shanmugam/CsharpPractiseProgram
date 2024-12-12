using System;
using System.Collections.Generic;
using System.Text;

namespace oopsDemo
{
    abstract class Items
    {
        public string title { set; get; }

        public abstract void DisplayInfo();
    }
}
