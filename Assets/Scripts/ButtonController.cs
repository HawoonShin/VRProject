using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // 버튼 충돌 감지
    [SerializeField] public bool isClick;

    private void Awake()
    {
        isClick = false;
    }

    public void ClickButton()
    {
        isClick = true;
    }


}
