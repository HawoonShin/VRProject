using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements;

public class MonsterController : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    private void Awake()
    {
        // 후에 스폰했을 때 주인공 방향으로 걸어간다.
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        // 앞방향으로
        // moveSpeed만큼
        // 이동
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
