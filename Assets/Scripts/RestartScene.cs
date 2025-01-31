using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("One of the sheep fell down. Restarting scene!");
            StartCoroutine(RestartSceneCoroutine());
        }
    }

    private IEnumerator RestartSceneCoroutine()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(0);
    }
}
