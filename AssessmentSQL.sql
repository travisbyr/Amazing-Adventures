DROP DATABASE IF EXISTS DAT602_Assessment;
CREATE DATABASE DAT602_Assessment;
USE DAT602_Assessment;    

DROP PROCEDURE IF EXISTS createDB;
DELIMITER //
CREATE PROCEDURE createDB()
BEGIN

	/*------------------------------------->> DROP TABLE STATEMENTS <<-------------------------------------*/   
	
    DROP TABLE IF EXISTS `tbl_backpack`;
	DROP TABLE IF EXISTS `tbl_tileAsset`;
    DROP TABLE IF EXISTS `tbl_item`;
    DROP TABLE IF EXISTS `tbl_chat`;
    DROP TABLE IF EXISTS `tbl_character`;
    DROP TABLE IF EXISTS `tbl_game`;
	DROP TABLE IF EXISTS `tbl_tile`;
	DROP TABLE IF EXISTS `tbl_player`;
    
    	/*------------------------------------->> CREATE TABLE STATEMENTS <<-------------------------------------*/   
START TRANSACTION;
	CREATE TABLE `tbl_tile` (
	  `TileID` int NOT NULL AUTO_INCREMENT,
	  `TileLocation` int DEFAULT NULL,
	  PRIMARY KEY (`TileID`) 
	  );     
      
	CREATE TABLE `tbl_item` (
	  `ItemID` int NOT NULL AUTO_INCREMENT,
	  `ItemName` varchar(25) DEFAULT NULL,
	  `ItemValue` int DEFAULT 0,
      `ItemPhoto` varchar(50) DEFAULT NULL,
	  PRIMARY KEY (`ItemID`)
	  ); 
    
    CREATE TABLE `tbl_player` (
	  `PlayerID` int NOT NULL AUTO_INCREMENT,
	  `PlayerUsername` varchar(15) DEFAULT NULL,
	  `PlayerPassword` varchar(25) DEFAULT NULL,
      `PlayerEmail` varchar(320) DEFAULT "",
      `Locked` boolean DEFAULT false,
      `Highscore` int DEFAULT 0,
      `IsAdmin` boolean DEFAULT false,
      `LoggedIn` boolean DEFAULT false,
      `LoginAttempts` int(1) DEFAULT 0,
      `CurrentlyPlaying` boolean DEFAULT false,
	  PRIMARY KEY (`PlayerID`)
	  );
      
	CREATE TABLE `tbl_game` (
	  `GameID` int NOT NULL AUTO_INCREMENT, 
	  `GameName` varchar(25) DEFAULT NULL,
      `PlayerID` int DEFAULT NULL,
	  PRIMARY KEY (`GameID`),
      FOREIGN KEY (PlayerID) REFERENCES tbl_player(PlayerID) ON DELETE CASCADE
	  );  
      
    CREATE TABLE `tbl_character` (
	  `CharacterID` int NOT NULL AUTO_INCREMENT,
	  `CharacterName` varchar(15) DEFAULT NULL,
	  `CharacterColour` varchar(25) DEFAULT NULL,
      `CharacterScore` int DEFAULT 0,
      `CharacterLocation` varchar(10) DEFAULT NULL,
      `TileID` int DEFAULT 68,
      `GameID` int DEFAULT NULL,
      `PlayerID` int DEFAULT NULL,
	  PRIMARY KEY (`CharacterID`),
      FOREIGN KEY (TileID) REFERENCES tbl_tile(TileID) ON DELETE CASCADE,
      FOREIGN KEY (GameID) REFERENCES tbl_game(GameID) ON DELETE CASCADE,
      FOREIGN KEY (PlayerID) REFERENCES tbl_player(PlayerID) ON DELETE CASCADE
	  );  
      
	CREATE TABLE `tbl_tileAsset` (
	  `tileAssetID` int NOT NULL AUTO_INCREMENT,
      `TileID` int DEFAULT NULL,
      `ItemID` int DEFAULT NULL,
	  `GameID` int DEFAULT NULL,
	  PRIMARY KEY (`tileAssetID`),
	  FOREIGN KEY (TileID) REFERENCES tbl_tile(TileID) ON DELETE CASCADE,
      FOREIGN KEY (ItemID) REFERENCES tbl_item(ItemID) ON DELETE CASCADE,
      FOREIGN KEY (GameID) REFERENCES tbl_game(GameID) ON DELETE CASCADE 
	  );        
      
	CREATE TABLE `tbl_backpack` (
	  `BackpackID` int NOT NULL AUTO_INCREMENT,
      `CharacterID` int DEFAULT NULL,
      `ItemID` int DEFAULT NULL,
	  PRIMARY KEY (`BackpackID`),
	  FOREIGN KEY (CharacterID) REFERENCES tbl_character(CharacterID) ON DELETE CASCADE,
      FOREIGN KEY (ItemID) REFERENCES tbl_item(ItemID) ON DELETE CASCADE
	  );        
      
	CREATE TABLE `tbl_chat` (
	  `ChatID` int NOT NULL AUTO_INCREMENT,
	  `ChatText` varchar(50) DEFAULT NULL,																		 -- CHAT LENGTH CHANGED
	  `ChatDateTime` varchar(25) DEFAULT NULL,
      `PlayerID` int DEFAULT NULL,
	  PRIMARY KEY (`ChatID`),
      FOREIGN KEY (PlayerID) REFERENCES tbl_player(PlayerID) ON DELETE SET NULL
	  );      
