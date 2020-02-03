using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CardGameDemo.GameStates
{
    [CreateAssetMenu(menuName = "Actions/OnMouseHoldWithCard")]
    public class MouseHoldWithCard : Action
    {
        public State playerControlState;
        public SO.GameEvent onPlayerControlState;

        public override void Execute(float d)
        {
            bool mouseIsDown = Input.GetMouseButton(0);

            if(!mouseIsDown)
            {
                List<RaycastResult> results = Settings.GetUIObjects();

                foreach(RaycastResult r in results)
                {
                    // Check for dropable areas
                }

                Settings.gameManager.SetState(playerControlState);
                onPlayerControlState.Raise();
            }
        }
    }
}