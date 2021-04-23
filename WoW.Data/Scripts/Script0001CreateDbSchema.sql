CREATE TABLE [Class] (
  [ClassId] int PRIMARY KEY IDENTITY(1, 1),
  [Description] varchar(100)
)
GO

CREATE TABLE [Race] (
  [RaceId] int PRIMARY KEY IDENTITY(1, 1),
  [Description] varchar(100)
)
GO

CREATE TABLE [Character] (
  [CharacterUId] uniqueidentifier PRIMARY KEY DEFAULT (NewSequentialID()),
  [Name] nvarchar(255),
  [Faction] tinyint,
  [Gender] tinyint,
  [Race] int,
  [Class] int,
  [Level] int,
  [Playtime] float,
  [Guild] uniqueidentifier
)
GO

CREATE TABLE [CharacterStatistics] (
  [CharacterStatisticsId] int PRIMARY KEY IDENTITY(1, 1),
  [CharacterUId] uniqueidentifier,
  [Intellect] float,
  [Agility] float,
  [Strength] float,
  [CriticalStrike] float,
  [Haste] float,
  [Mastery] float,
  [Versatility] float,
  [Avoidance] float,
  [Leech] float
)
GO
