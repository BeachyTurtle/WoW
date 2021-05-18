
CREATE PROCEDURE usp_Character_GetByUId
	@characterUId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	-- Returns a single Character by the passed in Character Guid (Guid c# datatype is equal to a uniqueidentifier sql datatype)
	SELECT 
		CharacterUId [UId],
		AccountUId,
		[Name],
		Faction,
		Gender,
		Race,
		Class,
		[Level],
		Playtime,
		Guild
	FROM [Character]
	WHERE CharacterUId = @characterUId

END
GO

CREATE PROCEDURE usp_Character_GetCharactersByClass
	@CharacterClass TINYINT
AS
BEGIN
	SET NOCOUNT ON;

	--Returns all Characters in a guild
	SELECT
		CharacterUId [UId],
		AccountUId,
		[Name]
		Faction,
		Gender,
		Race,
		Class,
		[Level],
		Playtime,
		Guild
	FROM [Character]
	WHERE Class = @CharacterClass

END
GO

CREATE PROCEDURE usp_Character_GetCharactersByRace
	@race TINYINT
AS
BEGIN
	SET NOCOUNT ON;

	--Returns all Characters in a guild
	SELECT
		CharacterUId [UId],
		AccountUId,
		[Name],
		Faction,
		Gender,
		Race,
		Class,
		[Level],
		Playtime,
		Guild
	FROM [Character]
	WHERE Race = @race

END
GO

CREATE PROCEDURE usp_Character_GetCharactersByGuild
	@guildUId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	--Returns all Characters in a guild
	SELECT
		CharacterUId [UId],
		AccountUId,
		[Name],
		Faction,
		Gender,
		Race,
		Class,
		[Level],
		Playtime,
		Guild
	FROM [Character]
	WHERE Guild = @guildUId

END
GO

CREATE PROCEDURE usp_Character_GetByName
	@name nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;

	-- Returns a single Character by the passed in Character Name
	SELECT
		CharacterUId [UId],
		AccountUId,
		[Name],
		Faction,
		Gender,
		Race,
		Class,
		[Level],
		Playtime,
		Guild
	FROM [Character]
	WHERE [Name] = @name
END
GO

CREATE PROCEDURE usp_Character_GetAll
AS
BEGIN
	SET NOCOUNT ON;

	-- Returns all characters from the Characters table
	SELECT 
		CharacterUId [UId],
		AccountUId,
		[Name],		
		Faction,
		Gender,
		Race,
		Class,
		[Level],
		Playtime,
		Guild
	FROM [Character]

END
GO

CREATE PROCEDURE usp_Character_Delete
	@characterUId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	-- Deletes a single character with the passed in characterUId
	DELETE
	FROM [Character]
	WHERE CharacterUId = @characterUId

END
GO

CREATE PROCEDURE usp_Character_Upsert
	@uId uniqueidentifier,
	@accountUId uniqueidentifier,
	@name nvarchar(255),
	@faction tinyint,
	@gender tinyint,
	@race int,
	@class int,
	@level int,
	@guild uniqueidentifier
AS
BEGIN
	SET NOCOUNT ON;

	-- Checks whether a Character exists based on the passed in UId
	-- If the character doesnt exist then the character is inserted
	-- otherwise the character is updated
	-- the final select returns the updated data
	-- because we've used Guid id's we have to use a temporary table (@guidTable)
		-- and use the output function to retreive the Guid value of the created record
	DECLARE @guidTable TABLE (characterUId uniqueidentifier)

	IF NOT EXISTS (SELECT 1 FROM dbo.[Character] WHERE CharacterUId = @uId)
		BEGIN
			-- Insert character if id not found
			INSERT INTO [Character] ([name], AccountUId, faction, gender, race, class, [level], guild) OUTPUT INSERTED.CharacterUId INTO @guidTable
			VALUES (@name, @accountUId, @faction, @gender, @race, @class, @level, @guild)
		END
	ELSE
		BEGIN
			-- Update Character
			UPDATE [Character]
			SET [name] = @name,
				AccountUId = @accountUId,
				faction = @faction,
				gender = @gender,
				race = @race,
				class = @class,
				[level] = @level,
				guild = @guild
			WHERE CharacterUId = @uId

			INSERT INTO @guidTable (characterUId)
			VALUES (@uId)
		END
		
		SELECT gt.characterUId,
			c.[name],
			c.AccountUId,
			c.faction,
			c.gender,
			c.race,
			c.class,
			c.[level],
			c.guild		
		FROM @guidTable gt
		INNER JOIN dbo.[Character] c on c.CharacterUId = gt.characterUId

END
GO

CREATE PROCEDURE [dbo].[usp_Character_GetByAccountUId]
	@accountUId uniqueidentifier
AS
BEGIN
	SET NOCOUNT ON;

	-- Returns all characters from the Characters table
	SELECT 
		CharacterUId [UId],
		AccountUId,
		[Name],		
		Faction,
		Gender,
		Race,
		Class,
		[Level],
		Playtime,
		Guild
	FROM [Character]
	WHERE AccountUId = @AccountUId

END
GO

CREATE PROCEDURE [dbo].[usp_Account_Authenticate]
	@email varchar(120),
	@password varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @accountUid uniqueidentifier

	-- SETS Local Variable AccountUId to the AccountUId of the row that matches the emailaddress and password. The email address should be a primary key to make sure that this only ever returns 1 record. 
	-- We can do this at a later point
	SELECT @accountUId = accountUId
					FROM Account
					WHERE Email = @email 
					AND [Password] = @password

	-- If the accountUId variable has a value then update the account, and return the results. If the accountUid is null, then nothing is returned.
	IF @accountUid IS NOT NULL
		BEGIN
			 UPDATE Account
			 SET LastLoginDateTime = GetDate()
			 WHERE AccountUId = @accountUid

			 SELECT a.AccountUId,
			 a.Email,
			 a.[Password],
			 a.DisplayName,
			 a.LastLoginDateTime,
			 r.[Description] [Role]
			 FROM Account a
			 LEFT JOIN [Role] r on r.RoleId = a.RoleId
			 WHERE a.AccountUId = @accountUid
		END	

END
GO

CREATE PROCEDURE usp_Account_Upsert
	@accountuId uniqueidentifier,
	@email nvarchar(255),
	@password nvarchar(255),
	@displayname nvarchar(255),
	@lastlogindatetime datetime,
	@roleId int
AS
BEGIN
	SET NOCOUNT ON;

	-- I've copy and pasted the previous upsert command and changed it to the best of my abilities to reflect an account table so the below comments are obviously not correct

	-- Checks whether a Character exists based on the passed in UId
	-- If the character doesnt exist then the character is inserted
	-- otherwise the character is updated
	-- the final select returns the updated data
	-- because we've used Guid id's we have to use a temporary table (@guidTable)
		-- and use the output function to retreive the Guid value of the created record
	DECLARE @guidTable TABLE (accountUId uniqueidentifier)

	IF NOT EXISTS (SELECT 1 FROM dbo.[Account] WHERE AccountUId = @accountuId)
		BEGIN
			-- Insert character if id not found
			INSERT INTO [Account] (email, [password], displayname, lastlogindatetime, [roleid]) OUTPUT INSERTED.AccountUId INTO @guidTable
			VALUES (@email, @password, @displayname, @lastlogindatetime, @roleid)
		END
	ELSE
		BEGIN
			-- Update Character
			UPDATE [Account]
			SET email = @email,
				[password] = @password,
				displayname = @displayname,
				lastlogindatetime = @lastlogindatetime,
				[roleid] = @roleid
			WHERE AccountUId = @accountuId

			INSERT INTO @guidTable (accountUId)
			VALUES (@accountuId)
		END
		
		SELECT gt.accountUId UId,
			a.email,
			a.[password],
			a.displayname,
			a.lastlogindatetime,
			a.[roleid]	
		FROM @guidTable gt
		INNER JOIN dbo.[Account] a on a.AccountUId = gt.accountUId

END
GO

CREATE PROCEDURE [dbo].[usp_Account_CheckExistsEmail]
	@email varchar(120)
	
AS
BEGIN
	SET NOCOUNT ON;

	IF (EXISTS (SELECT 1 FROM account WHERE Email = @email))
		BEGIN
			SELECT 1
			Email 
		END
	ELSE
			SELECT 0
		

END
GO
CREATE PROCEDURE [dbo].[usp_Account_CheckExistsDisplayName]
	@displayname varchar(120)
	
AS
BEGIN
	SET NOCOUNT ON;

	IF (EXISTS (SELECT 1 FROM account WHERE DisplayName = @displayname))
		BEGIN
			SELECT 1
			DisplayName
		END
	ELSE
			SELECT 0
		

END
GO

CREATE PROCEDURE [dbo].[usp_Account_Register]
	@displayname nvarchar(255),
	@password nvarchar(255),
	@email nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
		INSERT INTO [Account] (displayname, [password], email)
		VALUES (@displayname, @password, @email)
END
GO

CREATE PROCEDURE [dbo].[usp_Account_GetAccountByEmail]
	@email nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		AccountUId UId,
		Email,
		[Password],
		DisplayName,
		LastLoginDateTime LastLoginDate,
		RoleId Role
	FROM [Account]
	WHERE Email = @email
END
GO