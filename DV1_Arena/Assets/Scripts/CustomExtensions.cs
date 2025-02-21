using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomExtensions //holds all the extension classes & methods 
{
    public static class StringExtensions 
    {
        public static void FancyDebug(this string str) //this string str marks the method as an extension
                                                       //str parameter holds a reference to the actual text value FacnyDebug() is called from
        {
            Debug.LogFormat("This string contains {0} characerts.", str.Length); //str.Length references the string varable FancyDebug() is called on
        }
    }
}
