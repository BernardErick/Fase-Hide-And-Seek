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
     * Cada FIRST + SECOND é uma posição do nó na árvore.
     * Tome cuidado quando o first e o second forem iguais. Pois eles cairão no mesmo evento.
     * Basicamente se for 1 e 1, não importa o que o cara fizer anteriormente, ele vai cair igualmente.
     * Recomendo usar isso para colocar pontos de interseção de historia, exemplo: Você sempre cairá no evento de matar os funcionarios sla
     */
    public void change(int first, int second) {
        if (first == 0 && second == 0) {
            canvas_text.text = "Bora começar essa merda em Linus?";
            canvas_first_text.text = "Quero começar";
            canvas_second_text.text = "Não quero começar";
        }
        if (first == 1 && second == 0) {
            canvas_text.text = "Puta que pariu Linus, você é um merda mesmo viu, vai querer bolo?";
            canvas_first_text.text = "Comer bolo com gosto de pica.";
            canvas_second_text.text = "Comer pica com gosto de bolo.";
        }
        if (first == 0 && second == 1) {
            canvas_text.text = "Quer dizer que não quer jogar meu jogo né?";
            canvas_first_text.text = "Comer a pica do adm";
            canvas_second_text.text = "Comer pica do moderador";
        }
        if (first == 2 && second == 0) {
            canvas_text.text = "Linus, até quando você vai fingir que entende oq está rolando?";
            canvas_first_text.text = "Sei lá porra";
            canvas_second_text.text = "Vai te fude.";
        }
        if (first == 2 && second == 1) {
            canvas_text.text = "Oq ta achando do jogo Linus?";
            canvas_first_text.text = "Que jogo?";
            canvas_second_text.text = "Num sei";
        }
    }
}
