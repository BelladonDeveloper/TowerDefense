using UnityEngine;

namespace Towers
{
    public abstract class TowerItem : MonoBehaviour, ITower
    {
        public Tower _Tower;

        public void SetTower(Tower Tower) => _Tower = Tower;
        public Tower GetTower() => _Tower;
        public abstract void SetTarget(Vector3 target);
        public abstract void Init(Vector3 target);
    }
}