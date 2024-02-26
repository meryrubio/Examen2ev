using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Firework : MonoBehaviour
{
    public float force, minTimeToExplode, maxTimeToExplode;
    public int minFireworks, maxFireworks;
    public GameObject fireworkPrefab;
    public int maxExplosions = 3;

    private Rigidbody2D _rb;
    private SpriteRenderer _rend;
    private int _count = 0;
    private Vector2 _dir = Vector2.up;
    private float currentTime, timeToExplode;

    //private Color[] color;
    //private int _indexcolor;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rend = GetComponent<SpriteRenderer>();

        //Color randomColor = new Color(Random.value, Random.value, Random.value, 1f);

       
        //_rend.color = randomColor;

        GameManager.instance.IncreaseScore(10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    
}

