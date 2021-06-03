# Slider+


## About this project
Slider plus is extension for Unity's default slider. Slider+ revamps *Whole Numbers* option, adds animations, and smooth move.

## Tweening Engines
Slider+ requires one of the tweening engines to be imported in order to use animations. If you know any other tweening engine that isn't on the list, please consider contributing.

### List of supported tweening engines.
- DOTween


## Installation
1. Download Slider+ from Unity Asset Store or Github's release page
  1.1. If using GitHub: Drag the package to Unity Editor and click Import
2. Install any of the tweening engine listed above and in code(/Assets/Plugins/Maciejowski/Slider+/Scripts/SliderController.cs) uncomment your tweening engine.
3. Add SliderController script to any slider(this will also add Event Trigger).
  3.1. DISABLE **Whole Numbers** option in Slider
  3.2. In Event Trigger add new event **Pointer Up**
  3.3. Assign Slider Controller to Event Trigger and select function **SliderController > OnClickUp ()**.
  3.4. Assign Handle and Slider in Slider Controller.
4.(Optionally) Enable animations and set duration.
