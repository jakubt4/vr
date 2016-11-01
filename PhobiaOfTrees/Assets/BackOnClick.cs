using UnityEngine;
using System.Collections;

public class BackOnClick : MonoBehaviour {

    [SerializeField] private GameObject terrain;
    [SerializeField] private GameObject option;

    public void LoadOnClick()
    {
        option.SetActive(false);
    }
}
