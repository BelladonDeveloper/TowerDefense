using System.Collections.Generic;
using UnityEngine;

namespace Towers
{
    public class TowerCreator : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _prefabs = new List<GameObject>();
        [SerializeField] private TowerConstructorSO constructorSO;

        public ITower CreateTower(TowerType type, Vector3 position)
        {
            Tower Tower = constructorSO.GetTower(type);
            GameObject prefab = _prefabs[(int)type];

            GameObject newTower = Instantiate(prefab, position, Quaternion.identity, transform);

            if (newTower.TryGetComponent(out ITower iTower))
            {
                iTower.SetTower(Tower);
                return iTower;
            }
            else
            {
                return default;
            }
        }
    }
}