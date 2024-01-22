using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private EnemyPistol _enemyPistolPrefab;
    [SerializeField] private Transform _container;

    private void Start()
    {
        StartCoroutine(Generate());
    }

    public void ClearContainer()
    {
        foreach (Transform child in _container)
        {
            Destroy(child.gameObject);
        }
    }

    private IEnumerator Generate()
    {
        var wait = new WaitForSeconds(_delay);

        while (enabled)
        {
            yield return wait;
            Spawn();
        }
    }

    private void Spawn()
    {
        int randomIndex = Random.Range(0, _spawnPoint.childCount);
        Vector2 spawnPoint = _spawnPoint.GetChild(randomIndex).position;

        EnemyPistol enemyPistol = Instantiate(_enemyPistolPrefab, spawnPoint, Quaternion.identity);
        enemyPistol.transform.parent = _container;
    }
}
