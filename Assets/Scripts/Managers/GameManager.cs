using UnityEngine;
using CardGameDemo.GameStates;

namespace CardGameDemo
{
    public class GameManager : MonoBehaviour
    {
        public State currentState;

        private void Start()
        {
            Settings.gameManager = this;
        }

        public void Update()
        {
            currentState.Tick(Time.deltaTime);
        }

        public void SetState(State newState)
        {
            currentState = newState;
        }
    }
}