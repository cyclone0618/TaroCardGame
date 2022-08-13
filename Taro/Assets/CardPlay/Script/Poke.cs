using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Taro.CardPlay
{
    [LuaCallCSharp]
    public class Poke : MonoBehaviour
    {
        private static string[] FigureStr = {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A",
            "Jo",
        };

        private static string[] PatternStr = {
            "♦",
            "♣",
            "♥",
            "♠",
        };

        [SerializeField]
        private MeshRenderer meshRenderer;
        [SerializeField]
        private TextMesh text;

        private void Start() 
        {
            meshRenderer.sortingOrder = 20;
        }

        public void SetContent(int figure, int pattern)
        {
            text.text = $"{FigureStr[figure - 1]} {PatternStr[pattern - 1]}";
        }
    }
}

