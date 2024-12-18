//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public MouseClickedComponent mouseClicked { get { return (MouseClickedComponent)GetComponent(InputComponentsLookup.MouseClicked); } }
    public bool hasMouseClicked { get { return HasComponent(InputComponentsLookup.MouseClicked); } }

    public void AddMouseClicked(int newValue) {
        var index = InputComponentsLookup.MouseClicked;
        var component = (MouseClickedComponent)CreateComponent(index, typeof(MouseClickedComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMouseClicked(int newValue) {
        var index = InputComponentsLookup.MouseClicked;
        var component = (MouseClickedComponent)CreateComponent(index, typeof(MouseClickedComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMouseClicked() {
        RemoveComponent(InputComponentsLookup.MouseClicked);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherMouseClicked;

    public static Entitas.IMatcher<InputEntity> MouseClicked {
        get {
            if (_matcherMouseClicked == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.MouseClicked);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherMouseClicked = matcher;
            }

            return _matcherMouseClicked;
        }
    }
}
