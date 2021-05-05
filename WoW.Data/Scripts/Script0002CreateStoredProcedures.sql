
CREATE PROCEDURE usp_Character_GetByUId
	@characterUId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	-- Returns a single Character by the passed in Character Guid (Guid c# datatype is equal to a uniqueidentifier sql datatype)
	SELECT 
		CharacterUId,
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
		CharacterUId,
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
		CharacterUId,
		[Name]
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
		CharacterUId,
		[Name]
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
		CharacterUId,
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
		CharacterUId,
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
			INSERT INTO [Character] ([name], faction, gender, race, class, [level], guild) OUTPUT INSERTED.CharacterUId INTO @guidTable
			VALUES (@name, @faction, @gender, @race, @class, @level, @guild)
		END
	ELSE
		BEGIN
			-- Update Character
			UPDATE [Character]
			SET [name] = @name,
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

CREATE PROCEDURE usp_Account_Upsert
	@uId uniqueidentifier,
	@email nvarchar(255),
	@password nvarchar(255),
	@displayname nvarchar(255),
	@lastlogindatetime datetime,
	@isloggedin bit,
	@role varchar	
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
	DECLARE @guidTable TABLE (characterUId uniqueidentifier)

	IF NOT EXISTS (SELECT 1 FROM dbo.[Account] WHERE AccountUId = @uId)
		BEGIN
			-- Insert character if id not found
			INSERT INTO [Account] (email, [password], displayname, lastlogindatetime, isloggedin, [role]) OUTPUT INSERTED.AccountUId INTO @guidTable
			VALUES (@email, @password, @displayname, @lastlogindatetime, @isloggedin, @role)
		END
	ELSE
		BEGIN
			-- Update Character
			UPDATE [Account]
			SET email = @email,
				[password] = @password,
				displayname = @displayname,
				lastlogindatetime = @lastlogindatetime,
				isloggedin = @isloggedin,
				[role] = @role
			WHERE AccountUId = @uId

			INSERT INTO @guidTable (characterUId)
			VALUES (@uId)
		END
		
		SELECT gt.accountUId,
			a.email,
			a.[password],
			a.displayname,
			a.lastlogindatetime,
			a.isloggedin,
			a.[role]	
		FROM @guidTable gt
		INNER JOIN dbo.[Account] a on a.AccountUId = gt.accountUId

END
GO

CREATE PROCEDURE usp_Account_Delete
	@accountUId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	-- Deletes a single account with the passed in accountUId
	DELETE
	FROM [Account]
	WHERE AccountUId = @accountUId

END
GO

CREATE PROCEDURE usp_Account_GetByUId
	@accountUId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	-- Returns a single Account by the passed in Account Guid (Guid c# datatype is equal to a uniqueidentifier sql datatype)
	-- Haven't changed the fields below as you haven't actually created an account table yet and I don't want to define something you aren't happy with
	SELECT 
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

CREATE PROCEDURE usp_Account_Authenticate
	@accountUId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		AccountUId,
		Email
		[Password]
	FROM [Account]
	WHERE AccountUId = @accountUId

END
GO