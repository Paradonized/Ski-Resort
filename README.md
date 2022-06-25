# Ski-Resort Management
Ski-Resort Management is a console text-management game with design patterns.<br />
<img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/Paradonized/Ski-Resort?style=plastic">

## Game loop
Each turn starts with the start of the day and ends with the player declaring to end the day.
You can make as many actions as you want in a turn (day). At the start of each turn all mandatory events are executed and you get a log, that contains helpful tips and other events. You also get the state of the ski resort and a table, that contains numbers and its corresponding actions. In order to make an action, you need to enter the number of the action.

## Win and Loss conditions
You have 20 turns to reach 1.000.000 in game currency. If you don't reach the goal for 20 turns or your ballance reaches 0 — you lose.

## Screenshots
![ManagementStart](https://user-images.githubusercontent.com/85744016/175785495-6ccc6927-505b-415e-8b90-c100c37f1fed.PNG)
![ManagementGameplay](https://user-images.githubusercontent.com/85744016/175785530-e3f34024-453b-4700-b198-eee6fb09c1b2.PNG)
![ManagementWin](https://user-images.githubusercontent.com/85744016/175296557-28b5b85c-c9b3-485f-b602-85f6f36d0ab0.PNG)
![ManagementLoss](https://user-images.githubusercontent.com/85744016/175785565-0f7f9cdd-8b08-4236-b0a6-8b68e6a6394f.PNG)

## Future improvements
* Random events happening.
* More choices.
* Bigger freedom of choices.
* More ways to gain money.
* System revamp.
* Title screen.

## Known issues
* Balance issues - the player snowballs out of the possibility to loose the game at some point of the game.

# Technical Part
## Design Patterns Used
* Singleton<br />
Used in the SkiResort class in order to work with only one instance of the class. <br />
* Proxy<br />
Used to work indirectly with the SkiResort class. It serves as verification and further work with the class without changing the class.<br />
* Observer<br />
It serves as a log and a way to notify other observers.<br />
