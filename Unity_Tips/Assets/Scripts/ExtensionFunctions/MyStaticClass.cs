using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils.ExtensionFunctions
{
    public static class MyStaticClass
    {
        public static int MyStaticFunction()
        {
            return 1;
        }

        public static int MyExtensionFunction(this int myInt)
        {
            return 1;
        }
    }
}
