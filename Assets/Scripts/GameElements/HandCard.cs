using UnityEngine;

namespace CardGameDemo.GameElements
{
    [CreateAssetMenu(menuName = "Game Elements/My Hand Card")]
    public class HandCard : GE_Logic
    {
        public CardVariable currentCard;

        public override void OnClick(CardInstance inst)
        {
            currentCard.Set(inst);
        }

        public override void OnHighlight(CardInstance inst)
        {
            
        }
    }
}
