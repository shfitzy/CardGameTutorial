using UnityEngine;

namespace CardGameDemo
{
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject
    {
        public CardProperties[] properties;
    }
}