COMMIT; 
end //
DELIMITER ; 

DROP PROCEDURE IF EXISTS modifyDB;
DELIMITER //
CREATE PROCEDURE modifyDB() 
BEGIN
DECLARE count INT DEFAULT 1;
START TRANSACTION;
   WHILE count <= 135 DO
	INSERT INTO `tbl_tile`(`TileLocation`) -- Create 135 tiles for all games to use
	VALUES (count);
    SET count = count + 1;
   END WHILE;  
	-- Create items for all games to use
    INSERT INTO `tbl_item`(`ItemName`,`ItemValue`,`ItemPhoto`)
	VALUES ('FirstAid', 1, '..\\..\\..\\itemImages\\firstaid.png');
	INSERT INTO `tbl_item`(`ItemName`,`ItemValue`,`ItemPhoto`)
	VALUES ('Apple', 2, '..\\..\\..\\itemImages\\apple.png');
	INSERT INTO `tbl_item`(`ItemName`,`ItemValue`,`ItemPhoto`)
	VALUES ('Knife', 3, '..\\..\\..\\itemImages\\knife.png');
    INSERT INTO `tbl_item`(`ItemName`,`ItemValue`,`ItemPhoto`)
	VALUES ('Trap', 0, '..\\..\\..\\itemImages\\trap.png');
    
    INSERT INTO `tbl_player`(`PlayerUsername`,`PlayerPassword`,`PlayerEmail`, `IsAdmin`)
	VALUES ('User1','Password','User1@email.com', true);
