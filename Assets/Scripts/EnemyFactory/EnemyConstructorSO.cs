using System.Collections.Generic;
using UnityEngine;

namespace Enemies
{
    [CreateAssetMenu(fileName = "EnemyConstructorSO", menuName = "ScriptableObject/EnemyConstructorSO")]
    public class EnemyConstructorSO : ScriptableObject
    {
        [SerializeField] private List<Enemy> _enemies = new List<Enemy>();

        public Enemy GetEnemy(EnemyType type) => _enemies.Find(e => e.Type == type);
    }
}