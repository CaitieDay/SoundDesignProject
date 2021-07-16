using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songController : MonoBehaviour
{
    [SerializeField]
    private AudioSource timshel;
    [SerializeField]
    private AudioSource le;
    private bool controller;

    // Start is called before the first frame update
    void Start()
    {
        timshel.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (timshel.isPlaying)
        {
            if (controller == false)
            {
                controller = true;
            }
        }

        if (le.isPlaying)
        {
            if (controller == true)
            {
                controller = false;
            }
        }

        if (timshel.isPlaying == le.isPlaying)
        {
            if (controller == true)
            {
                le.Play();
            }
            else
            {
                timshel.Play();
            }
        }
    }
}
