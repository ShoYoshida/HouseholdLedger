
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/05/2013 05:42:10
-- Generated from EDMX file: E:\DATA\sho\GitHub\project\HouseholdLedger\HouseholdLedger\HLD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HouseholdLedger];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Expenses'
CREATE TABLE [dbo].[Expenses] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Item] nvarchar(100)  NOT NULL,
    [Type] int  NOT NULL,
    [Amount] decimal(18,0)  NOT NULL,
    [Payee] nvarchar(100)  NOT NULL,
    [Who] nvarchar(20)  NOT NULL,
    [CreationDate] datetime  NULL,
    [UpdatedDate] datetime  NULL,
    [DelFlg] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [PK_Expenses]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------