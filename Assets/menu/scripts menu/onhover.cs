using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class onhover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public float distancia_Aparicion = 2f;
    public GameObject nave_puntero;

    public bool derecha = true;


    public void OnPointerEnter(PointerEventData eventData)
    {

        Debug.Log("Mouse Enter.");
        Debug.Log(this.transform.position);

        if (derecha)
            nave_puntero.transform.position = this.transform.position + new Vector3(distancia_Aparicion, 0, 0);
        
        else
            nave_puntero.transform.position = this.transform.position - new Vector3(distancia_Aparicion, 0, 0);
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
    }
}
