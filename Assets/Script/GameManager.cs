using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] CharacterController playerControllScpt;
    [SerializeField] PlayerMove playerMoveScpt;
    [SerializeField] MouceLook mouceLookScpt;


    [Space]
    [Header("GameOver")]
    [SerializeField] GameObject gameOverCanvas;
    [SerializeField] float gameOverWaitTime;
    public IEnumerator GameOver()
    {
        playerControllScpt.enabled = false;
        playerMoveScpt.enabled = false;

        yield return new WaitForSeconds(gameOverWaitTime);
        gameOverCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        mouceLookScpt.islooking = false;
    }

    public void LoadScene(int SceneId)
    {
        SceneManager.LoadScene(SceneId);
    }
}
