using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private int counter = 100;
    public string sceneName;
    public Rigidbody rb;
    public float forwardForce=20000f;
    public float sideForce=500f;
    public AudioSource validCollideSound;
    public List<Color> colors; 
    private int firstTouch = 0;

    public PlayerMovement movement;
    
    void Start() {
        validCollideSound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other) {
        if(other.collider) {
            var renderer = GetComponent<Renderer>();
            Material mat = new Material(Shader.Find("Specular"));
            Debug.Log("Masuk Collide");
            if(other.collider.tag == "Finished") {
                Debug.Log("game finished");
                movement.enabled = false;
                StartCoroutine(MainScene());
            }
            else if(other.collider.tag == "Untagged") {

            }
            // else if(other.collider.tag == "Sphere") {
            //     validCollideSound.Play();
            // }
            else if(other.collider.tag == "Bouncer") {
                rb.AddForce(sideForce,0,forwardForce);
                // Debug.Log("bounce");
            }
            else if(other.collider.tag == "-1") {
                counter = 1;
                validCollideSound.Play();
                if(firstTouch==0) {
                    renderer.material = mat;
                    firstTouch=1;
                }
                renderer.material.SetColor("_Color", colors[0]);
                
            }
            else if(other.collider.tag == "-2") {
                counter = 2;
                validCollideSound.Play();
                if(firstTouch==0) {
                    renderer.material = mat;
                    firstTouch=1;
                }
                renderer.material.SetColor("_Color", colors[1]);
            }
            else if(other.collider.tag == "-3") {
                counter = 3;
                validCollideSound.Play();
                if(firstTouch==0) {
                    renderer.material = mat;
                    firstTouch=1;
                }
                renderer.material.SetColor("_Color", colors[2]);
            }
            else if(other.collider.tag == "-4") {
                counter = 4;
                validCollideSound.Play();
                if(firstTouch==0) {
                    renderer.material = mat;
                    firstTouch=1;
                }
                renderer.material.SetColor("_Color", colors[3]);
            }
            else if(other.collider.tag == "-5") {
                counter = 5;
                validCollideSound.Play();
                if(firstTouch==0) {
                    renderer.material = mat;
                    firstTouch=1;
                }
                renderer.material.SetColor("_Color", colors[4]);
                // renderer.material = colors[4];
            }
            else {
                Destroy(other.collider);
                Destroy(other.gameObject);
                if(counter == int.Parse(other.collider.tag)) {
                    // lanjut aja 
                }
                else {
                    validCollideSound.Play();
                    Debug.Log(counter);
                    movement.enabled = false;
                    StartCoroutine(MainScene());
                }
                // hitted = true;
                // if(counter == 4) {
                //     Debug.Log("Ulang 1");
                //     counter = 1;
                //     unlockNewLevel = true;
                    // variabel unlockNewLevel akan dikirim ke controller/gamemanager untuk mendapatkan level baru
                    // artinya kelas gamemanager harus membuat arraylist yang berisi level yang sudah dia unlock
                }
                 return ;
            }    
            // else {
            //     // mati player
            //     // Debug.Log("Tabrak tag");
            //     // Debug.Log(other.collider.tag);
            //     // Debug.Log("counter number");
            //     Debug.Log(counter);
            //     movement.enabled = false;
            //     StartCoroutine(MainScene());
            //     // Debug.Log("Salah Tabrak");
            // }
        }
        
    // }

    // void Update()
    // {
    //     Debug.Log(rb.position);  
    //     // if((rb.position.y <=0 && rb.position.x >= 8) || (rb.position.y <=0 && rb.position.x <= -20)){
    //     //     movement.enabled = false;
    //     //     StartCoroutine(MainScene());
    //     // }
    // }

    IEnumerator MainScene() {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);

    }
}
