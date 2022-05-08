using UnityEngine;

namespace Towers
{
    public class TowerChanger : MonoBehaviour
    {
        [SerializeField] private TowerType _type;

        public void OnChangerClick() => TowerSpawn.OnChangerClick(_type);
    }
}