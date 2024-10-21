using UnityEngine;
using System.Collections;

public class MonsterController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    // �÷��̾� ��ġ
    // [SerializeField] GameObject target;

    private void Awake()
    {
        StartCoroutine(DestroyCoroutine());
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        // �̵�
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹Ȯ�� : ����");
        // �Ѿ˰� �浹�Ͽ��� ���
        if (collision.gameObject.tag == "Bullet")
        {
            // ���� ����
            Debug.Log("�Ѿ� �ǰ�");
            Destroy(gameObject);
        }
    }

    // ���� �ð� ���� �ڵ� ����
    IEnumerator DestroyCoroutine()
    {
        Debug.Log("���� �ڷ�ƾ ����");
        yield return new WaitForSeconds(20f);
        Destroy(gameObject);
    }
}
