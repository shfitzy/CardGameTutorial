﻿using UnityEngine;

namespace CardGameDemo
{
    public class CardInstance : MonoBehaviour, IClickable
    {
        public void OnClick()
        {
            
        }

        public void OnHighlight()
        {
            Vector3 s = Vector3.one * 2;
            this.transform.localScale = s;
        }
    }
}