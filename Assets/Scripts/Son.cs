using UnityEngine;

public class Son : MonoBehaviour, IMovement
{
    private GameObject m_gameObject;
    [SerializeField] SubjectClass m_subjectClass;

    void Awake()
    {
        m_gameObject = GetComponent<GameObject>();
    }

    void Start()
    {
        m_subjectClass.AddObserver(this);
    }

    public void Jump()
    {
        Debug.Log("Son is jumping");
    }

    public void MoveLeft()
    {
        Debug.Log("Son is moving left");
    }

    public void MoveRight()
    {
        Debug.Log("Son is moving right");
    }
    
}
