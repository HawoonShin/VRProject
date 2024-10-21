using UnityEngine;
using System.Collections;

public class MonsterController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    // 플레이어 위치
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

    // 일정 시간 이후 자동 삭제
    IEnumerator DestroyCoroutine()
    {
        Debug.Log("몬스터 코루틴 시작");
        yield return new WaitForSeconds(20f);
        Destroy(gameObject);
    }
}
