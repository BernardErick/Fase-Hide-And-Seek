using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpymanController : MonoBehaviour
{
    public ArrayList endpoints;
    private bool catchPlayer = false;
    private Vector3 position;
    public float velocity = 0.2f;
    public GameObject player;
    void Start()
    {
        this.endpoints = new ArrayList();
        this.endpoints.Add(new Vector3(-0.0900000036f, -0.340000004f, -50));
        this.endpoints.Add(new Vector3(6.80000019f, 38.0999985f, -50));
        this.endpoints.Add(new Vector3(6.80000019f, 69.5999985f, -50));
        this.endpoints.Add(new Vector3(6.80000019f, -4.80000019f, -50));
        StartCoroutine(ChangePositionTime());
    }

    // Update is called once per frame
    void Update()
    {
        movementSpyman();
    }
    public IEnumerator ChangePositionTime()
    {
        while (!catchPlayer)
        {
            int pos = Random.Range(0, 7);
            if (pos >= 4)
            {
                Debug.Log("Random Position TO PLAYER: "+pos);
                this.position = this.player.transform.position;
            }
            else {
                Debug.Log("Random Position SPYMAN: " + pos);
                this.position = (Vector3)this.endpoints[pos];
            }       
            yield return new WaitForSeconds(2.0f);
        }
    }
    void movementSpyman()
    {
        Vector3 posicaoInicial = this.transform.position;
        Vector3 posicaoFinal = this.position;
        this.transform.position = Vector3.Lerp(posicaoInicial, posicaoFinal, Time.fixedDeltaTime * velocity);
    }
}
