using System.Collections.Generic;
using UnityEngine;

namespace Enemies
{
    public class EnemyCreator : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _prefabs = new List<GameObject>();
        [SerializeField] private EnemyConstructorSO constructorSO;

        public IEnemy CreateEnemy(EnemyType type, Transform parent)
        {
            Enemy enemy = constructorSO.GetEnemy(type);
            GameObject prefab = _prefabs[(int)type];

            GameObject newEnemy = Instantiate(prefab, parent.position, parent.rotation, parent);
            
            if (newEnemy.TryGetComponent(out IEnemy ienemy))
            {
                ienemy.SetEnemy(enemy);
                return ienemy;
            }
            else
            {
                return default;
            }
        }
    }
}