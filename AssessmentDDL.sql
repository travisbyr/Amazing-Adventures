drop database if exists DAT602_Assessment;
create database DAT602_Assessment;
use DAT602_Assessment;    

drop procedure if exists createDB;
delimiter //
create procedure createDB()
begin

	CREATE TABLE `tbl_tile` (
	  `TileID` int NOT NULL AUTO_INCREMENT,
	  `TileLocation` int DEFAULT NULL,
	  PRIMARY KEY (`TileID`)
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
      `CharacterID` int DEFAULT NULL,
	  PRIMARY KEY (`PlayerID`)
	  );
      
    CREATE TABLE `tbl_character` (
	  `CharacterID` int NOT NULL AUTO_INCREMENT,
	  `CharacterName` varchar(15) DEFAULT NULL,
	  `CharacterColour` varchar(25) DEFAULT NULL,
      `CharacterLocation` varchar(25) DEFAULT NULL,
      `TileID` int DEFAULT NULL,
      `GameID` int DEFAULT NULL,
      `PlayerID` int DEFAULT NULL,
	  PRIMARY KEY (`CharacterID`)
	  );  
      
	CREATE TABLE `tbl_tileAsset` (
	  `tileAssetID` int NOT NULL AUTO_INCREMENT,
      `TileID` int DEFAULT NULL,
      `ItemID` int DEFAULT NULL,
	  `GameID` int DEFAULT NULL,
	  PRIMARY KEY (`tileAssetID`)
	  );        
      
	CREATE TABLE `tbl_backpack` (
	  `BackpackID` int NOT NULL AUTO_INCREMENT,
      `CharacterID` int DEFAULT NULL,
      `ItemID` int DEFAULT NULL,
	  PRIMARY KEY (`BackpackID`)
	  );        
      
	CREATE TABLE `tbl_chat` (
	  `ChatID` int NOT NULL AUTO_INCREMENT,
	  `ChatText` varchar(35) DEFAULT NULL,
	  `ChatDateTime` varchar(25) DEFAULT NULL,/*use NOW() and insert into it*/
      `PlayerID` int DEFAULT NULL,
	  PRIMARY KEY (`ChatID`)
	  );      
      
	CREATE TABLE `tbl_game` (
	  `GameID` int NOT NULL AUTO_INCREMENT,
	  `GameName` varchar(25) DEFAULT NULL,
	  `Duration` int DEFAULT 0,
      `PlayerID` int DEFAULT NULL,
	  PRIMARY KEY (`GameID`)
	  );   
      
	CREATE TABLE `tbl_item` (
	  `ItemID` int NOT NULL AUTO_INCREMENT,
	  `ItemName` varchar(25) DEFAULT NULL,
	  `ItemValue` int DEFAULT 0,
      `ItemPhoto` varchar(50) DEFAULT NULL,
	  `TileID` int DEFAULT NULL,
	  PRIMARY KEY (`ItemID`)
	  ); 
      
end //
delimiter ;   
   
CALL createDB();   

/*------------------------------------->> FOREIGN KEYS <<-------------------------------------*/

ALTER TABLE `tbl_player` ADD FOREIGN KEY (CharacterID) REFERENCES tbl_character(CharacterID);  

ALTER TABLE `tbl_character` ADD FOREIGN KEY (TileID) REFERENCES tbl_tile(TileID);    
ALTER TABLE `tbl_character` ADD FOREIGN KEY (GameID) REFERENCES tbl_game(GameID); 
ALTER TABLE `tbl_character` ADD FOREIGN KEY (PlayerID) REFERENCES tbl_player(PlayerID);  

ALTER TABLE `tbl_tileAsset` ADD FOREIGN KEY (TileID) REFERENCES tbl_tile(TileID);   
ALTER TABLE `tbl_tileAsset` ADD FOREIGN KEY (ItemID) REFERENCES tbl_item(ItemID);   
ALTER TABLE `tbl_tileAsset` ADD FOREIGN KEY (GameID) REFERENCES tbl_game(GameID);   

ALTER TABLE `tbl_backpack` ADD FOREIGN KEY (CharacterID) REFERENCES tbl_character(CharacterID);   
ALTER TABLE `tbl_backpack` ADD FOREIGN KEY (ItemID) REFERENCES tbl_item(ItemID);  

ALTER TABLE `tbl_chat` ADD FOREIGN KEY (PlayerID) REFERENCES tbl_player(PlayerID); 

ALTER TABLE `tbl_game` ADD FOREIGN KEY (PlayerID) REFERENCES tbl_player(PlayerID);   

ALTER TABLE `tbl_item` ADD FOREIGN KEY (TileID) REFERENCES tbl_tile(TileID);

/*------------------------------------->> TEST CODE <<-------------------------------------*/   

INSERT INTO `tbl_tile`(`TileLocation`)
VALUES (23);
      
insert into `tbl_item`(`ItemName`,`ItemValue`,`ItemPhoto`,`TileID`)
values ('Apple',10, 'dwjadjkwakdwkl', 2);

SELECT * from `tbl_item`;

