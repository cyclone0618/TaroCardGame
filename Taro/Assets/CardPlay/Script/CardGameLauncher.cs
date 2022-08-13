using System.Runtime.Versioning;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Taro.CardPlay
{
    public class CardGameLauncher : MonoBehaviour
    {
        private LuaEnv luaEnv;

        void Start()
        {
            luaEnv = new LuaEnv();
            luaEnv.DoString("require 'CardPlay.Client.Client'");
        }

        private void OnDestroy()
        {
            luaEnv.DoString("OnDispose()");
            luaEnv.Dispose();
            luaEnv = null;
        }
    }
}

