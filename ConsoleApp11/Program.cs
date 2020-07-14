using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            customStack<int> test = new customStack<int>();
            var eventsub = new EventSubscriber<int>();
            test.pushEvent += eventsub.PushEventHandle;
            test.popEvent += eventsub.PopEventHandle;

            test.Push(5);
            test.Push(10);
            test.Push(15);
            test.Pop();
            test.Pop();
            test.Pop();
            test.Pop();
        }

        public class EventSubscriber<T>
        {
            public void PushEventHandle(object sender, ItemArgs<T> i)
            {
                Console.WriteLine($"Pushed Item on the stack {i.item}");
            }
            public void PopEventHandle(object sender, ItemArgs<T> i)
            {
                Console.WriteLine($"Poped Item out of Stack {i.item}");

            }

        }
        public class customStack<T>
        {
            public event EventHandler<ItemArgs<T>> pushEvent;
            public event EventHandler<ItemArgs<T>> popEvent;

            private List<T> stack = new List<T>();
            public void Push(T item)
            {
                stack.Add(item);
                pushEvent?.Invoke(this,new ItemArgs<T>(item));
            }

            public T Pop()
            {
                if (stack.Count > 0)
                {
                    T item = stack[stack.Count - 1];
                    stack.RemoveAt(stack.Count - 1);
                    popEvent?.Invoke(this, new ItemArgs<T>(item));
                    return item;
                }
                else
                    return default;
             
            }
        }

        public class ItemArgs<T> : EventArgs
        {
            public T item { get; set; }
            public ItemArgs(T item)
            {
                this.item = item;

            }
        }
    }
}
