drop database if exists DAT602_Assessment;
create database DAT602_Assessment;
use DAT602_Assessment;    

drop procedure if exists createDB;
delimiter //
create procedure createDB()
begin

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
      `PlayerEmail` varchar(320) DEFAULT NULL,
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
	  `GameDuration` int DEFAULT 120,
      `PlayerID` int DEFAULT NULL,
	  PRIMARY KEY (`GameID`),
      FOREIGN KEY (PlayerID) REFERENCES tbl_player(PlayerID) ON DELETE CASCADE
	  );  
      
    CREATE TABLE `tbl_character` (
	  `CharacterID` int NOT NULL AUTO_INCREMENT,
	  `CharacterName` varchar(15) DEFAULT NULL,
	  `CharacterColour` varchar(25) DEFAULT NULL,
      `CharacterScore` int DEFAULT 0,
      `TileID` int DEFAULT NULL,
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
	  `ChatText` varchar(35) DEFAULT NULL,
	  `ChatDateTime` varchar(25) DEFAULT NULL,/*use NOW() and insert into it*/
      `PlayerID` int DEFAULT NULL,
	  PRIMARY KEY (`ChatID`),
      FOREIGN KEY (PlayerID) REFERENCES tbl_player(PlayerID) ON DELETE SET NULL
	  );      
       
end //
delimiter ;   

drop procedure if exists editDB;
delimiter //
create procedure editDB()
begin

	/*------------------------------------->> INSERT STATEMENTS <<-------------------------------------*/   

	INSERT INTO `tbl_tile`(`TileLocation`)
	VALUES (00);
	INSERT INTO `tbl_tile`(`TileLocation`)
	VALUES (01);
	INSERT INTO `tbl_tile`(`TileLocation`)
	VALUES (02);

	INSERT INTO `tbl_item`(`ItemName`,`ItemValue`,`ItemPhoto`)
	VALUES ('Apple', 2, '://FilePath//Photo');
	INSERT INTO `tbl_item`(`ItemName`,`ItemValue`,`ItemPhoto`)
	VALUES ('Knife', 3, '://FilePath//Photo');
	INSERT INTO `tbl_item`(`ItemName`,`ItemValue`,`ItemPhoto`)
	VALUES ('Trap', 0, '://FilePath//Photo');
    
	INSERT INTO `tbl_player`(`PlayerUsername`,`PlayerPassword`,`PlayerEmail`)
	VALUES ('User1','Password','User1@email.com');
	INSERT INTO `tbl_player`(`PlayerUsername`,`PlayerPassword`,`PlayerEmail`)
	VALUES ('User2','Password','User2@email.com');
	INSERT INTO `tbl_player`(`PlayerUsername`,`PlayerPassword`,`PlayerEmail`)
	VALUES ('User3','Password','User3@email.com');

	INSERT INTO `tbl_game`(`GameName`,`GameDuration`,`PlayerID`)
	VALUES ('Game1','600',1);
	INSERT INTO `tbl_game`(`GameName`,`GameDuration`,`PlayerID`)
	VALUES ('Game2','600',2);
	INSERT INTO `tbl_game`(`GameName`,`GameDuration`,`PlayerID`)
	VALUES ('Game3','600',3);

	INSERT INTO `tbl_character`(`CharacterName`,`CharacterColour`,`TileID`,`GameID`,`PlayerID`)
	VALUES ('Travis','blue',1,1,1);
	INSERT INTO `tbl_character`(`CharacterName`,`CharacterColour`,`TileID`,`GameID`,`PlayerID`)
	VALUES ('Bob','blue',2,1,2);
	INSERT INTO `tbl_character`(`CharacterName`,`CharacterColour`,`TileID`,`GameID`,`PlayerID`)
	VALUES ('Gary','blue',3,1,3);
	
	INSERT INTO `tbl_tileAsset`(`TileID`,`ItemID`,`GameID`)
	VALUES (1,1,1);
	INSERT INTO `tbl_tileAsset`(`TileID`,`ItemID`,`GameID`)
	VALUES (2,2,2);
	INSERT INTO `tbl_tileAsset`(`TileID`,`ItemID`,`GameID`)
	VALUES (3,3,1);

	INSERT INTO `tbl_backpack`(`CharacterID`,`ItemID`)
	VALUES (1,1);
	INSERT INTO `tbl_backpack`(`CharacterID`,`ItemID`)
	VALUES (1,2);
	INSERT INTO `tbl_backpack`(`CharacterID`,`ItemID`)
	VALUES (1,3);

	INSERT INTO `tbl_chat`(`ChatText`,`ChatDateTime`,`PlayerID`)
	VALUES('Hello',Now(),'1');
	INSERT INTO `tbl_chat`(`ChatText`,`ChatDateTime`,`PlayerID`)
	VALUES('Hello world!',Now(),'2');
	INSERT INTO `tbl_chat`(`ChatText`,`ChatDateTime`,`PlayerID`)
	VALUES('How are you?',Now(),'3');
    
    /*------------------------------------->> UPDATE STATEMENTS <<-------------------------------------*/  
    
    UPDATE `tbl_player` SET IsAdmin = TRUE WHERE PlayerID = 1;
	UPDATE `tbl_player` SET LoginAttempts = LoginAttempts + 1 WHERE PlayerID = 2;
	UPDATE `tbl_player` SET Highscore = 48 WHERE PlayerID = 3;
	UPDATE `tbl_tile` SET TileLocation = 3 WHERE TileID = 12;
	UPDATE `tbl_character` SET CharacterScore = 30 WHERE CharacterID = 1;
	UPDATE `tbl_character` SET CharacterName = "Harry" WHERE CharacterID = 2;
	UPDATE `tbl_character` SET GameID = 2 WHERE CharacterID = 3;
	UPDATE `tbl_tileAsset` SET TileID = 2 WHERE tileAssetID = 12;
	UPDATE `tbl_backpack` SET ItemID = 3 WHERE BackpackID = 1;
	UPDATE `tbl_chat` SET ChatText = "*Censored*" WHERE ChatID = 1;
	UPDATE `tbl_game` SET GameName = "My Game 1" WHERE GameID = 1;
	UPDATE `tbl_game` SET GameDuration = 200 WHERE GameID = 3;
	UPDATE `tbl_item` SET ItemValue = 10 WHERE ItemID = 1;
    
	/*------------------------------------->> DELETE STATEMENTS <<-------------------------------------*/  

	DELETE FROM `tbl_tileAsset` WHERE tileAssetID = 1;
	DELETE FROM `tbl_character` WHERE CharacterName = "Travis";
	DELETE FROM `tbl_player` WHERE PlayerUsername = "User1";
	DELETE FROM `tbl_tile` WHERE TileLocation = 0;
	DELETE FROM `tbl_backpack` WHERE ItemID = 2;
	DELETE FROM `tbl_chat` WHERE ChatText = "Hello world!";
	DELETE FROM `tbl_game` WHERE GameName = "Game3";
	DELETE FROM `tbl_item` WHERE ItemName = "Apple";
    
	/*------------------------------------->> SELECT STATEMENTS <<-------------------------------------*/  
    
	SELECT * FROM `tbl_tile`;
    SELECT * FROM `tbl_player`;
    SELECT * FROM `tbl_character`;
    SELECT * FROM `tbl_tileAsset`;
	SELECT * FROM `tbl_backpack`;
    SELECT * FROM `tbl_chat`;
    SELECT * FROM `tbl_game`;
    SELECT * FROM `tbl_item`;
    
end //
delimiter ;   

CALL createDB();  
CALL editDB();   

