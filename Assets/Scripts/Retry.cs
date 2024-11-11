using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
