using UnityEngine;

namespace CardGameDemo
{
    public class Area : MonoBehaviour
    {
        public AreaLogic logic;

        public void OnDrop()
        {
            logic.Execute();
        }
    }
}