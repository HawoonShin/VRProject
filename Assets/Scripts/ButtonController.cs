using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // ��ư �浹 ����
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
