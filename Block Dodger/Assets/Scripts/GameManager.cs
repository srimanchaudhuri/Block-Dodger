using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float slowTime = 10f;
    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel ()
    {
        //before 1 second

        Time.timeScale = 1f / slowTime;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowTime;

        yield return new WaitForSeconds(1f / slowTime);

        // after 1 second

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowTime;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
