using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// Represents a variable size last-in-first-out (LIFO) collection of type {T}
    /// </summary>
    /// <remarks><see cref="Stack{T}"/> is implemented a an <see cref="LinkedList{T}"/></remarks>
    public class Stack<T> : IEnumerable<T>
    {
        /// <summary>
        /// 
        /// </summary>
        private Node<T> _top;

        /// <summary>
        /// 
        /// </summary>
        public Stack()
        {
        }

        /// <summary>
        /// Inserts an object at the top of the <see cref="Stack{T}"/>
        /// </summary>
        /// <remarks>
        /// Remember that Stack is a Last-In/First Out (LiFo) data structure, so we keep adding element at the top of the collection.
        /// </remarks>
        /// <example>
        /// 
        /// Push(0)
        ///         -----
        ///         | 0 | _top
        ///         -----
        ///  Push(1)
        ///         -----
        ///         | 1 | _top
        ///         -----
        ///         | 0 |
        ///         -----
        ///  Push(2)
        ///         -----
        ///         | 2 | _top
        ///         -----
        ///         | 1 |
        ///         -----
        ///         | 0 |
        ///         -----
        /// </example>
        /// <param name="value"><see cref="T"/></param>
        public void Push(T value)
        {
            var node = new Node<T>(value);

            if (_top != null)
            {
                node.Next = _top;
                _top = node;

            }
            else
            {
                _top = node;
            }
        }

        /// <summary>
        /// Gets and remove the first element of the <see cref="Stack{T}"/>
        /// </summary>
        /// <example>
        ///  Stack
        ///         -----
        ///         | 2 |
        ///         -----
        ///         | 1 |
        ///         -----
        ///         | 0 |
        ///         -----
        ///  Pop(2)
        ///         -----
        ///         | 1 |
        ///         -----
        ///         | 0 |
        ///         -----
        /// </example>
        /// <returns>If <see cref="Stack{T}"/> is not null retunn the element at the top of the collection: otherwise null</returns>
        public T Pop()
        {
            if (_top != null)
            {
                var result = _top.Value;
                _top = _top.Next;

                return result;
            }

            throw new NullReferenceException("There are no element in the stack");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public T Top()
        {
            if (_top != null)
            {

                return _top.Value;
            }

            throw new NullReferenceException("There are no element in the stack");
        }

        /// <summary>
        /// Clears Stack
        /// </summary>
        public void Clear()
        {
            _top = null;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Display()
        {
            Console.Clear();

            Node<T> current = _top;

            while (current != null)
            {
                Debug.WriteLine(string.Format("| {0} |", current.Value));
                current = current.Next;
            }

            Debug.WriteLine(string.Empty);
        }

        /// <summary>
        /// Exposes and enumerator which supports an iteration over the <see cref="Stack{T}"/> collection
        /// </summary>
        /// <returns><see cref="IEnumerator{T}"/></returns>
        public IEnumerator<T> GetEnumerator()
        {
            while (_top != null)
            {
                yield return _top.Value;
                _top = _top.Next;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns><see cref="IEnumerator"/></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
