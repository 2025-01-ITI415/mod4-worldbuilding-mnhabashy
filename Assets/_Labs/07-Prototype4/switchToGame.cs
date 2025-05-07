using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchToGame : MonoBehaviour
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
            SceneManager.LoadScene(2);
        }
    }

    IEnumerator SwitchSceneAfterDelay() {
        yield return new WaitForSeconds(30f);
        SceneManager.LoadScene(2);
    }
}