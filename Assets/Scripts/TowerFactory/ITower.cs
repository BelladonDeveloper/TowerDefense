using UnityEngine;

namespace Towers
{
    public interface ITower
    {
        void Init(Vector3 target);
        void SetTarget(Vector3 target);
        void SetTower(Tower tower);
        Tower GetTower();
    }
}