using System.Collections.Generic;
using UnityEngine;

namespace NorskaLib.GoogleSheetsDatabase
{
    public abstract class DataContainerBase : ScriptableObject
    {
        [Tooltip("The XXXX part in 'https://docs.google.com/spreadsheets/d/XXXX/edit' URL." +
            " The document must be accessable by link.")]
        [SerializeField] [HideInInspector]
        public string documentID;
    }
}