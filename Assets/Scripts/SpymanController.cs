using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpymanController : MonoBehaviour
{
    public ArrayList endpoints;
    private bool catchPlayer = false;
    private Vector3 position;
    public float velocity = 0.2f;
    void Start()
    {
        this.endpoints = new ArrayList();
        this.endpoints.Add(new Vector3(21.2999992f, 31.1000004f, -50));
        this.endpoints.Add(new Vector3(-3.4000001f, 31.1000004f, -50));
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
            int pos = Random.Range(0, 2);
            Debug.Log("Random Position SPYMAN: " + pos);
            this.position = (Vector3)this.endpoints[pos];
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
