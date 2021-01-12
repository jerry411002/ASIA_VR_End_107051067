
using UnityEngine;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public static  int score;
    [Header("投進的分數")]
    public int scoreIn;
    [Header("進球音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
  }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Bomb"&& other.transform.position.y>-10f)
        {
            AddScore();
        }
        
    }

    

    private void AddScore()
    {
        score += scoreIn;
        textScore.text = "分數：" + score;

        aud.PlayOneShot(soundIn, Random.Range(1f, 3f));

    }

}
