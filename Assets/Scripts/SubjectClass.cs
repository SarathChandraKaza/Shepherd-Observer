using UnityEngine;
using UnityEngine.UI;

public class SubjectClass : MonoBehaviour
{
    [SerializeField] ManagerClass m_managerClass;
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

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            OnJumpButtonClicked();
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            OnRightButtonClicked();
        }
        if( Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) 
        { 
            OnLeftButtonClicked();
        }
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
        m_managerClass.MakeAllObserversMoveLeft();
    }

    private void OnRightButtonClicked()
    {
        Debug.Log("Mother is moving right");
        m_movementLogic.MoveRight(moveForce, m_rigidBody);
        m_managerClass.MakeAllObserversMoveRight();
    }
    private void OnJumpButtonClicked()
    {
        Debug.Log("Mother is jumping");
        m_movementLogic.Jump(jumpForce, m_rigidBody);
        m_managerClass.MakeAllObserversJump();
    }

    
}
