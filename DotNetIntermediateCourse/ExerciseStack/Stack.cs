using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExerciseStack
{
    public class Stack
    {
       private ArrayList objectStack = new ArrayList();
        public void Push(object obj)
        {
            objectStack.Add(obj);

        }
        public void Pop()
        {
            if(objectStack.Count > 0)
            {
                Console.WriteLine($"Removed element {objectStack[objectStack.Count - 1]}");
                objectStack.RemoveAt(objectStack.Count - 1);

            }
            else
            {
                Console.WriteLine("Stack is Empty Now");
            }
           
        }
        public void ClearStack()
        {
            objectStack.Clear();
        }

        public void show()
        {
            if(objectStack.Count == 0)
            {
                Console.WriteLine("Stack Is Empty");
            }
            else
            {
                foreach (object obj in objectStack)
                {
                    Console.Write(obj + "  ");
                }
            }
           
        }
    }
}
