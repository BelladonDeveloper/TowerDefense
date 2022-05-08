using System;

namespace Enemies
{
    [Serializable]
    public class Enemy
    {
        public EnemyType Type;

        public float Speed;
        public float SpeedRotation;
    }
}