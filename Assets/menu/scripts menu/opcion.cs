using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opcion : MonoBehaviour
{
    public Animator Transicion;
    public float  time_transicion=1f;
    // Start is called before the first frame update

    public void PlayGame()
    {

        StartCoroutine(loadlevel(SceneManager.GetActiveScene().buildIndex + 1));
        

    }

    // Update is called once per frame
    IEnumerator loadlevel(int levelindex)
    {
        Transicion.SetTrigger("Start");
        yield return new WaitForSeconds(time_transicion);
        SceneManager.LoadScene(levelindex);
    }

}
