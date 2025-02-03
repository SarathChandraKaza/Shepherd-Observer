using UnityEngine;

/// <summary>
/// This script deals with the movement logic. Instead of directly coupling the logic, 
/// it is better to have it as a seperarte class.
/// </summary>
public class MovementLogic : MonoBehaviour
{
    public void MoveLeft(float moveForce, Rigidbody rb)
    {
        rb.AddForce(Vector3.left * moveForce, ForceMode.Impulse);
    }

    public void MoveRight(float moveForce, Rigidbody rb)
    {
        rb.AddForce(Vector3.right * moveForce, ForceMode.Impulse);
    }

    public void Jump(float jumpForce, Rigidbody rb)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
