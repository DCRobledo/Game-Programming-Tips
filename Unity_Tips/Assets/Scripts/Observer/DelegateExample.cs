using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class DelegateExample : MonoBehaviour
    {
        public delegate void MyDelegate(); // declare the delegate type

        public MyDelegate m_Delegate; // declare an actual delegate


        private void OnEnable() 
        {
            m_Delegate += InvokeDelegate; // subscribe a function to the delegate
        }

        private void OnDisable() 
        {
            m_Delegate -= InvokeDelegate; // unsubscribe a function to the delegate
        }


        private void InvokeDelegate()
        {
            m_Delegate?.Invoke(); // invoke the delegate
        }

        private void MyFunction()
        {
            Debug.Log("Hello World!");
        }
    }
}