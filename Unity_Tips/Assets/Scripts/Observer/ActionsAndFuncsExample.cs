using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class ActionsAndFuncsExample : MonoBehaviour
    {
        private Action<int> m_Action; // delegate with input parameter

        private Func<int, float> m_Func; // delegate with both input and output parameters


        private void OnEnable() 
        {
            m_Action += MyActionFunction;

            m_Func += MyFuncFunction;
        }

        private void OnDisable() 
        {
            m_Action -= MyActionFunction;

            m_Func -= MyFuncFunction;
        }


        private void MyActionFunction(int myParameter)
        {
            myParameter++;
        }

        private float MyFuncFunction(int myInParameter)
        {
            return myInParameter - 1;
        }
    }
}