drop TABLE GAME;
drop TABLE USER;
drop TABLE PUBLISHER;
drop TABLE REVIEW;
drop TABLE CLUB;
drop TABLE POST;
drop TABLE PUBLISHES;
drop TABLE PURCHASES;

-- create statements

CREATE TABLE GAME
(
Game_name VARCHAR(50) NOT NULL,
Game_description VARCHAR(300),
Game_score_average INT,
Date_of_release DATE NOT NULL,
Genre VARCHAR(10),
Price DECIMAL(5,2),
PRIMARY KEY (Game_name),
CONSTRAINT chk_score CHECK(Game_score_average >= 0 AND game_score_average <= 100),
CONSTRAINT chk_price CHECK(Price >= 0.00)
);

CREATE TABLE USER
(
Username VARCHAR(15) NOT NULL,
Password VARCHAR(15) NOT NULL,
Date_joined DATE NOT NULL,
Reviewer BOOL NOT NULL,
Admin BOOL NOT NULL,
Banned BOOL NOT NULL,
Balance DECIMAL(10,2) NOT NULL,
PRIMARY KEY (Username),
CONSTRAINT chk_balance CHECK(Balance >= 0.00)
);

CREATE TABLE PUBLISHER
(
Pub_Name VARCHAR(15) NOT NULL,
Pub_Email VARCHAR(25),
Pub_Address VARCHAR(30),
Pub_Phone CHAR(10),
PRIMARY KEY (Pub_Name)
);

CREATE TABLE REVIEW
(
Review_ID INT NOT NULL,
Review_description VARCHAR(300),
Date_of_review DATE,
Review_score INT,
RGame_name VARCHAR(50),
RUsername VARCHAR(15),
PRIMARY KEY (Review_ID),
FOREIGN KEY (RUsername) REFERENCES USER(Username),
FOREIGN KEY (RGame_name) REFERENCES GAME(Game_name),
CONSTRAINT chk_reviewid CHECK(Review_ID > 0),
CONSTRAINT chk_score CHECK(Review_score >= 0)
);

CREATE TABLE CLUB
(
Club_name VARCHAR(20) NOT NULL,
Club_description VARCHAR(50),
Date_of_creation DATE NOT NULL,
PRIMARY KEY (Club_name)
);

CREATE TABLE CLUB_MEMBERS
(
CMUsername VARCHAR(15),
CMClub_name VARCHAR(20),
PRIMARY KEY (CMUsername),
FOREIGN KEY (CMUsername) REFERENCES USER(Username),
FOREIGN KEY (CMClub_name) REFERENCES CLUB(Club_name)
);

CREATE TABLE POST
(
Post_ID INT NOT NULL,
Post_description VARCHAR(300),
Date_of_post DATE NOT NULL,
PUsername VARCHAR(15),
PClub_name VARCHAR(20),
PRIMARY KEY (Post_ID),
FOREIGN KEY (PUsername) REFERENCES USER(Username),
FOREIGN KEY (PClub_name) REFERENCES CLUB(Club_name),
CONSTRAINT chk_postid CHECK(Post_ID > 0)
);

CREATE TABLE PUBLISHES
(
PUBPub_Name VARCHAR(20) NOT NULL,
PUBGame_name VARCHAR(50) NOT NULL,
PRIMARY KEY (PUBPub_Name, PUBGame_name),
FOREIGN KEY (PUBPub_Name) REFERENCES PUBLISHER(Pub_Name),
FOREIGN KEY (PUBGame_name) REFERENCES GAME(Game_name)
);

CREATE TABLE PURCHASES
(
PURUsername VARCHAR(15) NOT NULL,
PURGame_name VARCHAR(50) NOT NULL,
Date_of_purchase DATE,
PRIMARY KEY (PURUsername, PURGame_name),
FOREIGN KEY (PURUsername) REFERENCES USER (Username),
FOREIGN KEY (PURGame_name) REFERENCES GAME(Game_name)
);

-- insert statements for game

