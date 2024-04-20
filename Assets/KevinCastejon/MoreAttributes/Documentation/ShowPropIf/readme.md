# ShowPropIf
Shows or hides a property on the inspector based on another serialized bool property value.

## How to use
Put the attribute in front of a property.<BR/>

## Examples
```cs
[SerializeField] private bool _canBeKilled;
[SerializeField][ShowPropIf("_canBeKilled")] private int _healthPoints;
[SerializeField] private bool _hasInfiniteAmmo;
[SerializeField][ShowPropIf("_hasInfiniteAmmo", false)] private int _ammoCount;
```
![](img/preview.png)
