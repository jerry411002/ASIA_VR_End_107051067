
using UnityEngine;
using UnityEngine.SceneManagement;  

public class GameManager : MonoBehaviour
{
   
    public void RestartGame() 
    {
        SceneManager.LoadScene("basketball sc");
    }

    public void QuitGame()
    {
        
        Application.Quit();
    }
}
