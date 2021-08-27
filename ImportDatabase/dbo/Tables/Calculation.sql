CREATE TABLE [dbo].[Calculation] (
    [CalculationId]  INT        NOT NULL,
    [StudentId]      INT        NOT NULL,
    [IsCorrect]      BIT        NULL,
    [Operation]      NCHAR (10) NULL,
    [Number1]        NCHAR (10) NULL,
    [Number2]        NCHAR (10) NULL,
    [ExpectedResult] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([CalculationId] ASC),
    CONSTRAINT [FK_Calculation_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId])
);

