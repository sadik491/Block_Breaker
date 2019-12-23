using UnityEngine;
using UnityEngine.SceneManagement;
public class Over : MonoBehaviour
{
   
    private void OnTriggerEnter2D ()
    {
        SceneManager.LoadScene("Game Over");
    }

    
}
