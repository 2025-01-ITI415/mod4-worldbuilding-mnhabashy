using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class cheatManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(0);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            SceneManager.LoadScene(2);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            SceneManager.LoadScene(3);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            SceneManager.LoadScene(4);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(5);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(6);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(7);
        }

        if (Input.GetKeyDown(KeyCode.Alpha8)) {
            SceneManager.LoadScene(8);
        }

        if (Input.GetKeyDown(KeyCode.Alpha9)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(9);
        }

        if (Input.GetKeyDown(KeyCode.K)) {
            FirstPersonController playerController = FindObjectOfType<FirstPersonController>();
            
            if (playerController != null) {
                playerController.count = 6;
                playerController.SetCountText();
            }
        }
    }
}