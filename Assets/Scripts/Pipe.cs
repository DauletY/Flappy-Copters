using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : Engine
{
    public GameObject _explotion;
    public AudioClip _audio;

    
    private void OnTriggerEnter2D(Collider2D other) {
      if(other.GetComponent<Player>() != null) {
          //GameController._instance.Die();
          GameController._instance.NewScene();
          Instantiate(_explotion, other.transform.position, Quaternion.identity);
          // sound here <hit>
          AudioPlayer(new AudioSource());
          Destroy(other.gameObject);
        
      }
    }
    public override void AudioPlayer(AudioSource source)
    {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(_audio);
    }
}
