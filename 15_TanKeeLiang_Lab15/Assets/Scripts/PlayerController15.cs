using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController15 : MonoBehaviour
{
    float jumpForce = 8.0f;
    int IsGround = 0;
    int JumpCounter;

    private Rigidbody playerRB;
    private AudioSource audioSource;

    public GameObject JumpText;
    public AudioClip[] AudioClipArr;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGround < 1)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            JumpCounter++;
            JumpText.GetComponent<Text>().text = "Jump: " + JumpCounter;

            IsGround++;

            int rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGround = 0;
        }
    }
}
