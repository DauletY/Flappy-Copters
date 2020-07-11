using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : Engine
{
    public float time;
    public override void Start() {
        Destroy(gameObject, t:time);
    }
    public override void AudioPlayer(AudioSource source)
    {
        throw new System.NotImplementedException();
    }
}
