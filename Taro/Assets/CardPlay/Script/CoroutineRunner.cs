using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CoroutineRunner : MonoBehaviour
{

}

public static class CoroutineConfig
{
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp
    {
        get
        {
            return new List<Type>()
            {
                typeof(WaitForSeconds),
                typeof(UnityEngine.Object),
                typeof(UnityEngine.Vector3),
                typeof(UnityEngine.Quaternion),
            };
        }
    }

    [CSharpCallLua]
    public static List<Type> CSharpCallLua
    {
        get
        {
            return new List<Type>()
            {
                typeof(IEnumerator),
                typeof(Button.ButtonClickedEvent),
            };
        }
    }
}
