using Unity.VisualScripting;
using UnityEngine;

public class PlayerCtrler : MonoBehaviour
{
    private Rigidbody playerRb;

    public float jumpForce = 10;

    public float gravityModifier;

    public bool isOnGround = true;

    public bool gameOver = false;

    private Animator playerAnim;
<<<<<<< HEAD
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip music;
    public AudioSource muisic;
=======

    public ParticleSystem explosionParticle;

    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;

    public AudioClip deathSound;

    public AudioSource playerAudio;

>>>>>>> 0dfc40743000fda0ca78d6580201159907518161
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
=======
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
>>>>>>> 0dfc40743000fda0ca78d6580201159907518161
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
<<<<<<< HEAD
            dirtParticle.Stop();
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && isOnGround)
=======
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            dirtParticle.Stop();
            }
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && !gameOver)
>>>>>>> 0dfc40743000fda0ca78d6580201159907518161
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
<<<<<<< HEAD
=======
            playerAudio.PlayOneShot(jumpSound, 1.0f);
>>>>>>> 0dfc40743000fda0ca78d6580201159907518161
            dirtParticle.Stop();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
<<<<<<< HEAD
=======
            playerAudio.PlayOneShot(deathSound, 1.0f);
>>>>>>> 0dfc40743000fda0ca78d6580201159907518161
            dirtParticle.Stop();
        }
    }
}