COMMIT;
end //
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkUsername`(pUsername VARCHAR(15))
BEGIN
START TRANSACTION;
  IF EXISTS (SELECT * 
     FROM tbl_player
     WHERE PlayerUsername = pUsername) THEN		-- If player exists, set message as an unavaliable username.
     SELECT 'unavaliableUsername' AS MESSAGE;
  ELSE 
	 SELECT 'avaliableUsername' AS MESSAGE;
  END IF;
  COMMIT;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `accountCreate`(pUsername VARCHAR(15), pPassword VARCHAR(25))
BEGIN
START TRANSACTION;
	 SELECT 'ACCOUNT CREATED' AS MESSAGE;
     INSERT INTO tbl_player(PlayerUsername, PlayerPassword, Locked, Highscore, IsAdmin, LoggedIn, LoginAttempts, CurrentlyPlaying)
     VALUE (pUsername, pPassword, false,0,false,false,0,false); 
COMMIT;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `accountLogin`(pUsername VARCHAR(15), pPassword VARCHAR(25))
BEGIN
START TRANSACTION;
  IF EXISTS (SELECT * FROM tbl_player WHERE PlayerUsername = pUsername and Locked = true) THEN 
	SELECT 'maxLoginAttempts' AS MESSAGE; -- If the account is locked
        
	ELSEIF EXISTS (SELECT * FROM tbl_player WHERE PlayerUsername = pUsername AND LoginAttempts>=5) THEN 
		UPDATE tbl_player SET Locked = true WHERE PlayerUsername = pUsername; 
        SELECT 'maxLoginAttempts' AS MESSAGE; -- If the account has 5 login attempts, then lock it.
        
	ELSEIF EXISTS (SELECT * FROM tbl_player WHERE PlayerUsername = pUsername AND PlayerPassword = pPassword) THEN 
		UPDATE tbl_player SET loginAttempts = 0, LoggedIn = true WHERE PlayerUsername = pUsername; 
        SELECT 'SLogin' AS MESSAGE; -- If account is not locked and login attempts < 5, then log the user in
  ELSE 
	UPDATE tbl_player SET loginAttempts = loginAttempts + 1 WHERE PlayerUsername = pUsername; 
    SELECT 'NLogin' AS MESSAGE; -- If incorrect password, and account is not locked, +1 to login attempts
  END IF;
COMMIT;  
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `gameCreation`(pUsername VARCHAR(15), pGamename VARCHAR(25))
BEGIN
START TRANSACTION;
  IF EXISTS (SELECT * FROM tbl_game WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername)) THEN 
	SELECT 'gameAlreadyCreated' AS MESSAGE; -- If player has created a game already
  ELSE -- otherwise create a game
	INSERT INTO tbl_game(GameName, PlayerID)
    VALUE (pGamename, (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername));
    SELECT 'NEW GAME CREATED' AS MESSAGE;
  END IF;
COMMIT;  
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `listOfGames`()
BEGIN
START TRANSACTION;
	IF EXISTS (SELECT GameID, GameName FROM tbl_game) THEN -- Show list of games
		SELECT 'gamesAvaliable' AS MESSAGE, GameID, GameName FROM tbl_game;
	ELSE 
		SELECT 'NO GAMES' AS MESSAGE, 0 AS GameID, 'NO GAMES' AS GameName FROM tbl_game; -- If no games 
	END IF;
COMMIT;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `characterJoinGame`(pGameNumber INT(50), pCharacterName VARCHAR(15), pCharacterColour VARCHAR(25), pUsername VARCHAR(15))
BEGIN
START TRANSACTION;
	 UPDATE tbl_player SET CurrentlyPlaying = TRUE WHERE PlayerUsername = pUsername; -- Set currently playing to true for player
     INSERT INTO tbl_character(CharacterName, CharacterColour, GameID, PlayerID) -- Create the character in the table
	 VALUE (pCharacterName, pCharacterColour, pGameNumber, (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername)); 
	 SELECT 'characterJoins' AS MESSAGE;
COMMIT;     
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `accountLogout`(pUsername VARCHAR(15))
BEGIN
START TRANSACTION;
 IF EXISTS (SELECT * FROM tbl_player WHERE PlayerUsername = pUsername) THEN 
	SELECT 'ACCOUNT LOGGED OUT' AS MESSAGE; -- If username is valid log out the player
	UPDATE tbl_player SET LoggedIn = false WHERE PlayerUsername = pUsername;
ELSE
	SELECT 'INVALID ACCOUNT' AS MESSAGE;
	END IF;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkCharacterLocation`(pTile INT(50), pUsername VARCHAR(15), pGameNumber INT(50))
BEGIN 
START TRANSACTION;
IF (pTile <> 68) THEN -- If proposed tile is not the home tile
	IF EXISTS (SELECT TileID, GameID FROM tbl_character WHERE TileID = pTile AND GameID = pGameNumber) THEN 
		SELECT 'invalidMove' AS MESSAGE;       
	 ELSE
		UPDATE tbl_character SET TileID = (SELECT TileID FROM tbl_tile WHERE TileID = pTile) WHERE PlayerID = (SELECT PlayerID FROM tbl_player where PlayerUsername = pUsername) AND GameID = pGameNumber;
		-- SELECT 'succMove' AS MESSAGE;
	 END IF;
