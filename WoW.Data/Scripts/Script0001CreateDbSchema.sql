CREATE TABLE [Class] (
  [ClassId] int PRIMARY KEY IDENTITY(1, 1),
  [Description] varchar(100),
  [IsHorde] bit,
  [IsAlliance] bit
)
GO

CREATE TABLE [Race] (
  [RaceId] int PRIMARY KEY IDENTITY(1, 1),
  [Description] varchar(100), 
  [FactionId] int
)
GO

CREATE TABLE [Character] (
  [CharacterUId] uniqueidentifier PRIMARY KEY DEFAULT (NewSequentialID()),
  [AccountUId] uniqueidentifier,
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


CREATE TABLE [Account] (
  [AccountUId] uniqueidentifier PRIMARY KEY DEFAULT (NewSequentialID()),
  [Email] varchar(120),
  [Password] varchar(50),
  [DisplayName] varchar(120),
  [LastLoginDateTime] datetime,
  [RoleId] int
)
GO

CREATE TABLE [Role] (
  [RoleId] int PRIMARY KEY IDENTITY(1, 1),
  [Description] varchar(50)
)
GO

CREATE TABLE [dbo].[ClassRace](
	[ClassRaceId] [int] IDENTITY(1,1) NOT NULL,
	[RaceId] [int] NOT NULL,
	[ClassId] [int] NOT NULL,
 CONSTRAINT [PK_ClassRace] PRIMARY KEY CLUSTERED 
(
	[ClassRaceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ClassRace]  WITH CHECK ADD  CONSTRAINT [FK_ClassRace_Class] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO

ALTER TABLE [dbo].[ClassRace] CHECK CONSTRAINT [FK_ClassRace_Class]
GO

ALTER TABLE [dbo].[ClassRace]  WITH CHECK ADD  CONSTRAINT [FK_ClassRace_Race] FOREIGN KEY([RaceId])
REFERENCES [dbo].[Race] ([RaceId])
GO

ALTER TABLE [dbo].[ClassRace] CHECK CONSTRAINT [FK_ClassRace_Race]
GO

