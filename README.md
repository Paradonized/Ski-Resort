# Ski-Resort Management
Ski-Resort Management is a console text-management game with design patterns.

## Game loop
Each turn starts with the start of the day and ends with the player declaring to end the day.
You can make as many actions as you want in a turn (day). At the start of each turn all mandatory events are executed and you get a log, that contains helpful tips and other events. You also get the state of the ski resort and a table, that contains numbers and its corresponding actions. In order to make an action, you need to enter the number of the action.

## Win and Loss conditions
You have 20 turns to reach 1.000.000 in game currency. If you don't reach the goal for 20 turns or your ballance reaches 0 — you lose.

## Screenshots
![ManagementStart](https://user-images.githubusercontent.com/85744016/175295258-663e2954-db68-45bf-a0f8-94dc5d7df676.PNG)
![ManagementGameplay](https://user-images.githubusercontent.com/85744016/175295276-f56bdc59-eb99-4f27-b7f1-ab1e2d451a07.PNG)
![ManagementWin](https://user-images.githubusercontent.com/85744016/175296557-28b5b85c-c9b3-485f-b602-85f6f36d0ab0.PNG)
![ManagementLoss](https://user-images.githubusercontent.com/85744016/175296569-52d9269c-fe27-4c88-9eee-6c4ac63c24c5.PNG)

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
