using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class switchToRestartedGame : MonoBehaviour
{
    public FirstPersonController playerController;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchSceneAfterDelay());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            restartedGame();
        }
    }

    IEnumerator SwitchSceneAfterDelay() {
        yield return new WaitForSeconds(15f);
        restartedGame();
    }

    public void restartedGame() {
        SceneManager.LoadScene(8);
    }
}