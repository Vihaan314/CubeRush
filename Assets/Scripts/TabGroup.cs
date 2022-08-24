using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<tabButton> tabButtons;
    public tabButton selectedTab;
    public List<GameObject> objectsToSwap;
   

    public void Subscribe(tabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<tabButton>();
        }

        tabButtons.Add(button);
    }

    public void OnTabEnter(tabButton button)
    {
        ResetTabs();
    }

    public void OnTabExit(tabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(tabButton button)
    {
        selectedTab = button;
        ResetTabs();
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++)
        {
            if (i == index)
            {
                objectsToSwap[i].SetActive(true);
            }
            else
            {
                objectsToSwap[i].SetActive(false);
            }
        }
    }
    
    public void ResetTabs()
    {
        foreach(tabButton button in tabButtons)
        {
            if (selectedTab!=null && button == selectedTab)
            {
                continue;
            }
        }
    }
}
