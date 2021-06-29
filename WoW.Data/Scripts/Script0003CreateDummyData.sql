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
INSERT INTO dbo.Class ([Description], [IsHorde], [IsAlliance])
VALUES ('Warrior', 'True', 'True')

DECLARE @warriorId int = @@identity

INSERT INTO dbo.Class ([Description], [IsHorde], [IsAlliance])
VALUES ('Priest', 'True', 'True')

DECLARE @priestId int = @@identity

INSERT INTO dbo.Class ([Description], [IsHorde], [IsAlliance])
VALUES ('Paladin', 'False', 'True')

DECLARE @paladinId int = @@identity

INSERT INTO dbo.Class ([Description], [IsHorde], [IsAlliance])
VALUES ('Rogue', 'True', 'True')

DECLARE @rogueId int = @@identity

INSERT INTO dbo.Class ([Description], [IsHorde], [IsAlliance])
VALUES ('Mage', 'True', 'True')

DECLARE @mageId int = @@identity

INSERT INTO dbo.Class ([Description], [IsHorde], [IsAlliance])
VALUES ('Warlock', 'True', 'True')

DECLARE @warlockId int = @@identity

INSERT INTO dbo.Class ([Description], [IsHorde], [IsAlliance])
VALUES ('Hunter', 'True', 'True')

DECLARE @hunterId int = @@identity

INSERT INTO dbo.Class ([Description], [IsHorde], [IsAlliance])
VALUES ('Shaman', 'True', 'False')

DECLARE @shamanId int = @@identity

INSERT INTO dbo.Class ([Description], [IsHorde], [IsAlliance])
VALUES ('Druid', 'True', 'True')

DECLARE @druidId int = @@identity

-- Insert Races

INSERT INTO dbo.Race ([Description], [FactionId])
VALUES ('Orc','0')

DECLARE @orcId int = @@identity

INSERT INTO dbo.Race ([Description], [FactionId])
VALUES ('Troll','0')

DECLARE @trollId int = @@identity

INSERT INTO dbo.Race ([Description], [FactionId])
VALUES ('Tauren','0')

DECLARE @taurenId int = @@identity

INSERT INTO dbo.Race ([Description], [FactionId])
VALUES ('Undead','0')

DECLARE @undeadId int = @@identity

INSERT INTO dbo.Race ([Description], [FactionId])
VALUES ('Human','1')

DECLARE @humanId int = @@identity

INSERT INTO dbo.Race ([Description], [FactionId])
VALUES ('Dwarf','1')

DECLARE @dwarfId int = @@identity

INSERT INTO dbo.Race ([Description], [FactionId])
VALUES ('Gnome','1')

DECLARE @gnomeId int = @@identity

INSERT INTO dbo.Race ([Description], [FactionId])
VALUES ('Night Elf','1')

DECLARE @nightelfId int = @@identity


-- Insert Classes

DECLARE @outputTableCharacterBrandonUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterBrandonUId
VALUES ('Brandon', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),1,1,@trollId,@mageId,5,0,null)

DECLARE @outputTableCharacterEckieUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterEckieUId
VALUES ('Eckie', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),0,0,@humanId,@priestId,60,0,null)

DECLARE @outputTableCharacterConstanceUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterConstanceUId
VALUES ('Constance Goodheart', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),1,0,@trollId,@mageId,12,0,null)

DECLARE @outputTableCharacterLadelleUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterLadelleUId
VALUES ('Ladelle', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),0,0,@nightElfId,@hunterId,38,0,null)

DECLARE @outputTableCharacterBartUId TABLE (characterUId UNIQUEIDENTIFIER) 

INSERT INTO dbo.[Character] ([Name], AccountUId, Faction, Gender, Race, Class, [Level], Playtime, Guild) OUTPUT Inserted.CharacterUId INTO @outputTableCharacterBartUId
VALUES ('Grand Barthollomew the Third', (SELECT AccountUId FROM @outputTableAccountUIdMAndM),0,0,@humanId,@warriorId,20,0,null)

-- Insert Character Stats

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterBrandonUId), 10, 10, 20, 10, 10, 10, 10, 10, 10)

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterEckieUId), 15, 10, 10, 10, 10, 10, 10, 10, 10)

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterConstanceUId), 12, 10, 10, 10, 10, 10, 10, 10, 10)

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterLadelleUId), 11, 10, 10, 10, 10, 10, 10, 10, 10)

INSERT INTO dbo.CharacterStatistics ([CharacterUId], Intellect, Agility, Strength, CriticalStrike, Haste, Mastery, Versatility, Avoidance, Leech)
VALUES ((SELECT characterUId FROM @outputTableCharacterBartUId), 18, 10, 10, 10, 10, 10, 10, 10, 10)

-- Insert ClassRace Combos

INSERT INTO dbo.ClassRace (RaceId, ClassId)
  VALUES ('1', '1')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('1', '4')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('1', '6')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('1', '7')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('1', '8')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('2', '1')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('2', '2')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('2', '4')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('2', '5')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('2', '7')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('2', '8')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('3', '1')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('3', '7')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('3', '8')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('3', '9')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('4', '1')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('4', '2')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('4', '4')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('4', '5')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('4', '6')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('5', '1')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('5', '2')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('5', '3')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('5', '4')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('5', '5')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('5', '6')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('6', '1')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('6', '2')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('6', '3')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('6', '4')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('6', '7')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('7', '1')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('7', '4')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('7', '5')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('7', '6')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('8', '1')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('8', '2')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('8', '4')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('8', '7')
  INSERT INTO ClassRace (RaceId, ClassId)
  VALUES ('8', '9')


