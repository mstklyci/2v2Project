using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject Menu;
    public GameObject loaderUI;
    public Slider progressSlider;

    public void LoadScene1(int index)
    {
        StartCoroutine(LoadScene_Coroutine(index));
    }

    public IEnumerator LoadScene_Coroutine(int index)
    {
        progressSlider.value = 0;
        loaderUI.SetActive(true);
        Menu.SetActive(false);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        asyncOperation.allowSceneActivation = false;
        float progress = 0f;

        while (!asyncOperation.isDone) 
        { 
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressSlider.value = progress;

            if (progress >= 0.9f)
            {
                progressSlider.value = 1;
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}