using UnityEngine;

namespace CardGameDemo.GameElements
{
    [CreateAssetMenu(menuName = "Game Elements/My Hand Card")]
    public class HandCard : GE_Logic
    {
        public SO.GameEvent onCurrentCardSelected;
        public CardVariable currentCard;
        public GameStates.State holdingCardState;

        public override void OnClick(CardInstance inst)
        {
            currentCard.Set(inst);
            Settings.gameManager.SetState(holdingCardState);
            onCurrentCardSelected.Raise();
        }

        public override void OnHighlight(CardInstance inst)
        {
            
        }
    }
}
