using UnityEngine;

namespace CardGameDemo
{
    [CreateAssetMenu(menuName = "Areas/MyCardsDownWhenHoldingCard")]
    public class MyCardsDownAreaLogic : AreaLogic
    {
        public CardVariable card;
        public CardType creatureType;
        public SO.TransformVariable areaGrid;
        public GameElements.GE_Logic cardDownLogic;

        public override void Execute()
        {
            if(card.value == null)
            {
                return;
            }

            if(card.value.viz.card.cardType == creatureType)
            {
                card.value.transform.SetParent(areaGrid.value.transform);
                card.value.transform.localPosition = Vector3.zero;
                card.value.transform.localEulerAngles = Vector3.zero;
                card.value.transform.localScale = Vector3.one;
                card.value.currentLogic = cardDownLogic;
            }
        }
    }
}