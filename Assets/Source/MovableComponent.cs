using UnityEngine;

namespace Assets.Source
{
    [System.Serializable]
    public struct MovableComponent
    {
        public CharacterController characterController;
        public float speed;
    }
}