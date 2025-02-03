using UnityEngine;

public class Daughter : MonoBehaviour, IMovement
{
    private Rigidbody m_Rigidbody;
    [SerializeField] private MovementLogic m_movementLogic;
    [SerializeField] float moveForce = 5.0f;
    [SerializeField] float jumpForce = 5.0f;
    [SerializeField] ManagerClass m_managerClass;

    void Awake()
    {
        m_Rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }
    void Start()
    {
        m_managerClass.AddObserver(this);
    }


    public void Jump()
    {
        Debug.Log("Daughter is jumping");
        m_movementLogic.Jump(jumpForce, m_Rigidbody);
    }

    public void MoveLeft()
    {
        Debug.Log("Daughter is moving left");
        m_movementLogic.MoveLeft(moveForce, m_Rigidbody);
    }

    public void MoveRight()
    {
        Debug.Log("Daughter is moving right");
        m_movementLogic.MoveRight(moveForce, m_Rigidbody);
    }

}
