using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// コンテンツのカーソルクラス
/// </summary>
public class Cursol : MonoBehaviour, ICursol
{
    private const string EMPTY = "";
    public List<ICursolContent> contents { set;  get; }
    /// <summary>
    /// 現在選択しているコンテンツ
    /// </summary>
    private ICursolContent nowContent { get { return GetContent(key); } }

    private string key;

    void Start()
    {
        StartCoroutine(Initialize());
    }
    IEnumerator Initialize()
    {
        yield return new WaitForEndOfFrame();
        key = contents[0].key;
        nowContent.selectedAction();
    }
    public void Move(CursolDirection direction) 
    {
        ICursolContent content = nowContent;
        string nextKey = EMPTY;
        switch (direction)
        {
            case CursolDirection.Left:
                nextKey = content.left;
                break;
            case CursolDirection.Right:
                nextKey = content.right;
                break;
            case CursolDirection.UP:
                nextKey = content.up;
                break;
            case CursolDirection.Down:
                nextKey = content.down;
                break;
        }
        if (nextKey == EMPTY || key == nextKey) { return; }

        if(content.leavedAction != null) content.leavedAction();
        GetContent(nextKey).selectedAction();
        key = nextKey;
    }

    public void Desicion() 
    {
        nowContent.decisionAction();
    }

    public void Select(string contentKey)
    {
        try { GetContent(contentKey).selectedAction(); }
        catch { return; }
        nowContent.leavedAction();

        key = contentKey;
    }

    public void Delete()
    {
        Delete(nowContent.key);
    }

    public void Delete(string contentKey)
    {
        var content = GetContent(contentKey);
        ChockUp(content);
        key = content.up;
        contents.Remove(content);
        content.deletedAction();
        nowContent.selectedAction();
    }

    private ICursolContent GetContent(string contentKey)
    {
        return contents.Single(n => n.key == contentKey);
    }

    /// <summary>
    /// 詰める
    /// </summary>
    private void ChockUp(ICursolContent content)
    {
        if (content.up != EMPTY) { GetContent(content.up).down = content.down; }
        if (content.down != EMPTY) { GetContent(content.down).up = content.up; }
        if (content.left != EMPTY) { GetContent(content.left).right = content.right; }
        if (content.right != EMPTY) { GetContent(content.right).left = content.left; }
    }
}
