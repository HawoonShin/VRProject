using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState { Ready, Running, GameOver }
    [SerializeField] public GameState curState;

    public bool isStart;
    public bool isOver;
    public bool isDead;

    [SerializeField] Canvas gameStartUI;
    [SerializeField] Canvas gameOverUI;

    [SerializeField] GameObject startButton;
    [SerializeField] GameObject restartButton;
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject deadLine;

    [SerializeField] GameObject monster;

    public void Start()
    {
        curState = GameState.Ready;
        // 활성 비활성용 오브젝트 찾기

        // 버튼 활성
        // 죽었니 살았니
        gameOverUI.enabled = false;

    }

    private void Update()
    {
        isStart = startButton.GetComponent<ButtonController>().isClick;
        isOver = restartButton.GetComponent<ButtonController>().isClick;
        isDead = deadLine.GetComponent<DeadLine>().isDead;

        // 스타트 버튼을 맞추면 게임 시작
        if (curState == GameState.Ready
            && isStart == true)
        {
            Debug.Log("게임 시작");
            GameStart();
        }

        // 일정 범위 이상 넘으면 게임 오버
        else if (curState == GameState.Running
             && isDead == true)
        {
            GameOver();
        }

        // 게임 오버 UI 에 재시작 버튼
        else if (curState == GameState.GameOver
               && isOver == true)
        {
            // 게임 씬 리로드
            SceneManager.LoadScene("MainScene");
        }
    }
    // 시작
    public void GameStart()
    {
        curState = GameState.Running;

        // UI 삭제 or 비 활성화
        gameStartUI.enabled = false;
        // 시작 버튼을 누르면 몬스터가 활성화 된다 = 스폰너 활성화
        spawner.SetActive(true);
        // 총 받침대 Cube 삭제
        // GameObject cube = GameObject.Find("Cube"); // 총받침 큐브
        // cube.SetActive(false);
    }

    public void GameOver()
    {
        // 게임 오버
        curState = GameState.GameOver;
        isStart = false;

        // 게임 오버를 알려줄 UI 출력(활성화)
        gameOverUI.enabled = true;
        // 스포너 비활성화
        spawner.SetActive(false);
    }

}
