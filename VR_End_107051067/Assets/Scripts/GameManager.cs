
using UnityEngine;
using UnityEngine.SceneManagement;  //引用 場景管理器 API

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 重新開始
    /// </summary>
    public void RestartGame() 
    {
        SceneManager.LoadScene("basketball sc");
    }

    public void QuitGame()
    {
        //應用程式.離開遊戲()
        Application.Quit();
    }
}