INSERT INTO GAME VALUES ('Call of Duty WWII', 'A new experience in WWII', 80, '2017-11-03', 'FPS', 59.99);
INSERT INTO GAME VALUES ('Dragonball FighterZ', 'A fighting game that features 3v3 battles', 85, '2016-01-26', 'Fighting', 59.99);
INSERT INTO GAME VALUES ('Tomb Raider', 'Explore the origin story of Lara Croft', 86, '2013-03-04', 'Action', 29.99);
INSERT INTO GAME VALUES ('Just Cause 3', 'Play as Rico Rodriguez on a Mediterranean island', 74, '2015-11-30', 'Action', 29.99);
INSERT INTO GAME VALUES ('Deus Ex: Mankind Divided', 'Adam Jensen is in a world that has begun to despise his kind', 83, '2016-08-23', 'Action', 29.99);
INSERT INTO GAME VALUES ('Final Fantasy III', 'Four heroes are on a journey to save the world', 68, '2014-05-27', 'RPG', 15.99);
INSERT INTO GAME VALUES ('Thief', 'Garrett, a Master Thief, enters into the City', 70, '2014-02-27', 'Action', 29.99);
INSERT INTO GAME VALUES ('Murdered: Soul Suspect', 'Solve the hardest case… your own murder', 59, '2014-06-03', 'Action', 29.99);
INSERT INTO GAME VALUES ('Tom Clancys Rainbow Six Siege', 'Close quarters combat and explosive action', 59, '2015-12-01', 'FPS', 39.99);
INSERT INTO GAME VALUES ('Counter-Strike: Global Offensive', 'Team-based action gameplay', 83, '2012-08-21', 'FPS', 14.99);
INSERT INTO GAME VALUES ('Far Cry 3', 'Discover and explore the secrets of an unknown island', 88, '2012-12-04', 'FPS', 19.99);
INSERT INTO GAME VALUES ('Left 4 Dead 2', 'Co-op game in a zombie apocalypse', 89, '2009-11-16', 'FPS', 19.99);
INSERT INTO GAME VALUES ('Call of Duty: Black Ops', 'Be part of an elite special forces unit in warfare', 81, '2010-11-09', 'FPS', 39.99);
INSERT INTO GAME VALUES ('Rocket League', 'Soccer and driving in one', 81, '2015-07-07', 'Racing', 19.99);
INSERT INTO GAME VALUES ('DiRT 4', 'Embrace fear in this off-road racing', 78, '2017-06-09', 'Racing', 59.99);

-- insert statements for user

INSERT INTO USER VALUES ('gd_sojin', 'kr123', '2018-01-01', True, False, False, 60.00);
INSERT INTO USER VALUES ('twiceMina', 'kr456', '2018-01-02', True, False, False, 80.00);
INSERT INTO USER VALUES ('minchen', 'password', '2018-01-01', False, True, False, 40.00);
INSERT INTO USER VALUES ('hokagedude', 'leafvillage', '2018-01-03', True, False, False, 200.00);
INSERT INTO USER VALUES ('yugi123', 'exodia', '2018-01-03', True, False, False, 10.00);

-- insert statements for publisher

INSERT INTO PUBLISHER VALUES ('Activision', 'activision@gmail.com', 'Santa Monica, CA', '8002256588');
INSERT INTO PUBLISHER VALUES ('Bandai Namco', 'bandainamco@gmail.com', 'Tokyo, Japan', '4082352222');
INSERT INTO PUBLISHER VALUES ('Square Enix', 'squareenix@gmail.com', 'Tokyo, Japan', '8587907529');
INSERT INTO PUBLISHER VALUES ('Ubisoft', 'ubisoft@gmail.com', 'San Francisco, CA', '4155474000');
INSERT INTO PUBLISHER VALUES ('Valve', 'valve@gmail.com', 'Bellevue, WA', '4258899642');
INSERT INTO PUBLISHER VALUES ('Psyonix, Inc.', 'psyonix@gmail.com', 'San Diego, CA', NULL);
INSERT INTO PUBLISHER VALUES ('Codemasters', 'codemasters@gmail.com', 'Digbeth, Birmingham', '1926816000');

-- insert statements for review

