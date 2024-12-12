using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public abstract class Decorator<T> : IComponent<T>
    {
        protected readonly IComponent<T> component;

        public Decorator(IComponent<T> component)
        {
            this.component = component;
        }

        public virtual T GetText()
        {
            return component.GetText();
        }
    }
}
