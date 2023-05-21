using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLineSpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay;
    [SerializeField] private PipeLine pipeLinePrefab;
    [SerializeField] private float randomRange;
    private void OnEnable()
    {
        spawnRoutine = StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        StopCoroutine(spawnRoutine);
    }

    Coroutine spawnRoutine;
    IEnumerator SpawnRoutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnDelay);
            // transform 에는 vector3값을 입력하고 변수가 vector2 값으로 변형될때 z값이 자동으로 버려짐
            Vector2 spawnPos = transform.position + Vector3.up * Random.Range(-randomRange,randomRange);
            Instantiate(pipeLinePrefab,spawnPos,transform.rotation);
        }
    }
}
