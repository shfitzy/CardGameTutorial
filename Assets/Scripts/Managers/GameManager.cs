using UnityEngine;
using CardGameDemo.GameStates;

namespace CardGameDemo
{
    public class GameManager : MonoBehaviour
    {
        public PlayerHolder currentPlayer;
        public State currentState;
        public GameObject cardPrefab;

        private void Start()
        {
            Settings.gameManager = this;
            CreateStartingCards();
        }

        void CreateStartingCards()
        {
            ResourcesManager rm = Settings.GetResourcesManager();

            for(int i = 0; i < currentPlayer.startingCards.Length; i++)
            {
                Debug.Log(i);
                GameObject obj = Instantiate(cardPrefab) as GameObject;
                CardViz v = obj.GetComponent<CardViz>();
                v.LoadCard(rm.GetCardInstance(currentPlayer.startingCards[i]));
                CardInstance inst = obj.GetComponent<CardInstance>();
                inst.currentLogic = currentPlayer.handLogic;
                Settings.SetParentForCard(obj.transform, currentPlayer.handGrid.value);
            }
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