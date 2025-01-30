using UnityEngine;
using UnityEngine.UI;

public class ManagerClass : MonoBehaviour
{
    [SerializeField] SubjectClass m_subjectClass;
    [SerializeField] Button moveLeftButton;
    [SerializeField] Button moveRightButton;
    [SerializeField] Button jumpButton;

    void Start()
    {
        moveLeftButton.onClick.AddListener(OnLeftButtonClicked);
        moveRightButton.onClick.AddListener(OnRightButtonClicked);
        jumpButton.onClick.AddListener(OnJumpButtonClicked);
    }

    private void OnLeftButtonClicked()
    {
        Debug.Log("Mother is moving left");
        m_subjectClass.MakeAllObserversMoveLeft();
    }

    private void OnRightButtonClicked()
    {
        Debug.Log("Mother is moving right");
        m_subjectClass.MakeAllObserversMoveRight();
    }
    private void OnJumpButtonClicked()
    {
        Debug.Log("Mother is jumping");
        m_subjectClass.MakeAllObserversJump();
    }

    
}
