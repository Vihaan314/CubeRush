using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class TabClick : MonoBehaviour
{

    public GameObject cubeContent;
    public GameObject specialContent;
    public GameObject particlesContent;

    public RectTransform cubeContentTransform;
    public RectTransform specialContentTransform;
    public RectTransform particleContentTransform;

    public GameObject cubeIcon;
    public GameObject specialCubeIcon;
    public GameObject particlesCubeIcon;

    public ScrollRect panelScroll;

    public Vector3 cubeHover;

    public void CubesToggle()
    {
        //Debug.Log("Cubes toggled");
        cubeContent.SetActive(true);
        specialContent.SetActive(false);
        particlesContent.SetActive(false);
        panelScroll = panelScroll.GetComponent<ScrollRect>();
        panelScroll.content = cubeContentTransform;

        var cubeHover = cubeIcon.transform.localScale;
        cubeHover.x = 37.5f;
        cubeHover.y = 37.5f;
        cubeIcon.transform.localScale = cubeHover;

        var specialCubesHover = specialCubeIcon.transform.localScale;
        specialCubesHover.x = 30f;
        specialCubesHover.y = 30f;
        specialCubeIcon.transform.localScale = specialCubesHover;

        var particlesCubeHover = particlesCubeIcon.transform.localScale;
        particlesCubeHover.x = 30f;
        particlesCubeHover.y = 30f;
        particlesCubeIcon.transform.localScale = particlesCubeHover;

    }
    public void SpecialsToggle()
    {
        //Debug.Log("Special Cubes toggled");
        specialContent.SetActive(true);
        cubeContent.SetActive(false);
        particlesContent.SetActive(false);
        panelScroll = panelScroll.GetComponent<ScrollRect>();
        panelScroll.content = specialContentTransform;

        var specialCubesHover = specialCubeIcon.transform.localScale;
        specialCubesHover.x = 37.5f;
        specialCubesHover.y = 37.5f;
        specialCubeIcon.transform.localScale = specialCubesHover;

        var cubeHover = cubeIcon.transform.localScale;
        cubeHover.x = 30f;
        cubeHover.y = 30f;
        cubeIcon.transform.localScale = cubeHover;

        var particlesCubeHover = particlesCubeIcon.transform.localScale;
        particlesCubeHover.x = 30f;
        particlesCubeHover.y = 30f;
        particlesCubeIcon.transform.localScale = particlesCubeHover;
    }
    public void ParticlesToggle()
    {
        //Debug.Log("Particle Effects toggled");
        particlesContent.SetActive(true);
        specialContent.SetActive(false);
        cubeContent.SetActive(false);
        panelScroll = panelScroll.GetComponent<ScrollRect>();
        panelScroll.content = particleContentTransform;

        var particlesCubeHover = particlesCubeIcon.transform.localScale;
        particlesCubeHover.x = 37.5f;
        particlesCubeHover.y = 37.5f;
        particlesCubeIcon.transform.localScale = particlesCubeHover;

        var specialCubesHover = specialCubeIcon.transform.localScale;
        specialCubesHover.x = 30f;
        specialCubesHover.y = 30f;
        specialCubeIcon.transform.localScale = specialCubesHover;

        var cubeHover = cubeIcon.transform.localScale;
        cubeHover.x = 30f;
        cubeHover.y = 30f;
        cubeIcon.transform.localScale = cubeHover;
    }
    void Start()
    {
        //cubeIcon = cubeIcon.GetComponent<RectTransform>();
        cubeHover = cubeIcon.transform.localScale;
        cubeHover.x = 37.5f;
        cubeHover.y = 37.5f;
        cubeIcon.transform.localScale = cubeHover;
    }
}

