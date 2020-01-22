using UnityEngine;

namespace CardGameDemo.GameStates
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Execute(float d);
    }
}