CREATE TABLE [dbo].[Log]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Message] NVARCHAR(600) NULL, 
    [LogType] INT NULL
)
