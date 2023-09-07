IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Student] (
    [StudentId] int NOT NULL IDENTITY,
    [StudentName] nvarchar(max) NOT NULL,
    [StudentClass] int NOT NULL,
    [Subject] nvarchar(max) NOT NULL,
    [TeacherId] int NOT NULL,
    [SubjectMark] int NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId])
);
GO

CREATE TABLE [Teacher] (
    [TeacherId] int NOT NULL IDENTITY,
    [TeacherName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Teacher] PRIMARY KEY ([TeacherId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230907034812_RainbowSchoolMigration', N'7.0.10');
GO

COMMIT;
GO

