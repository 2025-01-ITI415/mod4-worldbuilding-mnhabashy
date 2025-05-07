using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class changeScene : MonoBehaviour
{
    public void titleScreen() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
    
    public void blackScreen() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(1);
    }

    public void game() {
        SceneManager.LoadScene(2);
    }

    public void blackScreenOne() {
        SceneManager.LoadScene(3);
    }

    public void gameTwo() {
        SceneManager.LoadScene(4);
    }

    public void blackScreenTwo() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(5);
    }

    public void titleScreenOne() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(6);
    }

    public void blackScreenThree() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(7);
    }

    public void gameThree() {
        SceneManager.LoadScene(8);
    }

    public void blackScreenFour() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(9);
    }
}