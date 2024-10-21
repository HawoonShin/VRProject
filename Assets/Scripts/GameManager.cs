using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState { Ready, Running, GameOver }
    [SerializeField] public GameState curState;

    public bool isStart;
    public bool isOver;
    public bool isDead;

    [Header("UI")]
    [SerializeField] Canvas gameStartUI;
    [SerializeField] Canvas gameOverUI;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject restartButton;

    [Header("GameObject")]
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject deadLine;
    // [SerializeField] GameObject monster;

    [Header("Audio")]
    [SerializeField] AudioSource bgm;
    [SerializeField] AudioSource gameOverSound;

    public void Start()
    {
        curState = GameState.Ready;
        // Ȱ�� ��Ȱ���� ������Ʈ ã��

        // ��ư Ȱ��
        // �׾��� ��Ҵ�
        gameOverUI.enabled = false;

        // ��� ����
        bgm.enabled = true;
        // ���� ���� ���� ����
        gameOverSound.enabled = false;
    }

    private void Update()
    {
        isStart = startButton.GetComponent<ButtonController>().isClick;
        isOver = restartButton.GetComponent<ButtonController>().isClick;
        isDead = deadLine.GetComponent<DeadLine>().isDead;

        // ��ŸƮ ��ư�� ���߸� ���� ����
        if (curState == GameState.Ready
            && isStart == true)
        {
            Debug.Log("���� ����");
            GameStart();
        }

        // ���� ���� �̻� ������ ���� ����
        else if (curState == GameState.Running
             && isDead == true)
        {
            GameOver();
        }

        // ���� ���� UI �� ����� ��ư
        else if (curState == GameState.GameOver
               && isOver == true)
        {
            // ���� �� ���ε�
            SceneManager.LoadScene("MainScene");
        }
    }
    // ����
    public void GameStart()
    {
        curState = GameState.Running;

        // UI ���� or �� Ȱ��ȭ
        gameStartUI.enabled = false;
        // ���� ��ư�� ������ ���Ͱ� Ȱ��ȭ �ȴ� = ������ Ȱ��ȭ
        spawner.SetActive(true);
        // �� ��ħ�� Cube ����
        // GameObject cube = GameObject.Find("Cube"); // �ѹ�ħ ť��
        // cube.SetActive(false);
    }

    public void GameOver()
    {
        // ���� ����
        curState = GameState.GameOver;
        isStart = false;

        // ���� ������ �˷��� UI ���(Ȱ��ȭ)
        gameOverUI.enabled = true;
        // ������ ��Ȱ��ȭ
        spawner.SetActive(false);

        // ��� ����
        bgm.enabled = false;
        // �������� ���
        gameOverSound.enabled = true;
    }

}
