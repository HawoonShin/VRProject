using UnityEngine;

public class Bullets : MonoBehaviour
{
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
}
