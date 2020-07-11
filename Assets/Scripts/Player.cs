using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Engine
{
    public float _upForce = 200f;
    public float _Ypos; 
    public AudioClip _wing;
    public Animator _anim;
    private Rigidbody2D _rb2d;

    public override void AudioPlayer(AudioSource source)
    {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(_wing);
    }

    // Start is called before the first frame update
    public override void Start()
    {
        _rb2d = this.GetComponent<Rigidbody2D>();
        _anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController._instance._isDie) return;
        
        float Yposition = -5.3f;

        if  (Input.GetKeyDown(KeyCode.Space)) {
             AudioPlayer(new AudioSource());
            _rb2d.velocity = Vector3.zero;
            _rb2d.AddForce(new Vector2(0, _upForce));
            _anim.SetTrigger("Wing");
        }
        if(_rb2d.transform.position.y <= _Ypos) {
            _rb2d.velocity = Vector2.zero;
            GameController._instance.Die();
            GameController._instance.NewScene();
        }
        else if(_rb2d.transform.position.y >= -Yposition ) {
            //_rb2d.velocity = Vector2.zero;
            GameController._instance.Die();
            GameController._instance.NewScene();
            _rb2d.isKinematic = true;
        }
    }
}
