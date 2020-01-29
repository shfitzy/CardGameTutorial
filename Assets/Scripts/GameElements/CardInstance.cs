using UnityEngine;

namespace CardGameDemo
{
    public class CardInstance : MonoBehaviour, IClickable
    {
        public CardViz viz;
        public GameElements.GE_Logic currentLogic;

        void Start()
        {
            viz = GetComponent<CardViz>();
        }

        public void OnClick()
        {
            if (currentLogic == null) return;

            currentLogic.OnClick(this);
        }

        public void OnHighlight()
        {
            if (currentLogic == null) return;

            currentLogic.OnHighlight(this);
        }
    }
}