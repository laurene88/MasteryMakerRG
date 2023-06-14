using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public Animator fadeTransition;
    public float transitionTime = 1.1f;


    // Changes scene and calls transition animation coroutine
    public void changeScene(int levelIndex)
    {
        StartCoroutine(changeSceneAnim(levelIndex));
        //SceneManager.LoadScene(sceneIndex);
    }

    // Coroutine that runs fade transition animation, and loads new scene after it finishes.
    IEnumerator changeSceneAnim(int levelIndex)
    {
        //play animation
        fadeTransition.SetTrigger("fadeOutTrigger");
        //wait for it to stop
        yield return new WaitForSeconds(transitionTime);
        // load new scene.
        SceneManager.LoadScene(levelIndex);

    }
}
