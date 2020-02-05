using CardGameDemo.GameElements;
using SO;
using System.Collections.Generic;
using UnityEngine;

namespace CardGameDemo
{
    [CreateAssetMenu(menuName = "Holders/Player Holder")]
    public class PlayerHolder : ScriptableObject
    {
        public string[] startingCards;
        public TransformVariable handGrid;
        public TransformVariable downGrid;

        public GE_Logic handLogic;
        public GE_Logic downLogic;

        [System.NonSerialized]
        public List<CardInstance> handCards = new List<CardInstance>();

        [System.NonSerialized]
        public List<CardInstance> cardsDown = new List<CardInstance>();
    }
}