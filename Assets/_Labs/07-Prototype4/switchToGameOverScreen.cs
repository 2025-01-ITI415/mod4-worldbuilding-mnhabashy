using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchToGameOverScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchSceneAfterDelay());
    }

    IEnumerator SwitchSceneAfterDelay() {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(5);
    }
}