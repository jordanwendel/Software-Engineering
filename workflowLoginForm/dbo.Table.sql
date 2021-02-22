CREATE TABLE [dbo].[Table]
(
	[userId] INT NOT NULL PRIMARY KEY, 
    [userName] NVARCHAR(50) NULL, 
    [userPassword] NVARCHAR(50) NULL, 
    [userRole] NCHAR(10) NULL
)
