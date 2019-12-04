CREATE TABLE [dbo].[SinhViens] (
    [masv]        NVARCHAR (10) NOT NULL,
    [name]        NVARCHAR (50) NOT NULL,
    [dateOfBirth] DATETIME      NOT NULL,
    [gender]      BIT           NOT NULL,
    [maLop]       NVARCHAR (10) NULL,
    CONSTRAINT [PK_dbo.SinhViens] PRIMARY KEY CLUSTERED ([masv] ASC),
    CONSTRAINT [FK_dbo.SinhViens_dbo.Lops_maLop] FOREIGN KEY ([maLop]) REFERENCES [dbo].[Lops] ([maLop])
);


GO
CREATE NONCLUSTERED INDEX [IX_maLop]
    ON [dbo].[SinhViens]([maLop] ASC);

