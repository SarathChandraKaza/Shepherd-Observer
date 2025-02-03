using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This script restarts the scene if any one the sheep falls down from the bridge.
/// When any of the sheep's collider hits the collider below the bridge we start the coroutine to restart scene.
/// </summary>
public class RestartScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Restarting scene!");
            StartCoroutine(RestartSceneCoroutine());
        }
    }

    private IEnumerator RestartSceneCoroutine()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(0);
    }
}
