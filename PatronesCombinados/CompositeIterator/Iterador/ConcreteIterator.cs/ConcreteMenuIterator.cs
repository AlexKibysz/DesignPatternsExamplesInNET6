using PatronesCombinados.CompositeIterator.Composite.Component;
using PatronesCombinados.CompositeIterator.Composite.Composite;
using PatronesCombinados.CompositeIterator.Iterador.AbstractIterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.CompositeIterator.Iterador.ConcreteIterator.cs
{
    // Implementación del Iterator
    public class CompositeMenuIterator : IMenuIterator
    {
        private Stack<IEnumerator<IMenuComponent>> stack;

        public CompositeMenuIterator(IMenu root)
        {
            stack = new Stack<IEnumerator<IMenuComponent>>();
            if (root != null)
            {
                stack.Push(root.getMenuComponents().GetEnumerator());
            }
        }

        public bool HasNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }

            var enumerator = stack.Peek();
            if (!enumerator.MoveNext())
            {
                stack.Pop();
                return HasNext();
            }

            return true;
        }

        public IMenuComponent Next()
        {
            if (!HasNext())
            {
                return null; // Retornamos null en lugar de lanzar una excepción
            }

            var enumerator = stack.Peek();
            var component = enumerator.Current;

            if (component is IMenu menu)
            {
                stack.Push(menu.getMenuComponents().GetEnumerator());
            }

            return component;
        }
    }
}