ELSEIF (pTile = 68) THEN -- If proposed tile is the home tile
	 UPDATE tbl_character SET TileID = (SELECT TileID FROM tbl_tile WHERE TileID = pTile) WHERE PlayerID = (SELECT PlayerID FROM tbl_player where PlayerUsername = pUsername) AND GameID = pGameNumber;
	 -- SELECT 'succMove' AS MESSAGE;
END IF; 

-- If a item is on the proposed tile to move to
IF EXISTS (SELECT TileID, GameID FROM tbl_tileAsset WHERE TileID = pTile AND GameID = pGameNumber)  THEN 
	 -- If the item is a trap
	 IF EXISTS (SELECT ItemID FROM tbl_tileAsset WHERE ItemID = 4 AND GameID = pGameNumber AND TileID = pTile) THEN
		SELECT 'trapFound' AS MESSAGE; -- Set the players higscore to character score if character score is greater
		SELECT CharacterScore FROM tbl_character WHERE GameID = pGameNumber AND PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) INTO @score;
		IF (@score > (SELECT HighScore FROM tbl_player WHERE PlayerUsername = pUsername)) THEN-- If character score is > highscore
			UPDATE tbl_player SET HighScore = @score WHERE PlayerUsername = pUsername;
		END IF;
		UPDATE tbl_player SET CurrentlyPlaying = FALSE WHERE PlayerUsername = pUsername;
        DELETE FROM tbl_tileAsset WHERE TileID = pTile AND GameID = pGameNumber;
        DELETE FROM tbl_character WHERE TileID = pTile AND GameID = pGameNumber;
    -- If item is not a trap
    ELSEIF EXISTS (SELECT ItemID FROM tbl_tileAsset WHERE GameID = pGameNumber AND TileID = pTile AND ItemID <> 4) THEN
		SELECT 'itemFound' AS MESSAGE;
		INSERT INTO tbl_backpack(CharacterID, ItemID) -- If an item is found put it in the chracters backpack and remove the item from playing board
		VALUE ((SELECT CharacterID FROM tbl_character WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber),(SELECT ItemID FROM tbl_tileAsset WHERE TileID = pTile AND GameID = pGameNumber));
		UPDATE tbl_character SET CharacterScore = CharacterScore + (SELECT ItemValue FROM tbl_item WHERE ItemID = (SELECT ItemID FROM tbl_tileAsset WHERE TileID = pTile AND GameID = pGameNumber)) WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername);
		DELETE FROM tbl_tileAsset WHERE TileID = pTile AND GameID = pGameNumber;
	END IF;  
END IF;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `characterCurrentTile`(pUsername VARCHAR(15), pGameNumber INT(50))
BEGIN
START TRANSACTION;
    SELECT TileID AS cTile FROM tbl_character WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;
COMMIT;    
END ;; 
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `characterQuits`(pTile INT(50), pUsername VARCHAR(15), pGameNumber INT(50))
BEGIN 
START TRANSACTION;
	SELECT CharacterScore FROM tbl_character WHERE GameID = pGameNumber AND PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) INTO @score;
	IF (@score > (SELECT HighScore FROM tbl_player WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername))) THEN
		UPDATE tbl_player SET HighScore = @score WHERE PlayerUsername = pUsername;
	END IF;

	UPDATE tbl_character SET CharacterLocation = pTile WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;
    UPDATE tbl_player SET CurrentlyPlaying = FALSE WHERE PlayerUsername = pUsername;
    UPDATE tbl_character SET TileID = NULL WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;
    SELECT 'CHARACTER HAS LEFT THE GAME' AS MESSAGE;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `characterRejoins`(pUsername VARCHAR(15), pGameNumber INT(50))
