using System;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    public class Node<T>
    {
        /// <summary>
        /// Gets or sets the value stored in <see cref="Node{T}"/>
        /// </summary>
        public T Value { get; private set; }

        /// <summary>
        /// Gets or sets current node's link to the following <see cref="Node{T}"/>
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value"><see cref="Value"/></param>
        /// <param name="next"><see cref="Next"/></param>
        public Node(T value, Node<T> next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
