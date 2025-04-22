using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Panel;
    private bool gameStarted = false;

    private void Start()
    {
        Time.timeScale = 0f; 
        Panel.SetActive(true);
       
    }

    private void Update()
    {
        if (!gameStarted && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                StartCoroutine(StartGameAfterDelay(0.3f));
            }
        }
    }

    IEnumerator StartGameAfterDelay(float delay)
    {
        Panel.SetActive(false);
        yield return new WaitForSecondsRealtime(delay); 

        Time.timeScale = 1f;
        gameStarted = true;
    }
}
