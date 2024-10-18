using System.Collections;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(DestroyCoroutine());
    }

    // �浹�ϸ� ����
    private void OnCollisionEnter(Collision collision)
    {
            Debug.Log("�浹Ȯ�� : �Ѿ�");
        // ���� �ε��� ��ü�� ������ ���
        if (collision.gameObject.tag == "Monster")
        {
            Debug.Log("���� ����");
            // �Ѿ� ����
            Destroy(gameObject);
        }
    }

    // ���� �ð� ���� �ڵ� ����
    IEnumerator DestroyCoroutine()
    {
        Debug.Log("�ڷ�ƾ ����");
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
