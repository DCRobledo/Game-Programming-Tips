using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils.ExtensionFunctions
{
    public static class TransformFunctions
    {
        public static void Reset(this Transform transform)
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }
    }
}