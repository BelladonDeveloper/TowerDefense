using System.Collections.Generic;
using UnityEngine;

namespace Towers
{
    [CreateAssetMenu(fileName = "TowerConstructorSO", menuName = "ScriptableObject/TowerConstructorSO")]
    public class TowerConstructorSO : ScriptableObject
    {
        [SerializeField] private List<Tower> _enemies = new List<Tower>();

        public Tower GetTower(TowerType type) => _enemies.Find(e => e.Type == type);
    }
}