using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemies
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private EnemyCreator _creator;
        [SerializeField] private Transform _mainTargetPosition;

        [SerializeField] private List<Wave> _waves = new List<Wave>();
        [SerializeField] private int _secondsBetweenWaves = 30;

        private WaitForSeconds _wait;

        private void Start()
        {
            _wait = new WaitForSeconds(_secondsBetweenWaves);

            StartCoroutine(SpawnWaves());
        }

        private IEnumerator SpawnWaves()
        {
            for (int i = 0; i < _waves.Count; i++)
            {
                StartWave(i);

                yield return _wait;
            }
        }

        private void StartWave(int number)
        {
            for (int i = 0; i < _waves[number]._types.Count; i++)
            {
                EnemyType enemy = _waves[number]._types[i];

                for (int j = 0; j < _waves[number]._countOfType[i]; j++)
                {
                    IEnemy newEnemy = _creator.CreateEnemy(enemy, transform);
                    newEnemy.Init(_mainTargetPosition.position);
                }
            }
        }
    }
}