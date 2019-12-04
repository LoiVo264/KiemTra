CREATE TABLE [dbo].[Diems] (
    [masv]     NVARCHAR (10) NOT NULL,
    [maMonHoc] NVARCHAR (10) NOT NULL,
    [diem]     REAL          NOT NULL,
    CONSTRAINT [PK_dbo.Diems] PRIMARY KEY CLUSTERED ([masv] ASC, [maMonHoc] ASC),
    CONSTRAINT [FK_dbo.Diems_dbo.MonHocs_maMonHoc] FOREIGN KEY ([maMonHoc]) REFERENCES [dbo].[MonHocs] ([maMonHoc]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Diems_dbo.SinhViens_masv] FOREIGN KEY ([masv]) REFERENCES [dbo].[SinhViens] ([masv]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_masv]
    ON [dbo].[Diems]([masv] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_maMonHoc]
    ON [dbo].[Diems]([maMonHoc] ASC);

