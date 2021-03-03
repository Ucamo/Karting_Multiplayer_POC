using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void GoToMainMenu(){
        SceneManager.LoadScene(0);
    }
}
