using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public PlayerController playerController;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public MeshRenderer meshRenderer;
    public SphereCollider sphereCollider;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        meshRenderer = GetComponent<MeshRenderer>();
        sphereCollider = GetComponent<SphereCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + 100 * Time.deltaTime, transform.localEulerAngles.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerController.zebranePunkty++;
            Debug.Log(playerController.zebranePunkty);

            audioSource.PlayOneShot(audioClip);


            //Destroy(this.gameObject);
            meshRenderer.enabled = false;
            sphereCollider.enabled = false;
        }

    }
}
