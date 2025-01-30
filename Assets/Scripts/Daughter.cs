using UnityEngine;

public class Daughter : MonoBehaviour, IMovement
{
    private GameObject m_gameObject;
    [SerializeField] SubjectClass m_subjectClass;

    void Start()
    {
        m_subjectClass.AddObserver(this);
    }

    void Awake()
    {
        m_gameObject = GetComponent<GameObject>();
    }
    public void Jump()
    {
        Debug.Log("Daughter is jumping");
    }

    public void MoveLeft()
    {
        Debug.Log("Daughter is moving left");
    }

    public void MoveRight()
    {
        Debug.Log("Daughter is moving right");
    }

}
