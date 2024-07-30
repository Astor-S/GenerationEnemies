using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _spawnFrequency = 2f;
    [SerializeField] private int _minRange = 0;

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
            int spawnIndex = Random.Range(_minRange, _spawnPoints.Length);
            SpawnPoint spawnPoint = _spawnPoints[spawnIndex];

            Enemy newEnemy = Instantiate(_enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
            newEnemy.SetDirection(spawnPoint.GetDirection());

            yield return _wait;
        }
    }
}