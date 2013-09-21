using UnityEngine;
using System.Collections;

/// <summary>
/// カーソルで選択できるコンテンツのインタフェース
/// </summary>
public interface ICursolContent{
    /// <summary>
    /// コンテンツとなる対象のUnityゲームオブジェクト
    /// </summary>
    GameObject gameObject { get; set; }
    /// <summary>
    /// コンテンツからカーソルが離れた時のアクション
    /// </summary>
    System.Action leavedAction { get; set; }
    /// <summary>
    /// カーソルがこのコンテンツを選択した時のアクション
    /// </summary>
    System.Action selectedAction { get; set; }
    /// <summary>
    /// カーソルがこのコンテンツを決定した時のアクション
    /// </summary>
    System.Action decisionAction { get; set; }

    System.Action deletedAction { get; set; }
    /// <summary>
    /// 自身のキー
    /// </summary>
    string key { get; set; }
    /// <summary>
    /// 右に移動した時のコンテンツのキー
    /// </summary>
    string right { get; set; }
    /// <summary>
    /// 左に移動した時のコンテンツのキー
    /// </summary>
    string left { get; set; }
    /// <summary>
    /// 上に移動した時のコンテンツのキー
    /// </summary>
    string up { get; set; }
    /// <summary>
    /// 下に移動した時のコンテンツのキー
    /// </summary>
    string down { get; set; }
}
