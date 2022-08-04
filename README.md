# Changelog

1. Add new input system
    - Package Manager > Input System > Install
1. Restart Unity
1. Update EventSystem
    - Standalone Input Module > Replace with InputSystemUIInputModule
1. Update to new API
    - `Input.GetAxisRaw("Mouse ScrollWheel")` -> `Mouse.current.scroll.ReadUnprocessedValue().y`

# Observations
- When using the older UnityEngine.Input the scroll reporter always changes to a multiple of 0.005.
- Project Settings > Input Manager > Axes > Mouse ScrollWheel > Sensitivity has a default value of 0.1, so changing this to 1 results in the scroll reporter changing in multiples of 0.05.
- When using the new InputSystem all scroll values are whole numbers.  (The minimum you can scroll by is ±1)
- This means all scroll values using the new InputSystem are 200x more sensitive.