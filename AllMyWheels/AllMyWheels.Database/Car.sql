CREATE TABLE [dbo].[Car]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newsequentialid(), 
    [ProducerName] NVARCHAR(70) NOT NULL, 
    [ModelName] NCHAR(70) NOT NULL, 
    [ProducedFrom] INT NULL, 
    [ProducedTo] INT NULL, 
    [Description] NVARCHAR(500) NULL
)
