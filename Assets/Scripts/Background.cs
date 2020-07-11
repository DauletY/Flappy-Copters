using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : Engine
{
    public float xP, yP;
    private Rigidbody2D _rb2 = null;

    public override void Start() {
        _rb2 = this.GetComponent<Rigidbody2D>();
        _rb2.velocity = new Vector2(GameController._instance._speed, 0f);
    }
    public override void AudioPlayer(AudioSource source) {
        throw new System.NotImplementedException();
    }
}
