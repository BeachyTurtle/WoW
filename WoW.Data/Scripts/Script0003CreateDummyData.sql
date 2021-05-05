-- Insert Role
INSERT INTO dbo.[Role] ([Description])
VALUES ('General')

DECLARE @roleGeneralId int = @@identity

INSERT INTO dbo.[Role] ([Description])
VALUES ('Administrator')

DECLARE @roleAdministratorId int = @@identity

-- Insert Account

DECLARE @outputTableAccountUIdMAndM TABLE (AccountUId UNIQUEIDENTIFIER)

INSERT INTO dbo.Account ([Email], [Password], [DisplayName], [RoleId]) OUTPUT Inserted.AccountUId INTO @outputTableAccountUIdMAndM
VALUES ('m@m.co.uk','Passw0rd1!','MAndM',@roleGeneralId)

DECLARE @outputTableAccountUIdAnthony TABLE (AccountUId UNIQUEIDENTIFIER)

INSERT INTO dbo.Account ([Email], [Password], [DisplayName], [RoleId]) OUTPUT Inserted.AccountUId INTO @outputTableAccountUIdAnthony
VALUES ('a@a.co.uk','Passw0rd1!','Anthony Archibald', @roleAdministratorId)


-- Insert Classes
INSERT INTO dbo.Class ([Description])
VALUES ('Rogue')

DECLARE @rogueId int = @@identity

INSERT INTO dbo.Class ([Description])
VALUES ('Mage')

DECLARE @mageId int = @@identity

INSERT INTO dbo.Class ([Description])
VALUES ('Hunter')

DECLARE @hunterId int = @@identity

INSERT INTO dbo.Class ([Description])
VALUES ('Monk')

DECLARE @monkId int = @@identity

INSERT INTO dbo.Class ([Description])
VALUES ('Priest')

DECLARE @priestId int = @@identity

INSERT INTO dbo.Class ([Description])
VALUES ('Warlock')

DECLARE @warlockId int = @@identity

INSERT INTO dbo.Class ([Description])
VALUES ('Warrior')

DECLARE @warriorId int = @@identity

-- Insert Races

INSERT INTO dbo.Race ([Description])
VALUES ('Troll')

DECLARE @trollId int = @@identity

INSERT INTO dbo.Race ([Description])
VALUES ('Tauren')

DECLARE @taurenId int = @@identity

INSERT INTO dbo.Race ([Description])
VALUES ('Orc')

DECLARE @orcId int = @@identity

INSERT INTO dbo.Race ([Description])
VALUES ('Human')

DECLARE @humanId int = @@identity

INSERT INTO dbo.Race ([Description])
VALUES ('Gnome')

DECLARE @gnomeId int = @@identity

INSERT INTO dbo.Race ([Description])
VALUES ('Night Elf')

DECLARE @nightElfId int = @@identity

-- Insert Classes

DECLARE @outputTableCharacterBrandonUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterBrandonUId
VALUES ('Brandon', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),1,1,@trollId,@mageId,5,0,null)

DECLARE @outputTableCharacterEckieUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterEckieUId
VALUES ('Eckie', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),1,1,@humanId,@priestId,60,0,null)

DECLARE @outputTableCharacterConstanceUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterConstanceUId
VALUES ('Constance Goodheart', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),1,1,@trollId,@mageId,12,0,null)

DECLARE @outputTableCharacterLadelleUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterLadelleUId
VALUES ('Ladelle', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),1,1,@nightElfId,@hunterId,38,0,null)

DECLARE @outputTableCharacterBartUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterBartUId
VALUES ('Grand Barthollomew the Third', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),1,1,@humanId,@warriorId,20,0,null)

-- Insert Character Stats

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterBrandonUId), 10, 10, 20, 10, 10, 10, 10, 10, 10)

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterEckieUId), 10, 10, 10, 10, 10, 10, 10, 10, 10)

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterConstanceUId), 10, 10, 10, 10, 10, 10, 10, 10, 10)

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterLadelleUId), 10, 10, 10, 10, 10, 10, 10, 10, 10)

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterBartUId), 10, 10, 10, 10, 10, 10, 10, 10, 10)
