using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class EventExample : MonoBehaviour
    {
        public delegate void MyEvent(); // declare the delegate type

        public static event MyEvent m_Event; // declare an actual event


        private void InvokeEvent()
        {
            m_Event?.Invoke(); // invoke the event
        }
    }

    public class EventSubscriber : MonoBehaviour
    {
        private void OnEnable() 
        {
            EventExample.m_Event += MyFunction; // subscribe a function to the event

            // EventExample.m_Event = MyOtherFunction; // this is not allowed
        }

        private void OnDisable() 
        {
            EventExample.m_Event -= MyFunction; // unsubscribe a function to the event
        }

        private void MyFunction()
        {
            Debug.Log("Hello World!");
        }

        private void MyOtherFunction()
        {
            Debug.Log("Bye World!");
        }
    }
}