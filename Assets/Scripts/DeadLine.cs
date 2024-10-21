using UnityEngine;

public class DeadLine : MonoBehaviour
{
    // 닿았을 경우 죽었다 상태로 바꿔줄 isDead
    [SerializeField] public bool isDead;

    Vector3 rayPoint;

    // 레이저 사이즈
    public float raySize = 10f;

    private void Awake()
    {
        isDead = false;

        rayPoint = transform.position + new Vector3(0,0.1f,0);
    }

    // 레이캐스트
    private void Update()
    {
        Debug.DrawRay(rayPoint, transform.right* raySize,Color.red);
        Debug.DrawRay(rayPoint, -transform.right* raySize,Color.red);
        RaycastHit hit;
        // 좌우로 설정
        if (Physics.Raycast(rayPoint, transform.right, out hit, raySize)
            || Physics.Raycast(rayPoint, -transform.right, out hit, raySize))
        {
            Debug.Log("레이캐스트 충돌확인");
            // 레이캐스트에 몬스터가 닿을 경우
            if (hit.collider.tag == "Monster")
            {
                Debug.Log("충돌체 태그 몬스터");
                // 게임 오버 상태로 변경
                isDead = true;
            }
        }
    }

    
}
