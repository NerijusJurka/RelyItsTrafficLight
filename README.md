# Exercise 1 - Basic Level / Junior Developer

This exercise involves implementing a traffic light in code according to the following rules:

- The default state for the traffic light should be red.
- The traffic light should remain in the red state for 2 minutes, then transition to the green state.
- The green state should last for a minimum of 2 minutes and a maximum of 6 minutes, then transition back to the red state.
- The class or classes should accept the minimum and maximum time values for each state as parameters, allowing them to be changed from outside the class.
- When transitioning from green to red, the traffic light should display only a yellow light for 5 seconds.
- When transitioning from red to green, the traffic light should display both yellow and red lights for 5 seconds.
- The traffic light should have a button that pedestrians can push to hasten the transition from green to red.
  - If the traffic light is currently red and the button is pushed, nothing should happen.
  - If the traffic light is currently green and the button is pushed, it should continue to be green for 30 seconds, unless this would exceed the maximum time for the green state. In that case, the maximum time for the green state should take precedence, and the light should turn red and follow the normal behavior for the red state.

Create a simple user interface in any technology, either WinForms, WPF or web, with three light  indicators (red, yellow and green), and a button to represent the button for the pedestrians.  Allow the user to change minimum and maximum times for each state (so its easier to validate that the  solution works without having to wait many minutes), either via configuration file, or via input boxes in  the user interface.

Write unit tests to validate the functionality of the traffic light class.
