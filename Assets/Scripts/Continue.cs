using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public int level = SceneManager.GetActiveScene().buildIndex;
    public int finalLevel;

    public void clicked()
    {
        if (level != finalLevel)
        {
            SceneManager.LoadScene(level + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
