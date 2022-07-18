using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Taro.CardPlay
{
    public class CardGameLauncher : MonoBehaviour
    {
        private LuaEnv luaEnv;

        void Start()
        {
            luaEnv = new LuaEnv();
            luaEnv.DoString("require 'Lua/CardPlay_Main'");
        }

        private void OnDestroy() 
        {
            luaEnv.Dispose();
            luaEnv = null;
        }
    }
}

