using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticleOnStart : MonoBehaviour
{
    void Start()
    {
        GetComponent<ParticleSystem>().Play();
    }
}
