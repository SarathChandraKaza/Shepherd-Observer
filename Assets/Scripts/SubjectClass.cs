using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class SubjectClass : MonoBehaviour
{
    private List<IMovement> m_MovementList = new List<IMovement>();
    
    public void AddObserver(IMovement observer)
    {
        m_MovementList.Add(observer);
    }

    public void MakeAllObserversMoveRight()
    {
        foreach(var observer in m_MovementList)
        {
            observer.MoveRight();
        }
    }

    public void MakeAllObserversMoveLeft()
    {
        foreach (var observer in m_MovementList)
        {
            observer.MoveLeft();
        }
    }
    public void MakeAllObserversJump()
    {
        foreach (var observer in m_MovementList)
        {
            observer.Jump();
        }
    }
}
