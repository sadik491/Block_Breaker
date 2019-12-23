using UnityEngine;

public class ball : MonoBehaviour
{
    public Paddle paddle1;

    Vector2 paddleToBall;
    public bool hasStarted = false;

    public AudioClip [] ballSounds;

    AudioSource myAudioSource;

    

    void Start()
    {
        paddleToBall = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LunchBall();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            AudioClip clip= ballSounds[Random.Range(0, ballSounds.Length)];
            myAudioSource.PlayOneShot(clip);
        }

    }

    private void LunchBall()
    {
        if (Input.GetMouseButton (0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 14f);
        }
    }
    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBall;
    }

    


}
