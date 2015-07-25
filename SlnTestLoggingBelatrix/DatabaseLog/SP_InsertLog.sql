IF EXISTS (SELECT * FROM sysobjects WHERE name = 'InsertLogs' AND user_name(uid) = 'dbo')
    DROP PROCEDURE dbo.InsertLogs
GO

CREATE PROCEDURE dbo.InsertLogs
(
    
    @message nvarchar(600),
    @logType int
)
AS
    SET NOCOUNT OFF;
INSERT INTO [dbo].[InsertLogs] (Message, LogType)
  VALUES (@message, @logType);


GO