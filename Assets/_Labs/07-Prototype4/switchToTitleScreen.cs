using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchToTitleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchSceneAfterDelay());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator SwitchSceneAfterDelay() {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(0);
    }
}