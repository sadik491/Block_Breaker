
using UnityEngine;

public class Paddle : MonoBehaviour
{
    
    float screenWidthInUnits = 16f;
   
    void Update()
    {
        float mousePosInUnit = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePod = new Vector2(transform.position.x, transform.position.y);
        paddlePod.x = Mathf.Clamp(mousePosInUnit, 1.02f, 14.95f);
        transform.position = paddlePod;
    }
}
