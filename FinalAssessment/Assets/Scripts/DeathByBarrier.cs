using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathByBarrier : MonoBehaviour
{
    public AudioSource deathSource;

    // Start is called before the first frame update
    void Start()
    {
        deathSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            deathSource.Play();
            //SceneManager.LoadScene("KilledBySlime");
        }
        Debug.Log("enterscene");
    }
}
