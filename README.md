# Amazing Adventures

### Game description

<h4>Idea</h4> 

I created a multiplayer game where characters move around a tiled map, collecting items and competing with other characters. To achieve this, I used a MySQL database along with C# to create an intuitive frontend and efficient backend. 

<img src="https://raw.githubusercontent.com/travisbyr/amazingAdventures/main/Documentation%20Images/gameplay.png?token=AOUNHPOXSMYHC6YJULT74QTBCSJBC">

#### Gameplay 

- The aim of the game is to collect as many items as possible by moving around a tiled map. While doing this, characters must cautiously move around   the map, avoiding trapped tiles. If a character moves onto a trapped tile the character will die and lose the game. 

- Upon entering into the game, the character will start on the home tile (alternative tile if taken by an existing character). 

- Each tile has a maximum of one item or trap. Items and traps are spawned randomly onto tiles. 

- The overall game will end when all the characters have quit or died. 

- Characters can move up, down, left, or right using arrow keystrokes or the buttons provided.

- If a character leaves the game and the game is still open, their progress will be saved, and they can resume.

- If a tile is occupied by a character, another character cannot be on the same tile.

- When a player tries to join a game, they will be asked to configure their character before joining.                                    

- The game has a maximum time duration. If the game has not been completed before the time runs out, the character scores are calculated, the character with the highest score wins the game.

- Certain players can have administrator abilities. These abilities do not give the player a gameplay advantage but give the player the ability to manage/monitor other players.
- <img src="https://raw.githubusercontent.com/travisbyr/amazingAdventures/main/Documentation%20Images/login.png?token=AOUNHPLLHXBXCYWKZ4WLM63BCSJCG">

#### Login and Registration

- Upon logging in, if a player tries to log in with a username that is not established in the database, they will be given the option to register.

- If the player does have an existing account, they will be given the option to try to login again with the correct credentials.

- If the player attempts to login with a valid username, but the password is incorrect, they will be given 5 attempts before the account will be locked.

- If a player account is locked the player will have to ask an Administrator to unlock the account.

  <img src="https://raw.githubusercontent.com/travisbyr/amazingAdventures/main/Documentation%20Images/lobby.png?token=AOUNHPPT6T6C3KMGMW3I42DBCSJDM">

#### Lobby

- Inside the lobby, players will be shown the total amount of players and available games they can join.

- Global chat is also available for any player to use.

- Players can also create a game where other players can join.

- If a player is an administrator, they will have access to admin settings. 

- Players also have access to their settings, where they can change their username, password etc.

#### Administration Interface

- After selecting the admin console, administrators will be shown a total list of players and active games.

- From here administrators can lock and change player accounts and delete active games.

- Only certain players will be given administrator abilities.

