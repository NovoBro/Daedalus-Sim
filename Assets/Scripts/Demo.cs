using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    int blueCount = 0;
    [SerializeField] GameObject Wand;
    [SerializeField] GameObject BlueSphere;
    [SerializeField] GameObject PurpleSphere;
    [SerializeField] GameObject GreenSphere;
    Color blue1 = new Color(0.03242702f, 0f, 0.8509804f, 1.0f); 
    Color blue2 = new Color(0f, 0.5911602f, 0.8066038f, 1.0f);
    Color blue3 = new Color(0f, 1f, 0.9953141f, 1.0f);
    string blueTag = "blue";
    string purpleTag = "purple";
    string greenTag = "green";
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When collision with wand
        //blue sphere
        //purple sphere
        //play sound
        //green
        //destroy

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        if (other.gameObject.tag == blueTag)
        {
            blueCount++;
            blueCount %= 3;
            if (blueCount == 0) other.GetComponent<MeshRenderer>().material.SetColor("_Color", blue1);
            if (blueCount == 1) other.GetComponent<MeshRenderer>().material.SetColor("_Color", blue2);
            if (blueCount == 2) other.GetComponent<MeshRenderer>().material.SetColor("_Color", blue3);
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
}
