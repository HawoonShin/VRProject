using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // ���Ͱ� ���� ���� ������ ���� ����

    // ������ ���� �ʿ�
    [SerializeField] GameObject monsterPrefab;
    // ���� ����
    [SerializeField] float spawnRange;

    public void Start()
    {
        // �ڷ�ƾ ����
        StartCoroutine(SpawnCoroutine());
    }

    // ������ ���� �ʿ�(����)
    Vector3 Return_RandomPosition()
    {
        // ��������
        float rangeX = Random.Range(-spawnRange,spawnRange);
        Vector3 randomPosition = new Vector3(rangeX, 0f, 10f);

        return randomPosition;
    }

    // ���� �ð����� �ֱ������� ���� = �ڷ�ƾ
    IEnumerator SpawnCoroutine()
    {
        // while�� ������ �ڷ�ƾ�� �ݺ� �ǳ�..?
        while (true)
        {
            Debug.Log("3�� �� �����մϴ�.");
            yield return new WaitForSeconds(3f);
            // ����
            GameObject monster = Instantiate(monsterPrefab, Return_RandomPosition(), Quaternion.Euler(0,180,0));
        }
    }

}
