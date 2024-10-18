using UnityEngine;

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

    private void OnCollisionEnter(Collision collision)
    {
            Debug.Log("충돌확인 : 몬스터");
        // 총알과 충돌하였을 경우
        if (collision.gameObject.tag == "Bullet")
        {
            // 몬스터 삭제
            Debug.Log("총알 피격");
            Destroy(gameObject);
        }
    }
}
