using UnityEngine;

public class DeadLine : MonoBehaviour
{
    // ����� ��� �׾��� ���·� �ٲ��� isDead
    [SerializeField] public bool isDead;

    Vector3 rayPoint;

    // ������ ������
    public float raySize = 10f;

    private void Awake()
    {
        isDead = false;

        rayPoint = transform.position + new Vector3(0,0.1f,0);
    }

    // ����ĳ��Ʈ
    private void Update()
    {
        Debug.DrawRay(rayPoint, transform.right* raySize,Color.red);
        Debug.DrawRay(rayPoint, -transform.right* raySize,Color.red);
        RaycastHit hit;
        // �¿�� ����
        if (Physics.Raycast(rayPoint, transform.right, out hit, raySize)
            || Physics.Raycast(rayPoint, -transform.right, out hit, raySize))
        {
            Debug.Log("����ĳ��Ʈ �浹Ȯ��");
            // ����ĳ��Ʈ�� ���Ͱ� ���� ���
            if (hit.collider.tag == "Monster")
            {
                Debug.Log("�浹ü �±� ����");
                // ���� ���� ���·� ����
                isDead = true;
            }
        }
    }

    
}
