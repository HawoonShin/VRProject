using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // 몬스터가 일정 범위 내에서 랜덤 생성

    // 생성할 몬스터 필요
    [SerializeField] GameObject monsterPrefab;
    // 스폰 범위
    [SerializeField] float spawnRange;

    public void Start()
    {
        // 코루틴 시작
        StartCoroutine(SpawnCoroutine());
    }

    // 생성할 범위 필요(랜덤)
    Vector3 Return_RandomPosition()
    {
        // 랜덤범위
        float rangeX = Random.Range(-spawnRange,spawnRange);
        Vector3 randomPosition = new Vector3(rangeX, 0f, 10f);

        return randomPosition;
    }

    // 일정 시간마다 주기적으로 생성 = 코루틴
    IEnumerator SpawnCoroutine()
    {
        // while문 넣으면 코루틴이 반복 되나..?
        while (true)
        {
            Debug.Log("3초 뒤 스폰합니다.");
            yield return new WaitForSeconds(3f);
            // 스폰
            GameObject monster = Instantiate(monsterPrefab, Return_RandomPosition(), Quaternion.Euler(0,180,0));
        }
    }

}
