using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    float volspeed = 0.2f;

    private AudioSource audioSource;

    public AudioClip[] audioclipArr;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        int rand = Random.Range(0, audioclipArr.Length);
        audioSource.PlayOneShot(audioclipArr[rand]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            audioSource.Stop();
            int rand = Random.Range(0, audioclipArr.Length);
            audioSource.PlayOneShot(audioclipArr[rand]);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            audioSource.volume += Time.deltaTime * volspeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            audioSource.volume -= Time.deltaTime * volspeed;
        }
    }
}
