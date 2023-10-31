using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField]
    private string NomeDoLevelDeJogo;
    // Start is called before the first frame update
    public void Jogar()
    {
        SceneManager.LoadScene(NomeDoLevelDeJogo);
    }
}
