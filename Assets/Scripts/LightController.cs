using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public float velocityLight = 0.3f;
    private bool catchPlayer = false;
    private int LightZ = 0;
    void Start()
    {
        StartCoroutine(LightRotateTime());
    }

    // Update is called once per frame
    void Update()
    {
        movementLight();
    }
    public IEnumerator LightRotateTime()
    {
        while (!catchPlayer)
        {
            yield return new WaitForSeconds(2.0f);
            int randZ = Random.Range(-360, 360);
            Debug.Log("Random: " + randZ);
            this.LightZ = randZ;
        }
    }
    void movementLight()
    {
        Quaternion rotacaoAtual = this.transform.rotation;
        Quaternion rotacaoFinal = Quaternion.Euler(0, 0, this.LightZ);
        Quaternion novaRotacao = Quaternion.Lerp(rotacaoAtual, rotacaoFinal, Time.fixedDeltaTime * velocityLight);
        this.transform.rotation = novaRotacao;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Jogador")) {
            Debug.Log("Jogador capturado!");
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Jogador"))
        {
            Debug.Log("Jogador fugiu!");
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
