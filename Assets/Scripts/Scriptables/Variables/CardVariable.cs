using UnityEngine;

namespace CardGameDemo
{
    [CreateAssetMenu(menuName = "Variables/Card Variable")]
    public class CardVariable : ScriptableObject
    {
        public CardInstance value;

        public void Set(CardInstance value)
        {
            this.value = value;
        }
    }
}