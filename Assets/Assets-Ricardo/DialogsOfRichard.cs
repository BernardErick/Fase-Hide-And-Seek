using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogsOfRichard : MonoBehaviour
{
    //Tudo novo nessa porra
    public Text canvas_text;
    public Text canvas_first_text;
    public Text canvas_second_text;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Crie os eventos aqui
    /*
     * Cada FIRST + SECOND � uma posi��o do n� na �rvore.
     * Tome cuidado quando o first e o second forem iguais. Pois eles cair�o no mesmo evento.
     * Basicamente se for 1 e 1, n�o importa o que o cara fizer anteriormente, ele vai cair igualmente.
     * Recomendo usar isso para colocar pontos de interse��o de historia, exemplo: Voc� sempre cair� no evento de matar os funcionarios sla
     */
    public void change(int first, int second) {
        if (first == 0 && second == 0) {
            canvas_text.text = "Bora come�ar essa merda em Linus?";
            canvas_first_text.text = "Quero come�ar";
            canvas_second_text.text = "N�o quero come�ar";
        }
        if (first == 1 && second == 0) {
            canvas_text.text = "Puta que pariu Linus, voc� � um merda mesmo viu, vai querer bolo?";
            canvas_first_text.text = "Comer bolo com gosto de pica.";
            canvas_second_text.text = "Comer pica com gosto de bolo.";
        }
        if (first == 0 && second == 1) {
            canvas_text.text = "Quer dizer que n�o quer jogar meu jogo n�?";
            canvas_first_text.text = "Comer a pica do adm";
            canvas_second_text.text = "Comer pica do moderador";
        }
        if (first == 2 && second == 0) {
            canvas_text.text = "Linus, at� quando voc� vai fingir que entende oq est� rolando?";
            canvas_first_text.text = "Sei l� porra";
            canvas_second_text.text = "Vai te fude.";
        }
        if (first == 2 && second == 1) {
            canvas_text.text = "Oq ta achando do jogo Linus?";
            canvas_first_text.text = "Que jogo?";
            canvas_second_text.text = "Num sei";
        }
    }
}
