-- DATABASE

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'tst_dgdataconcurrencyhelper')
BEGIN
CREATE DATABASE [tst_dgdataconcurrencyhelper]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tst_dgdataconcurrencyhelper', FILENAME = N'/var/opt/mssql/data/tst_dgdataconcurrencyhelper.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tst_dgdataconcurrencyhelper_log', FILENAME = N'/var/opt/mssql/data/tst_dgdataconcurrencyhelper_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 COLLATE SQL_Latin1_General_CP1_CI_AS
END;
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tst_dgdataconcurrencyhelper].[dbo].[sp_fulltext_database] @action = 'enable'
end;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET ANSI_NULL_DEFAULT OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET ANSI_NULLS OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET ANSI_PADDING OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET ANSI_WARNINGS OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET ARITHABORT OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET AUTO_CLOSE OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET AUTO_SHRINK OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET AUTO_UPDATE_STATISTICS ON;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET CURSOR_CLOSE_ON_COMMIT OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET CURSOR_DEFAULT  GLOBAL;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET CONCAT_NULL_YIELDS_NULL OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET NUMERIC_ROUNDABORT OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET QUOTED_IDENTIFIER OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET RECURSIVE_TRIGGERS OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET  DISABLE_BROKER;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET AUTO_UPDATE_STATISTICS_ASYNC OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET DATE_CORRELATION_OPTIMIZATION OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET TRUSTWORTHY OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET ALLOW_SNAPSHOT_ISOLATION OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET PARAMETERIZATION SIMPLE;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET READ_COMMITTED_SNAPSHOT OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET HONOR_BROKER_PRIORITY OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET RECOVERY FULL;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET  MULTI_USER;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET PAGE_VERIFY CHECKSUM;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET DB_CHAINING OFF;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF );
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET TARGET_RECOVERY_TIME = 60 SECONDS;
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET DELAYED_DURABILITY = DISABLED;
ALTER AUTHORIZATION ON DATABASE::[tst_dgdataconcurrencyhelper] TO [sa];
ALTER DATABASE [tst_dgdataconcurrencyhelper] SET  READ_WRITE;
USE tst_dgdataconcurrencyhelper;
-- TABLES

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dch_concurrencyrecords]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[dch_concurrencyrecords](
	[concurrencyrecords_id] [int] IDENTITY(1,1) NOT NULL,
	[concurrencyrecords_status] [char](1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[concurrencyrecords_database] [varchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[concurrencyrecords_table] [varchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[concurrencyrecords_recordid] [varchar](1024) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[concurrencyrecords_application] [varchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[concurrencyrecords_logusername] [varchar](64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[concurrencyrecords_datetime] [datetime] NOT NULL,
 CONSTRAINT [PK_dch_concurrencyrecords] PRIMARY KEY CLUSTERED 
(
	[concurrencyrecords_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END;
ALTER AUTHORIZATION ON [dbo].[dch_concurrencyrecords] TO  SCHEMA OWNER;
