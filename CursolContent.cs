using UnityEngine;
using System.Collections;

public class CursolContent : ICursolContent {

    [System.Xml.Serialization.XmlIgnoreAttribute]
    public GameObject gameObject { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Action selectedAction { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Action leavedAction { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Action decisionAction { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Action deletedAction { get; set; }

    public CursolContent()
    {
        if (up == null) { up = ""; }
        if (down == null) { down = ""; }
        if (right == null) { right = ""; }
        if (left == null) { left = ""; }
    }
    /// <summary>
    /// 自身のキー
    /// </summary>
    public string key { get; set; }
    /// <summary>
    /// 右に移動した時のコンテンツのキー
    /// </summary>
    public string right { get; set; }
    /// <summary>
    /// 左に移動した時のコンテンツのキー
    /// </summary>
    public string left { get; set; }
    /// <summary>
    /// 上に移動した時のコンテンツのキー
    /// </summary>
    public string up { get; set; }
    /// <summary>
    /// 下に移動した時のコンテンツのキー
    /// </summary>
    public string down { get; set; }
}
