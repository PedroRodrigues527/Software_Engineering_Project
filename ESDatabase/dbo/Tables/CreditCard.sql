CREATE TABLE [dbo].[CreditCard] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Number]     INT   NOT NULL,
    [HolderName]    NVARCHAR(MAX) COLLATE Latin1_General_CS_AS NOT NULL,
    [ExpirationDate] NVARCHAR(7) NOT NULL, 
    [Pin] SMALLINT NOT NULL, 
    [Balance] DECIMAL NOT NULL, 
    CONSTRAINT [PK_CreditCard] PRIMARY KEY CLUSTERED ([ID] ASC),
);

