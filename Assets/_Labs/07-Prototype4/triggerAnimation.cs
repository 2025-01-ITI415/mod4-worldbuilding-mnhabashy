using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class triggerAnimation : MonoBehaviour
{
    public Animator animator; // Drag your Animator here
    public Collider doorCollider;
    public static bool doorOpened = false;

    public float doorAnimationDuration = 2.0f;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            FirstPersonController playerController = other.GetComponent<FirstPersonController>();

            if (playerController != null && playerController.count == 6) {
                animator.SetTrigger("Open Door");
                StartCoroutine(DisableColliderAfterAnimation());
            }
        }
    }

    private IEnumerator DisableColliderAfterAnimation() {
        // Wait for the duration of the door opening animation
        yield return new WaitForSeconds(doorAnimationDuration);

        // Disable the collider after the animation finishes
        if (doorCollider != null) {
            doorCollider.enabled = false;
        }

        doorOpened = true;

        SceneManager.LoadSceneAsync(9);
    }
}