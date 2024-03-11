using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class MazeExit : MonoBehaviour
{
    XRSocketInteractor socket;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        socketCheck2();
    }

    public void socketCheck2()
    {

        if (socket.hasSelection)
        {
            SceneManager.LoadScene(1);
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
