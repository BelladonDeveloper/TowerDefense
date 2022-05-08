using UnityEngine;

namespace Enemies
{
    public class putler : EnemyItem, IEnemy
    {
        public override void Init(Vector3 target)
        {
            print("putler is here");

            _agent.speed = _enemy.Speed;
            _agent.angularSpeed = _enemy.SpeedRotation;

            SetTarget(target);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Tower"))
            {

            }
        }
    }
}