CREATE TABLE [dbo].[Client]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [FullName] VARCHAR(25) NOT NULL, 
    [LoginID] VARCHAR(25) NOT NULL, 
    [Password] VARCHAR(35) NOT NULL, 
    [Address] VARCHAR(50) NULL, 
    [City] VARCHAR(15) NULL, 
    [State] VARCHAR(15) NULL, 
    [Phone] VARCHAR(15) NULL
)
