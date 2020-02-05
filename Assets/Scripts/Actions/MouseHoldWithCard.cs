using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CardGameDemo.GameStates
{
    [CreateAssetMenu(menuName = "Actions/OnMouseHoldWithCard")]
    public class MouseHoldWithCard : Action
    {
        public CardVariable currentCard;
        public State playerControlState;
        public SO.GameEvent onPlayerControlState;

        public override void Execute(float d)
        {
            bool mouseIsDown = Input.GetMouseButton(0);

            if(!mouseIsDown)
            {
                List<RaycastResult> results = Settings.GetUIObjects();

                foreach (RaycastResult r in results)
                {
                    Area area = r.gameObject.GetComponentInParent<Area>();

                    if(area != null)
                    {
                        area.OnDrop();
                        break;
                    }
                }

                currentCard.value.gameObject.SetActive(true);
                currentCard.value = null;

                Settings.gameManager.SetState(playerControlState);
                onPlayerControlState.Raise();
            }
        }
    }
}