BEGIN
	DECLARE go bool DEFAULT TRUE;	
    START TRANSACTION;
    -- If a players character exists in the game it wants to join, then set players currently playing to true
     IF EXISTS (SELECT PlayerID FROM tbl_character WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber) THEN
     
		SELECT CharacterLocation FROM tbl_character WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber LIMIT 1 INTO @tileSelected;
        
        UPDATE tbl_player SET CurrentlyPlaying = TRUE WHERE PlayerUsername = pUsername;
        
        WHILE go = TRUE DO
        
			IF (SELECT TileID FROM tbl_character WHERE TileID = @tileSelected AND TileID <> 68) THEN -- If a character is on the tile that a player is returning to after leaving and its not the home tile
				SET @tileSelected = FLOOR(RAND()*(135-1+1))+1; -- then randomly give it a tile
			END IF;
            
			IF NOT EXISTS (SELECT TileID FROM tbl_character WHERE TileID = @tileSelected AND TileID <> 68) THEN -- if the characters tile it is returning to doesnt have a player on it.
				SELECT "yesCharacter" AS MESSAGE;
				UPDATE tbl_character SET TileID = @tileSelected WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;
				UPDATE tbl_character SET CharacterLocation = NULL WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;
				SET go = FALSE;      
				IF (@tileSelected = 68) THEN -- If returning tile is the home tile
					SELECT "yesCharacter" AS MESSAGE;
					UPDATE tbl_character SET TileID = 68 WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;
					UPDATE tbl_character SET CharacterLocation = NULL WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;
                    SET go = FALSE; 
                END IF;    
                
			END IF;     
		END WHILE;
	ELSE 
 		SELECT "noCharacter" AS MESSAGE;
	 END IF;
COMMIT;     
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `gameClose`(pUsername VARCHAR(15))
BEGIN
DECLARE theCount INT DEFAULT 1;
START TRANSACTION;
SELECT COUNT(CharacterName) FROM tbl_character WHERE GameID = (SELECT GameID FROM tbl_game WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername)) INTO @pCount;
IF (@pCount != 0) THEN 
	WHILE theCount <= @pCount DO
		SELECT PlayerID FROM tbl_character WHERE GameID = (SELECT GameID FROM tbl_game WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername)) LIMIT 1 INTO @cName;
		IF ((SELECT CharacterScore FROM tbl_character WHERE PlayerID = @cName) > (SELECT HighScore FROM tbl_player WHERE PlayerID = @cName)) THEN -- If character score is > highscore
			UPDATE tbl_player SET HighScore = (SELECT CharacterScore FROM tbl_character WHERE PlayerID = @cName) WHERE PlayerID = @cName;
		END IF;
	DELETE FROM tbl_character WHERE PlayerID = @cName; 
    SET theCount = theCount + 1;
   END WHILE;  
END IF;
	SELECT 'gameClosed' AS MESSAGE;
    SELECT GameID FROM tbl_game WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) INTO @selectedGame;    
	UPDATE tbl_player SET CurrentlyPlaying = FALSE WHERE PlayerID = (SELECT PlayerID FROM tbl_character WHERE GameID = @selectedGame);
	DELETE FROM tbl_game WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername); 
COMMIT;    
END ;;
DELIMITER ;	

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `viewOnlinePlayers`()
BEGIN
START TRANSACTION;
	SELECT Highscore, PlayerUsername FROM tbl_player WHERE LoggedIn = true;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `addItems`(pGameNumber INT(50))
