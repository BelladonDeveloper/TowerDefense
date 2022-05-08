using UnityEngine;

namespace Towers
{
    public class TowerSpawn : MonoBehaviour
    {
        [SerializeField] private TowerCreator _creator;
        [SerializeField] private TerrainCollider _collider;
        
        private static TowerType _type = TowerType.None;

        public static void OnChangerClick(TowerType type) => _type = type;

        private void OnMouseDown()
        {
            if (_type != TowerType.None)
            {
                Vector3 clickPos = Vector3.zero;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (_collider.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
                    clickPos = hit.point;

                _creator.CreateTower(_type, clickPos);

                _type = TowerType.None;
            }
        }
    }
}