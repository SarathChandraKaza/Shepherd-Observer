using UnityEngine;

/// <summary>
/// Class 'Daughter' which implements IMovement.
/// This class defines it's own functionality for the methods Jump, MoveLeft and MoveRight. 
/// Please note that this class doesn't reference the Subject Class directly. It only references the ManagerClass.
/// This class adds itself to the list of observers (declared in ManagerClass) when the "Start" method is executed.
/// </summary>
public class Daughter : MonoBehaviour, IMovement
{
    [SerializeField] ManagerClass m_managerClass;
    [SerializeField] MovementLogic m_movementLogic;

    [SerializeField] float moveForce = 5.0f;
    [SerializeField] float jumpForce = 5.0f;

    private Rigidbody m_Rigidbody;

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
