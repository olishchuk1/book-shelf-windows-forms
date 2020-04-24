CREATE TABLE [dbo].[Publication]
(
	[type] varchar(10) NOT NULL,
	[author] varchar(25) NOT NULL,
	[name] varchar(30) NOT NULL,
	[pages] int NOT NULL,
	[price] float NOT NULL,
	[freaquency]  int DEFAULT 1,
	[number] int,
	[ganre] varchar(25)
)
