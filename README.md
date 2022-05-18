# About
Ski-Resort is a console text-management game with design patterns.

## Game loop
Each turn starts with the start of the day and ends with the player declaring to end the day.
You can make as many actions as you want in a turn (day). At the start of each turn all mandatory events are executed and you get a log, that contains helpful tips and other events. You also get the state of the ski resort and a table, that contains numbers and its corresponding actions. In order to make an action, you need to enter the number of the action. 
## Win and Loss conditions
You have 20 turns to reach 1.000.000 in game currency. If you don't reach the goal for 20 turns or your ballance reaches 0 — you lose.
# Technical Part
## Design Patterns Used
* Singleton<br />
Used in the SkiResort class in order to work with only one instance of the class. <br />
* Proxy<br />
Used to work indirectly with the SkiResort class. It serves as verification and further work with the class without changing the class.<br />
* Observer<br />
It serves as a log and a way to notify other observers.<br />