BEGIN
    DECLARE x bool DEFAULT TRUE;	
	DECLARE randomTile INT DEFAULT 1;
    DECLARE randomItem INT DEFAULT 1;
    DECLARE itemsInGame INT DEFAULT 8;
    START TRANSACTION;
    SELECT COUNT(ItemID) FROM tbl_item INTO @itemsAmount;
        WHILE x = TRUE DO
            SELECT COUNT(tileAssetID) FROM tbl_tileAsset WHERE GameID = pGameNumber INTO @gameItems;
            SELECT COUNT(ItemID) FROM tbl_tileAsset WHERE GameID = pGameNumber AND ItemID = 4 INTO @trapCount;
			IF(@gameItems < itemsInGame) THEN
				SET randomTile = FLOOR(RAND()*(135-1+1))+1;
				SET randomItem = FLOOR(RAND()*(@itemsAmount-1+1))+1;
                -- If a tile already has an item on it, randomly assign a tile to that item until only one item is on a tile
                IF NOT EXISTS(SELECT TileID FROM tbl_tileAsset WHERE (TileID = randomTile) AND GameID = pGameNumber) THEN
					IF NOT EXISTS(SELECT TileID FROM tbl_character WHERE GameID = pGameNumber AND (TileID = randomTile)) THEN
						IF (randomItem != 4) THEN
							INSERT INTO tbl_tileAsset(TileID,ItemID,GameID) 
							VALUE (randomTile, randomItem, pGameNumber); 
                        ELSEIF (@trapCount < 3 ) THEN
							INSERT INTO tbl_tileAsset(TileID,ItemID,GameID) 
							VALUE (randomTile, randomItem, pGameNumber); 
						END IF;
                    END IF;
				END IF;
			ELSE
				SET x = FALSE;
                SELECT 'ITEMS ADDED TO GAME' AS MESSAGE;
            END IF;
		END WHILE;
      COMMIT;  
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `globalChat`(pChatMessage VARCHAR(50), pUsername VARCHAR(15))
BEGIN
START TRANSACTION;
    INSERT INTO tbl_chat(ChatText, ChatDateTime, PlayerID)
	VALUE (pChatMessage, NOW(), (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername));
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `viewGlobalChat`()
BEGIN
START TRANSACTION;
    IF EXISTS (SELECT ChatID FROM tbl_chat) THEN
		SELECT tbl_chat.ChatText, tbl_chat.ChatDateTime, tbl_player.PlayerUsername, 'foundChatText' AS MESSAGE
		FROM tbl_chat 
		INNER JOIN tbl_player ON tbl_chat.PlayerID = tbl_player.PlayerID
        ORDER BY tbl_chat.ChatDateTime ASC;
	ELSE 
		SELECT 'noChatText' AS MESSAGE;
	END IF;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `changeEmail`(pUsername VARCHAR(15), pEmail VARCHAR(50))
BEGIN
START TRANSACTION;
	UPDATE tbl_player SET PlayerEmail = pEmail WHERE PlayerUsername = pUsername;
    SELECT 'EMAIL CHANGED' AS MESSAGE;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `changePassword`(pUsername VARCHAR(15), pPassword VARCHAR(25))
BEGIN
START TRANSACTION;
	UPDATE tbl_player SET PlayerPassword = pPassword WHERE PlayerUsername = pUsername;
    SELECT 'PASSWORD CHANGED' AS MESSAGE;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `changeUsername`(pUsername VARCHAR(15), pNewUsername VARCHAR(15))
BEGIN
START TRANSACTION;
	UPDATE tbl_player SET PlayerUsername = pNewUsername WHERE PlayerUsername = pUsername;
    SELECT 'EMAIL CHANGED' AS MESSAGE;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `adminCloseGame`(pGameNumber INT(50))
BEGIN
DECLARE theCount INT DEFAULT 1;
START TRANSACTION;
SELECT COUNT(CharacterName) FROM tbl_character WHERE GameID = pGameNumber INTO @pCount;
IF (@pCount != 0) THEN
	WHILE theCount <= @pCount DO
		SELECT PlayerID FROM tbl_character WHERE GameID = pGameNumber LIMIT 1 INTO @cName;
		IF ((SELECT CharacterScore FROM tbl_character WHERE PlayerID = @cName) > (SELECT HighScore FROM tbl_player WHERE PlayerID = @cName)) THEN
			UPDATE tbl_player SET HighScore = (SELECT CharacterScore FROM tbl_character WHERE PlayerID = @cName) WHERE PlayerID = @cName; -- If character score is > highscore
		END IF;
	DELETE FROM tbl_character WHERE PlayerID = @cName; 
    SET theCount = theCount + 1;
   END WHILE;  
END IF;

	UPDATE tbl_player SET CurrentlyPlaying = FALSE WHERE PlayerID = (SELECT PlayerID FROM tbl_character WHERE GameID = pGameNumber);
	DELETE FROM tbl_game WHERE GameID = pGameNumber;
    SELECT 'gameClosed' AS MESSAGE;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `clearGlobalChat`()
