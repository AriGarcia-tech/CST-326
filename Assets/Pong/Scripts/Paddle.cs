using UnityEngine;

public class Paddle : MonoBehaviour
{
    public AudioClip hitSound;
    public AudioClip winhit;
    public AudioSource speaker;

    //-----------------------------------------------------------------------------
    public void MadeContact()
    {
        speaker.PlayOneShot(hitSound);
    }
    public void WinHit()
    {
        speaker.PlayOneShot(hitSound);
    }
}
