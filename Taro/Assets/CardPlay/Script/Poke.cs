using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Taro.CardPlay
{
    public class Poke : MonoBehaviour
    {
        [SerializeField]
        private MeshRenderer text;

        private void Start() 
        {
            text.sortingOrder = 20;
        }

        public void SetContent(int figure, int pattern)
        {
            
        }
    }
}

