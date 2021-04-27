
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