INSERT INTO REVIEW VALUES (1, 'best game ever', '2018-02-28', 90, 'Call of Duty WWII', 'gd_sojin');
INSERT INTO REVIEW VALUES (2, 'hardest game to play', '2018-01-04', 50, 'Murdered: Soul Suspect', 'gd_sojin');
INSERT INTO REVIEW VALUES (3, 'not recommend, too difficult', '2018-02-01', 40, 'Rocket League', 'twiceMina');
INSERT INTO REVIEW VALUES (4, 'easy game, easy life', '2018-02-02', 95, 'Call of Duty: Black Ops', 'twiceMina');
INSERT INTO REVIEW VALUES (5, 'i cant figure it out, too complex', '2018-02-04', 40, 'Murdered: Soul Suspect', 'twiceMina');
INSERT INTO REVIEW VALUES (6, 'the complexity is far beyond my knowledge', '2018-02-07', 55, 'Murdered: Soul Suspect', 'minchen');
INSERT INTO REVIEW VALUES (7, 'the complexity is so simple, easy game', '2018-03-07', 85, 'Far Cry 3', 'minchen');
INSERT INTO REVIEW VALUES (8, 'beat the whole game, easy', '2018-04-22', 86, 'Far Cry 3', 'hokagedude');
INSERT INTO REVIEW VALUES (9, 'good game, hate stealing', '2018-02-17', 82, 'Thief', 'hokagedude');
INSERT INTO REVIEW VALUES (10, 'this is so action pack, i love it', '2018-02-19', 92, 'Just Cause 3', 'twiceMina');
INSERT INTO REVIEW VALUES (11, 'good game, love the girl', '2018-02-14', 94, 'Tomb Raider', 'hokagedude');
INSERT INTO REVIEW VALUES (12, 'this is my kind of game and girl', '2018-01-12', 92, 'Tomb Raider', 'twiceMina');
INSERT INTO REVIEW VALUES (13, 'i wish i was like the main character', '2018-01-22', 96, 'Tomb Raider', 'gd_sojin');
INSERT INTO REVIEW VALUES (14, 'its fast paced and action packed', '2018-01-23', 86, 'Counter-Strike: Global Offensive', 'twiceMina');
INSERT INTO REVIEW VALUES (15, 'hard to adjust from other FPS games', '2018-03-12', 76, 'Counter-Strike: Global Offensive', 'gd_sojin');
INSERT INTO REVIEW VALUES (16, 'i love the characters, they are cute', '2018-02-22', 88, 'Final Fantasy III', 'gd_sojin');
INSERT INTO REVIEW VALUES (17, 'believe it, i love this game', '2018-04-22', 86, 'Final Fantasy III', 'hokagedude');
INSERT INTO REVIEW VALUES (18, 'hard to make drifts', '2018-03-22', 76, 'DiRT 4', 'gd_sojin');
INSERT INTO REVIEW VALUES (19, 'its good, cute animations', '2018-01-13', 82, 'Final Fantasy III', 'yugi123');
INSERT INTO REVIEW VALUES (20, 'had to retry so many times', '2018-01-14', 66, 'Deus Ex: Mankind Divided', 'yugi123');

-- insert statements for club

INSERT INTO CLUB VALUES ('Team KR', 'Korean gamers', '2018-03-22');
INSERT INTO CLUB VALUES ('Min Heap', null, '2018-01-13');
INSERT INTO CLUB VALUES ('Friendship', 'Friendship is magic', '2018-01-14');

-- insert statements for club members

INSERT INTO CLUB_MEMBERS VALUES ('gd_sojin', 'Team KR');
INSERT INTO CLUB_MEMBERS VALUES ('minchen', 'Min Heap');
INSERT INTO CLUB_MEMBERS VALUES ('twiceMina', 'Min Heap');
INSERT INTO CLUB_MEMBERS VALUES ('hokagedude', 'Min Heap');
INSERT INTO CLUB_MEMBERS VALUES ('yugi123', 'Friendship');

-- insert statements for post

INSERT INTO POST VALUES (1, 'annyeong', '2018-02-28', 'gd_sojin', 'Team KR');
INSERT INTO POST VALUES (2, 'new game comes out tomorrow', '2018-01-28', 'gd_sojin', 'Min Heap');
INSERT INTO POST VALUES (3, 'im new here', '2018-02-12', 'twiceMina', 'Team KR');
INSERT INTO POST VALUES (4, 'its due to time constraints', '2018-01-12', 'minchen', 'Min Heap');
INSERT INTO POST VALUES (5, 'to the shadow realm', '2018-01-08', 'yugi123', ‘Friendship’);

