using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip ball, ballWall;
    static AudioSource audioSrc;

    void Start()
    {
        ball = Resources.Load<AudioClip>("BallBounce");
        ballWall = Resources.Load<AudioClip>("BallBounceWall");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "BallBounce":
                audioSrc.PlayOneShot(ball);
                break;
            case "BallBounceWall":
                audioSrc.PlayOneShot(ballWall);
                break;
        }

    }
}