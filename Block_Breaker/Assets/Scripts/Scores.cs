using UnityEngine;

public class Scores : MonoBehaviour
{
    public int breakableBlocks = 0;
    public int blocksLeft;

    public int pointPerBlock = 10;
    public int blockDestroyed;
    public int totalScore;

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    

    public void FixedUpdate()
    {
        
    }
}