-- insert statements for publishes

INSERT INTO PUBLISHES VALUES ('Activision', 'Call of Duty WWII');
INSERT INTO PUBLISHES VALUES ('Bandai Namco', 'Dragonball FighterZ');
INSERT INTO PUBLISHES VALUES ('Square Enix', 'Tomb Raider');
INSERT INTO PUBLISHES VALUES ('Square Enix', 'Just Cause 3');
INSERT INTO PUBLISHES VALUES ('Square Enix', 'Deus Ex: Mankind Divided');
INSERT INTO PUBLISHES VALUES ('Square Enix', 'Final Fantasy III');
INSERT INTO PUBLISHES VALUES ('Square Enix', 'Thief');
INSERT INTO PUBLISHES VALUES ('Square Enix', 'Murdered: Soul Suspect');
INSERT INTO PUBLISHES VALUES ('Ubisoft', 'Tom Clancys Rainbow Six Siege');
INSERT INTO PUBLISHES VALUES ('Valve', 'Counter-Strike: Global Offensive');
INSERT INTO PUBLISHES VALUES ('Ubisoft', 'Far Cry 3');
INSERT INTO PUBLISHES VALUES ('Ubisoft', 'Left 4 Dead 2');
INSERT INTO PUBLISHES VALUES ('Activision', 'Call of Duty: Black Ops');
INSERT INTO PUBLISHES VALUES ('Psyonix, Inc.', 'Rocket League');
INSERT INTO PUBLISHES VALUES ('Codemasters', 'DiRT 4');

-- insert statements for purchases

INSERT INTO PURCHASES VALUES ('gd_sojin', 'Call of Duty WWII', '2018-01-03');
INSERT INTO PURCHASES VALUES ('gd_sojin', 'Murdered: Soul Suspect', '2018-01-04');
INSERT INTO PURCHASES VALUES ('gd_sojin', 'Tomb Raider', '2018-01-10');
INSERT INTO PURCHASES VALUES ('gd_sojin', 'Counter-Strike: Global Offensive', '2018-02-18');
INSERT INTO PURCHASES VALUES ('gd_sojin', 'Final Fantasy III', '2018-01-28');
INSERT INTO PURCHASES VALUES ('gd_sojin', 'DiRT 4', '2018-01-29');
INSERT INTO PURCHASES VALUES ('twiceMina', 'Rocket League', '2018-01-08');
INSERT INTO PURCHASES VALUES ('twiceMina', 'Call of Duty: Black Ops', '2018-01-06');
INSERT INTO PURCHASES VALUES ('twiceMina', 'Murdered: Soul Suspect', '2018-01-12');
INSERT INTO PURCHASES VALUES ('twiceMina', 'Just Cause 3', '2018-01-18');
INSERT INTO PURCHASES VALUES ('twiceMina', 'Tomb Raider', '2018-01-10');
INSERT INTO PURCHASES VALUES ('twiceMina', 'Counter-Strike: Global Offensive', '2018-01-09');
INSERT INTO PURCHASES VALUES ('minchen', 'Murdered: Soul Suspect', '2018-01-19');
INSERT INTO PURCHASES VALUES ('minchen', 'Far Cry 3', '2018-02-19');
INSERT INTO PURCHASES VALUES ('hokagedude', 'Far Cry 3', '2018-02-22');
INSERT INTO PURCHASES VALUES ('hokagedude', 'Thief', '2018-01-19');
INSERT INTO PURCHASES VALUES ('hokagedude', 'Tomb Raider', '2018-01-23');
INSERT INTO PURCHASES VALUES ('hokagedude', 'Final Fantasy III', '2018-01-25');
INSERT INTO PURCHASES VALUES ('yugi123', 'Final Fantasy III', '2018-01-09');
INSERT INTO PURCHASES VALUES ('yugi123', 'Deus Ex: Mankind Divided', '2018-01-07');

