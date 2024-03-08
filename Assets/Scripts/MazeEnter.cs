using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MazeEnter : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject door;
    string door1 = "door1";
    AudioSource audioData;
    [SerializeField] GameObject keyhole;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject floor;
    XRSocketInteractor socket;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        socketCheck();
    }

    public void socketCheck()
    {

        if (socket.hasSelection)
        {
            //move player
            Player.transform.position = new Vector3(3.5f, 0, -1);
            //Player.transform.Rotate = new Vector3(3.5f, 0, -1);
            //Try this transform.rotation *= Quaternion.Euler(0,90,0);
            //delete key and door
            Destroy(door);
            Destroy(key);
            Destroy(floor);
        }
    }

    /*
    private void OnTriggerInSocket(Collider other)
    {
        Debug.Log("entered");
        if (other.gameObject.tag == door1)
        {
            //move player
            transform.position = new Vector3(3.5f, 0, -1);
            //delete door
            Destroy(door);
        }
        

        
        if (other.gameObject.tag == purpleTag)
        {
            audioData = other.GetComponent<AudioSource>();
            audioData.Play(0);
        }
        if (other.gameObject.tag == greenTag)
        {
            Destroy(other.gameObject);
        }
    }
        */
}
