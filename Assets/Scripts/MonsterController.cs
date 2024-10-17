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
        // �Ŀ� �������� �� ���ΰ� �������� �ɾ��.
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        // �չ�������
        // moveSpeed��ŭ
        // �̵�
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
