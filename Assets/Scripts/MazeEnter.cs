using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeEnter : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject door;
    string door1 = "door1";
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter1(Collider other)
    {
        Debug.Log("entered");
        if (other.gameObject.tag == door1)
        {
            //move player
            transform.position = new Vector3(3.5f, 0, -1);
            //delete door
            Destroy(gameObject);
        }
        

        /*
        if (other.gameObject.tag == purpleTag)
        {
            audioData = other.GetComponent<AudioSource>();
            audioData.Play(0);
        }
        if (other.gameObject.tag == greenTag)
        {
            Destroy(other.gameObject);
        }
        */
    }
}
