using UnityEngine;

namespace Enemies
{
    public interface IEnemy
    {
        void Init(Vector3 target);
        void SetTarget(Vector3 target);
        void SetEnemy(Enemy enemy);
        Enemy GetEnemy();
    }
}