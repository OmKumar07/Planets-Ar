using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;

public class Gamemanager : MonoBehaviour
{
    public GameObject[] planets;
    public GameObject backButton;
    public List<GameObject> ActivePlanet = new List<GameObject>();
    public GameObject canvas;
    public GameObject MainLogo;
    public Vector3 PositionOffset;
    public Vector3 PositionOffset2;
    public Vector3 PositionOffset3;
    public Quaternion Rotation;

    private void Start()
    {
        MainLogo.SetActive(true);
        StartCoroutine(Disable_ui());
    }
    public void Planet0()
    {
        canvas.SetActive(false);
        backButton.SetActive(true);
        GameObject drag = Instantiate(planets[0],transform.position+PositionOffset,transform.rotation,transform);
        ActivePlanet.Add(drag);
        if (ActivePlanet.Count > 1)
        {
            Destroy(ActivePlanet[0]);
            ActivePlanet.RemoveAt(0);
        }
    }
    public void Planet1()
    {
        canvas.SetActive(false);
        backButton.SetActive(true);
        GameObject drag = Instantiate(planets[1], transform.position + PositionOffset, transform.rotation, transform);
        ActivePlanet.Add(drag);
        if (ActivePlanet.Count > 1)
        {
            Destroy(ActivePlanet[0]);
            ActivePlanet.RemoveAt(0);
        }
    }
    public void Planet2()
    {
        canvas.SetActive(false);
        backButton.SetActive(true);
        GameObject drag = Instantiate(planets[2], transform.position + PositionOffset, transform.rotation, transform);
        ActivePlanet.Add(drag);
        if (ActivePlanet.Count > 1)
        {
            Destroy(ActivePlanet[0]);
            ActivePlanet.RemoveAt(0);
        }
    }
    public void Planet3()
    {
        canvas.SetActive(false);
        backButton.SetActive(true);
        GameObject drag = Instantiate(planets[3], transform.position + PositionOffset, transform.rotation, transform);
        ActivePlanet.Add(drag);
        if (ActivePlanet.Count > 1)
        {
            Destroy(ActivePlanet[0]);
            ActivePlanet.RemoveAt(0);
        }
    }
    public void Planet4()
    {
        canvas.SetActive(false);
        backButton.SetActive(true);
        GameObject drag = Instantiate(planets[4], transform.position + PositionOffset2, transform.rotation, transform);
        ActivePlanet.Add(drag);
        if (ActivePlanet.Count > 1)
        {
            Destroy(ActivePlanet[0]);
            ActivePlanet.RemoveAt(0);
        }
    }
    public void Planet5()
    {
        canvas.SetActive(false);
        backButton.SetActive(true);
        GameObject drag = Instantiate(planets[5], transform.position + PositionOffset3, Rotation.normalized , transform);
        ActivePlanet.Add(drag);
        if (ActivePlanet.Count > 1)
        {
            Destroy(ActivePlanet[0]);
            ActivePlanet.RemoveAt(0);
        }
    }
    public void Planet6()
    {
        canvas.SetActive(false);
        backButton.SetActive(true);
        GameObject drag = Instantiate(planets[6], transform.position + PositionOffset2, transform.rotation, transform);
        ActivePlanet.Add(drag);
        if (ActivePlanet.Count > 1)
        {
            Destroy(ActivePlanet[0]);
            ActivePlanet.RemoveAt(0);
        }
    }
    public void Planet7()
    {
        canvas.SetActive(false);
        backButton.SetActive(true);
        GameObject drag = Instantiate(planets[7], transform.position + PositionOffset2, transform.rotation, transform);
        ActivePlanet.Add(drag);
        if (ActivePlanet.Count > 1)
        {
            Destroy(ActivePlanet[0]);
            ActivePlanet.RemoveAt(0);
        }
    }
    public void back()
    {
        canvas.SetActive(true);
    }
    public IEnumerator Disable_ui()
    {
        yield return new WaitForSeconds(1);
        MainLogo.SetActive(false);
        canvas.SetActive(true);
    }
}
