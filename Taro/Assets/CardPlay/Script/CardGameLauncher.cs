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
        [CSharpCallLua]
        public delegate void ClickPokeObj(GameObject obj);

        private LuaEnv luaEnv;
        private Collider2D hitCollider;

        private ClickPokeObj clickPokeObj;

        void Start()
        {
            luaEnv = new LuaEnv();
            luaEnv.DoString("require 'CardPlay.Client.Client'");
            clickPokeObj = luaEnv.Global.Get<ClickPokeObj>("ClickPokeObj");
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                hitCollider = null;
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                var hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
                if (hit.collider != null)
                {
                    hitCollider = hit.collider;
                }
            }
            else if(Input.GetMouseButtonUp(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                var hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
                if (hit.collider != null && hitCollider == hit.collider)
                {
                    clickPokeObj?.Invoke(hit.collider.gameObject);
                }
            }
        }

        private void OnDestroy()
        {
            luaEnv.DoString("OnDispose()");
            clickPokeObj = null;
            luaEnv.Dispose();
            luaEnv = null;
        }
    }
}

