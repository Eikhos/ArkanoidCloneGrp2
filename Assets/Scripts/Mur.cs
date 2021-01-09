using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mur : MonoBehaviour
{
    private int Score = 0;
    public GameObject Projectil;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Score += 1;
        GameObject.Find("ScoreD").GetComponent<TextMesh>().text = "" + Score;
        Instantiate(Projectil, GameObject.Find("Eject").GetComponent<Transform>().transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
    }   

}