BEGIN
START TRANSACTION;
	TRUNCATE TABLE tbl_chat;
	SELECT 'chatCleared' AS MESSAGE;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `deletePlayer`(pUsername VARCHAR(15))
BEGIN
START TRANSACTION;
	DELETE FROM tbl_player WHERE PlayerUsername = pUsername;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `listOfPlayers`()
BEGIN
START TRANSACTION;
	SELECT PlayerUsername FROM tbl_Player;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkCharacter`(pUsername VARCHAR(15), pGameNumber INT(50))
BEGIN
START TRANSACTION;
  IF EXISTS (SELECT CharacterID FROM tbl_Character WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber) THEN
     SELECT 'characterIsMade' AS MESSAGE, CharacterName AS CNAME FROM tbl_Character WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;
  ELSE 
	 SELECT 'characterIsNotMade' AS MESSAGE, 'noName' AS CNAME;
  END IF;
COMMIT;  
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getColour`(pUsername VARCHAR(15), pGameNumber INT(50))
BEGIN
START TRANSACTION;
	SELECT CharacterColour FROM tbl_Character WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;
COMMIT;  
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getCharacters`(pGameNumber INT(50), pUsername VARCHAR(15))
BEGIN
START TRANSACTION;
	SELECT CharacterID, CharacterName, CharacterColour, TileID FROM tbl_Character WHERE GameID = pGameNumber AND PlayerID <> (SELECT PlayerID FROM tbl_Player WHERE PlayerUsername = pUsername);
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkAdmin`(pUsername VARCHAR(15))
BEGIN
START TRANSACTION;
IF (SELECT IsAdmin FROM tbl_Player WHERE PlayerUsername = pUsername = true) THEN
	SELECT 'isAdmin' AS MESSAGE;
else
	SELECT 'notAdmin' AS MESSAGE;
END IF;
COMMIT;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getGameItems`(pGameNumber INT(50))
BEGIN
START TRANSACTION;
	SELECT tbl_tileAsset.TileID AS ID, tbl_item.ItemPhoto AS PIC, tbl_item.itemName AS NME, tbl_item.ItemValue AS VAL
	FROM tbl_tileAsset
	INNER JOIN tbl_item ON tbl_tileAsset.ItemID=tbl_item.ItemID
	WHERE tbl_tileAsset.GameID = pGameNumber;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getCharacterScore`(pUsername VARCHAR(25), pGameNumber INT(50))
BEGIN
START TRANSACTION;
	SELECT CharacterScore FROM tbl_character WHERE PlayerID = (SELECT PlayerID FROM tbl_player WHERE PlayerUsername = pUsername) AND GameID = pGameNumber;    
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkGameExists`(pGameNumber INT(50))
BEGIN
START TRANSACTION;
	IF EXISTS (SELECT GameID FROM tbl_game WHERE GameID = pGameNumber) THEN
		SELECT 'gameExists' AS MESSAGE;
	ELSE
		SELECT 'gameClosed' AS MESSAGE;
	END IF;
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getPlayerInfo`(pUsername VARCHAR(25))
BEGIN
START TRANSACTION;
	SELECT PlayerPassword, PlayerEmail, Locked, Highscore, IsAdmin FROM tbl_player WHERE PlayerUsername = pUsername;   
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `updatePlayerInfo`(pUsername VARCHAR(25), nUsername VARCHAR(25), nPassword VARCHAR(25), nEmail VARCHAR(25), nHighscore INT(25), nIsAdmin BOOLEAN, nLocked BOOLEAN)
BEGIN
START TRANSACTION;
	UPDATE tbl_player
	SET PlayerUsername = nUsername, PlayerEmail = nEmail, Locked = nLocked, Highscore = nHighscore, IsAdmin = nIsAdmin, Locked = nLocked
	WHERE PlayerUsername = pUsername;   
COMMIT;    
END ;;
DELIMITER ;

DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getGameCharacterScores`(pGameNumber INT(50))
BEGIN	
START TRANSACTION;
	SELECT CharacterName, CharacterScore FROM tbl_character WHERE GameID = pGameNumber; 
COMMIT;    
END ;;
DELIMITER ;
