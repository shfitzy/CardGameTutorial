using UnityEngine;

namespace CardGameDemo
{
    public class CardInstance : MonoBehaviour, IClickable
    {
        public GameElements.GE_Logic currentLogic;

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