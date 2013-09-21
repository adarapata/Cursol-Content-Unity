using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// コンテンツを選択するカーソルインタフェース
/// </summary>
public interface ICursol
{
    /// <summary>
    /// 現在選択中のコンテンツ
    /// </summary>
    List<ICursolContent> contents { set; get; }

    /// <summary>
    /// 現在のコンテンツから１つ移動
    /// </summary>
    /// <param name="direction"></param>
    void Move(CursolDirection direction);

    /// <summary>
    /// 現在選択しているコンテンツで決定
    /// </summary>
    void Desicion();

    /// <summary>
    /// 直接コンテンツを選択
    /// </summary>
    /// <param name="contentKey"></param>
    void Select(string contentKey);

    /// <summary>
    /// 現在選択しているコンテンツの削除
    /// </summary>
    void Delete();

    /// <summary>
    /// 指定したキーのコンテンツを削除
    /// </summary>
    /// <param name="contentKey"></param>
    void Delete(string contentKey);
}
