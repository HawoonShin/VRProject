using UnityEngine;

public class MonsterController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    // �÷��̾� ��ġ
    // [SerializeField] GameObject target;

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
        // �÷��̾��� ��ġ�� �ɾ�ɴϴ�
        //  transform.position = Vector3.MoveTowards(transform.forward,target.transform.position,moveSpeed * Time.deltaTime);
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
}
