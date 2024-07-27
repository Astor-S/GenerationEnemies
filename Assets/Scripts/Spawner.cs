using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private Transform[] _spawnPoints;
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _spawnFrequency = 2f;

    private Coroutine _coroutine;
    private WaitForSeconds _wait;

    private void Awake()
    {
        _wait = new WaitForSeconds(_spawnFrequency);
    }

    private void Start()
    {
        _coroutine = StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            Enemy newEnemy = Instantiate(_enemyPrefab, spawnPoint.position, Quaternion.identity);
   
            yield return _wait;
        }
    }
}