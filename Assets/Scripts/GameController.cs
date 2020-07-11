using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

[System.Serializable]
public class P2 {
    public AudioSource audio1;
    public AudioSource audio2; 

}
public class GameController : MonoBehaviour {

   
    public static GameController _instance;
    
    public AudioClip _clipDie;
    public AudioClip _clipScore;
    public Text _textScore = null;
    
    public Text _dieText = null;
    public float _speed = -1.5f;
    public float _seconds = 1f;
    
    public bool _isDie = false;
    [SerializeField] private  P2 _P = new P2();
    
    private int _score = 0;
    private void Start() {
        _instance = this;
        _textScore.text = "Score: " + _score;
        _dieText.gameObject.SetActive(_isDie);
        _P.audio1.GetComponent<AudioSource>();
        _P.audio2.GetComponent<AudioSource>();
    
    }
    public void NewScene() {
        StartCoroutine("LoadScene");
    }
    private IEnumerator LoadScene() {
        yield return new WaitForSeconds(seconds: _seconds );
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Score() {
        if(_isDie) return;
        _score++;
        _textScore.text = "Score: " + _score;
        _P.audio2.PlayOneShot(_clipScore);
    }
    public void Die() {
        _dieText.text = "Game Over";
        _isDie = true;
        _dieText.gameObject.SetActive(_isDie);
        // Debug.Log("die" + _isDie);
        _P.audio1.PlayOneShot(_clipDie);
    }
}