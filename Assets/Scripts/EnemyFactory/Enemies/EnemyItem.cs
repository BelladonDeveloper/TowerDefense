using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public abstract class EnemyItem : MonoBehaviour, IEnemy
    {
        public Enemy _enemy;
        public NavMeshAgent _agent;

        public void SetEnemy(Enemy enemy) => _enemy = enemy;
        public Enemy GetEnemy() => _enemy;
        public void SetTarget(Vector3 target) => _agent.SetDestination(target);
        public abstract void Init(Vector3 target);
    }
}