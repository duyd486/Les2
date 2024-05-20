using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxHealth = 100;
    public float speedMove = 20f;
    public float speedRotate = 20f;
    public int fuelValue = 20;
    public float damageValue = 50;
    public int coinValue = 1;
    
    public GameObject explusionPrefabs;


    private float currentHealth = 0;
    private bool isGate = false;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, vertical * speedMove * Time.deltaTime));
        transform.Rotate(new Vector3(0, horizontal * speedRotate * Time.deltaTime, 0));

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "fuel")
        {
            Destroy(other.gameObject);
            GameManager.instance.SetFuel(fuelValue);
            InstantiateGame(other);
        }   
        else if (other.tag == "Dame")
        {
            Destroy(other.gameObject);
            DamageHealth(damageValue);
            InstantiateGame(other);
        }
        else if (other.tag == "FinishGame")
        {
            if(isGate == true)
            {
                GameManager.instance.SetRound(1);
                isGate = false;
            }
        }
        else if (other.name == "MidGate")
        {
            isGate = true;
        }
        else if (other.tag == "Coin")
        {
            GameManager.instance.SetCoin(coinValue);
            Destroy(other.gameObject);
        }
    }
    void InstantiateGame(Collider other)
    {
        Instantiate(explusionPrefabs, other.transform.position, Quaternion.identity);

    }
    private void DamageHealth(float health)
    {
        if(currentHealth > 0)
        {
            currentHealth -= health;
        }   else
        {
            currentHealth = 0;
            Destroy(gameObject);
        }
    }
}
