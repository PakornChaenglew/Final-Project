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
    [Header("GameStart")]
    [SerializeField] GameObject gameStartCanvas;
    [SerializeField] GameObject scorePanel;
    [SerializeField] float gameStartWaitTime;
    

    [Space]
    [Header("GameOver")]
    [SerializeField] GameObject gameOverCanvas;
    [SerializeField] float gameOverWaitTime;

    [Space]
    [Header("WinGame")]
    [SerializeField] GameObject winCanves;

    
    public IEnumerator GameStart()
    {
        playerControllScpt.enabled = false;
        playerMoveScpt.enabled = false;

        yield return new WaitForSeconds(gameStartWaitTime);
        gameStartCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        mouceLookScpt.islooking = false;
    }
    public IEnumerator GameOver()
    {
        playerControllScpt.enabled = false;
        playerMoveScpt.enabled = false;

        yield return new WaitForSeconds(gameOverWaitTime);
        gameOverCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        mouceLookScpt.islooking = false;
    }

    public void Startlevel()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mouceLookScpt.islooking = true;
        gameStartCanvas.SetActive(false);
        scorePanel.SetActive(true);
    }

    public void WinLevel()
    {
        playerControllScpt.enabled = false;
        playerMoveScpt.enabled = false;

        winCanves.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        mouceLookScpt.islooking = false;
    }

    public void LoadScene(int SceneId)
    {
        SceneManager.LoadScene(SceneId);
    }


}
