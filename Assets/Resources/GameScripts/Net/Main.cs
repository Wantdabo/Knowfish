﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField]
    public Transform uiRoot;
    [SerializeField]
    public Transform uiSound;
    [SerializeField]
    public Transform sceneRoot;
    [SerializeField]
    public Transform sceneSound;

    private static Main main;

    public static Main Instance
    {
        get
        {
            if(main == null)
                main = Camera.main.GetComponent<Main>();

            return main;
        }
    }

    private void Start()
    {
        foreach (Object obj in GameObject.FindObjectsOfType<GameObject>())
            DontDestroyOnLoad(obj);

        AddComponent();
        Lua.Instance.Start();
    }

    private void AddComponent() {
        gameObject.AddComponent<SceneLoader>();
    }

    private void Update()
    {
        Lua.Instance.Update();
    }

    private void FixedUpdate()
    {
        Lua.Instance.FixedUpdate();
    }

    private void LateUpdate()
    {
        Lua.Instance.LateUpdate();
    }
}