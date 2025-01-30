using UnityEngine;
using UnityEngine.UI;

public class ManagerClass : MonoBehaviour
{
    [SerializeField] SubjectClass m_subjectClass;
    [SerializeField] private MovementLogic m_movementLogic;
    private Rigidbody m_rigidBody;
    [SerializeField] float moveForce = 5.0f;
    [SerializeField] float jumpForce = 5.0f;
    [SerializeField] Button moveLeftButton;
    [SerializeField] Button moveRightButton;
    [SerializeField] Button jumpButton;
    void Awake()
    {
        m_rigidBody= this.gameObject.GetComponent<Rigidbody>();
    }

    void Start()
    {
        moveLeftButton.onClick.AddListener(OnLeftButtonClicked);
        moveRightButton.onClick.AddListener(OnRightButtonClicked);
        jumpButton.onClick.AddListener(OnJumpButtonClicked);
    }

    private void OnLeftButtonClicked()
    {
        Debug.Log("Mother is moving left");
        m_movementLogic.MoveLeft(moveForce, m_rigidBody);
        m_subjectClass.MakeAllObserversMoveLeft();
    }

    private void OnRightButtonClicked()
    {
        Debug.Log("Mother is moving right");
        m_movementLogic.MoveRight(moveForce, m_rigidBody);
        m_subjectClass.MakeAllObserversMoveRight();
    }
    private void OnJumpButtonClicked()
    {
        Debug.Log("Mother is jumping");
        m_movementLogic.Jump(jumpForce, m_rigidBody);
        m_subjectClass.MakeAllObserversJump();
    }

    
}
