
using UnityEngine;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    [Header("投進的分數")]
    public int scoreIn = 2;
    [Header("進球音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Bomb"&& other.transform.position .y >2.5f )
        {
            AddScore();
        }
        
        if (other.transform.root.name=="Player")
        {
            scoreIn =5;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root .name=="Player")
        {
           
            scoreIn = 2;
        }  
    }

    private  void  AddScore()
        {
            score += scoreIn;                  
            textScore.text = "分數" + score;  
            aud.PlayOneShot(soundIn, Random.Range(1f, 2f)); //音效來源.撥放一次(音效片段,音量)
        }
   
}
