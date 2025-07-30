using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    private float _spawInterval = 2f;
    [SerializeField]
    private float _radius = 0.5f;
    [SerializeField]
    private UnityEvent<Vector3> _spawCoin;
    [SerializeField]
    private float _positionY = 0f;
    private Coroutine _spawnCoroutine;
    public void Initialize()
    {
        _spawnCoroutine = StartCoroutine(SpawCoins());
    }
    private IEnumerator SpawCoins()
    {
        while (true)
        {
            Vector3 spawnPosition = Random.insideUnitSphere * _radius;
            spawnPosition.y = _positionY;
            _spawCoin?.Invoke(spawnPosition);
            yield return new WaitForSeconds(_spawInterval);
        }
    }
    public void Stop()
    {
        if (_spawnCoroutine != null)
        {
            StopCoroutine(_spawnCoroutine);
            _spawnCoroutine = null;
        }
    }
}
