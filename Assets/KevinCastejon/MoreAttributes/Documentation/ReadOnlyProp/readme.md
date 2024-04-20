# ReadOnlyProp
Prevents a property from being edited on the *Inspector*.

## How to use
Put the attribute in front of a property.<BR/>

## Examples
```cs
[ReadOnlyProp]
public int healthPoints;
[ReadOnlyReadOnlyProp]
public int damages;
```
![](img/ReadOnlyAttributeInspectorPreview.png)
