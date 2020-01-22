using UnityEngine;
using CardGameDemo.GameStates;

namespace CardGameDemo
{
    public class GameManager : MonoBehaviour
    {
        public State currentState;

        public void Update()
        {
            currentState.Tick(Time.deltaTime);
        }
    }
}