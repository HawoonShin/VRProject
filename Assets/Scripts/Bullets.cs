using System.Collections;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(DestroyCoroutine());
    }

    // 충돌하면 삭제
    private void OnCollisionEnter(Collision collision)
    {
            Debug.Log("충돌확인 : 총알");
        // 만약 부딪힌 물체가 몬스터일 경우
        if (collision.gameObject.tag == "Monster")
        {
            Debug.Log("몬스터 명중");
            // 총알 삭제
            Destroy(gameObject);
        }
    }

    // 일정 시간 이후 자동 삭제
    IEnumerator DestroyCoroutine()
    {
        Debug.Log("코루틴 시작");
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
