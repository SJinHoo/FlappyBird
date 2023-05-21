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
            // transform ���� vector3���� �Է��ϰ� ������ vector2 ������ �����ɶ� z���� �ڵ����� ������
            Vector2 spawnPos = transform.position + Vector3.up * Random.Range(-randomRange,randomRange);
            Instantiate(pipeLinePrefab,spawnPos,transform.rotation);
        }
    }
}
