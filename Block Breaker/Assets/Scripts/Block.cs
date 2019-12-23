using UnityEngine;

public class Block : MonoBehaviour
{
    public AudioClip breakSound;
    Scores scores;
    private void Start()
    {
        scores = FindObjectOfType<Scores>();
        scores.CountBreakableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        
    }
    

}
