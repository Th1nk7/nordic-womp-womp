using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenMovementScript : MonoBehaviour
{

    public BoxCollider2D bc;
    public bool MoveReady = true;
    public Animator m_Animator;
    public string direction;
    public Transform transform;
    public float TPDist = 1;
    private AudioSource audioSource;
    public GameObject EggManager;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveChicken(){
        if(direction == "Down"){
            transform.position = new Vector2(transform.position.x,transform.position.y-TPDist);
        }

        if(direction == "Right"){
            transform.position = new Vector2(transform.position.x+TPDist,transform.position.y);
        }

        if(direction == "Up"){
            transform.position = new Vector2(transform.position.x,transform.position.y+TPDist);
        }

        if(direction == "Left"){
            transform.position = new Vector2(transform.position.x-TPDist,transform.position.y);
        }
    }

    void AnimationDoneReceiver(){
        MoveReady = true;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Collect"){
            col.gameObject.SetActive(false);
            EggManager.GetComponent<EggManagerScript>().UpdateEggCounter();
        }

        else if(col.gameObject.tag == "BurnChicken"){
            Debug.Log("Died");
            SceneManager.LoadScene("LostScreen");
        }

        else if(Input.GetKey(KeyCode.DownArrow) && col.gameObject.tag == "Down" && MoveReady == true){
            Debug.Log("Down Correct!");
            MoveReady = false;
            direction = "Down";
            m_Animator.SetTrigger("ChickenPoof");
            audioSource.Play();
        }
        else if(Input.GetKey(KeyCode.UpArrow) && col.gameObject.tag == "Up" && MoveReady == true){
            Debug.Log("Up Correct!");
            MoveReady = false;
            direction = "Up";
            m_Animator.SetTrigger("ChickenPoof");
            audioSource.Play();
        }
        else if(Input.GetKey(KeyCode.LeftArrow) && col.gameObject.tag == "Left" && MoveReady == true){
            Debug.Log("Left Correct!");
            MoveReady = false;
            direction = "Left";
            m_Animator.SetTrigger("ChickenPoof");
            audioSource.Play();
        }
        else if(Input.GetKey(KeyCode.RightArrow) && col.gameObject.tag == "Right" && MoveReady == true){
            Debug.Log("Right Correct!");
            MoveReady = false;
            direction = "Right";
            m_Animator.SetTrigger("ChickenPoof");
            audioSource.Play();
        }
    }
}
