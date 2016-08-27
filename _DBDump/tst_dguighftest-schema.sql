-- DATABASE

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'tst_dguighftest')
BEGIN
CREATE DATABASE [tst_dguighftest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tst_abuighftest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\tst_dguighftest.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'tst_abuighftest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\tst_dguighftest_1.ldf' , SIZE = 4224KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE Latin1_General_CI_AS
END;
ALTER DATABASE [tst_dguighftest] SET COMPATIBILITY_LEVEL = 100;
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tst_dguighftest].[dbo].[sp_fulltext_database] @action = 'enable'
end;
ALTER DATABASE [tst_dguighftest] SET ANSI_NULL_DEFAULT OFF;
ALTER DATABASE [tst_dguighftest] SET ANSI_NULLS OFF;
ALTER DATABASE [tst_dguighftest] SET ANSI_PADDING OFF;
ALTER DATABASE [tst_dguighftest] SET ANSI_WARNINGS OFF;
ALTER DATABASE [tst_dguighftest] SET ARITHABORT OFF;
ALTER DATABASE [tst_dguighftest] SET AUTO_CLOSE OFF;
ALTER DATABASE [tst_dguighftest] SET AUTO_SHRINK OFF;
ALTER DATABASE [tst_dguighftest] SET AUTO_UPDATE_STATISTICS ON;
ALTER DATABASE [tst_dguighftest] SET CURSOR_CLOSE_ON_COMMIT OFF;
ALTER DATABASE [tst_dguighftest] SET CURSOR_DEFAULT  GLOBAL;
ALTER DATABASE [tst_dguighftest] SET CONCAT_NULL_YIELDS_NULL OFF;
ALTER DATABASE [tst_dguighftest] SET NUMERIC_ROUNDABORT OFF;
ALTER DATABASE [tst_dguighftest] SET QUOTED_IDENTIFIER OFF;
ALTER DATABASE [tst_dguighftest] SET RECURSIVE_TRIGGERS OFF;
ALTER DATABASE [tst_dguighftest] SET  DISABLE_BROKER;
ALTER DATABASE [tst_dguighftest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF;
ALTER DATABASE [tst_dguighftest] SET DATE_CORRELATION_OPTIMIZATION OFF;
ALTER DATABASE [tst_dguighftest] SET TRUSTWORTHY OFF;
ALTER DATABASE [tst_dguighftest] SET ALLOW_SNAPSHOT_ISOLATION OFF;
ALTER DATABASE [tst_dguighftest] SET PARAMETERIZATION SIMPLE;
ALTER DATABASE [tst_dguighftest] SET READ_COMMITTED_SNAPSHOT OFF;
ALTER DATABASE [tst_dguighftest] SET HONOR_BROKER_PRIORITY OFF;
ALTER DATABASE [tst_dguighftest] SET RECOVERY FULL;
ALTER DATABASE [tst_dguighftest] SET  MULTI_USER;
ALTER DATABASE [tst_dguighftest] SET PAGE_VERIFY CHECKSUM;
ALTER DATABASE [tst_dguighftest] SET DB_CHAINING OFF;
ALTER DATABASE [tst_dguighftest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF );
ALTER DATABASE [tst_dguighftest] SET TARGET_RECOVERY_TIME = 0 SECONDS;
ALTER AUTHORIZATION ON DATABASE::[tst_dguighftest] TO [sa];
ALTER DATABASE [tst_dguighftest] SET  READ_WRITE;
USE tst_dguighftest;
-- TABLES

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[blogs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[blogs](
	[blogs_id] [int] IDENTITY(1,1) NOT NULL,
	[blogs_title] [varchar](256) COLLATE Latin1_General_CI_AS NOT NULL,
	[blogs_description] [text] COLLATE Latin1_General_CI_AS NOT NULL,
	[blogs_date] [datetime] NOT NULL,
 CONSTRAINT [PK_blogs] PRIMARY KEY CLUSTERED 
(
	[blogs_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END;
ALTER AUTHORIZATION ON [dbo].[blogs] TO  SCHEMA OWNER;
SET ANSI_PADDING ON;
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[blogs]') AND name = N'IX_blogs_title')
CREATE UNIQUE NONCLUSTERED INDEX [IX_blogs_title] ON [dbo].[blogs]
(
	[blogs_title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY];
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[comments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[comments](
	[comments_id] [int] IDENTITY(1,1) NOT NULL,
	[posts_id] [int] NOT NULL,
	[comments_text] [text] COLLATE Latin1_General_CI_AS NOT NULL,
	[comments_username] [varchar](64) COLLATE Latin1_General_CI_AS NOT NULL,
	[comments_email] [varchar](128) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_comments] PRIMARY KEY CLUSTERED 
(
	[comments_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END;
ALTER AUTHORIZATION ON [dbo].[comments] TO  SCHEMA OWNER;
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[commentsuseful]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[commentsuseful](
	[commentsuseful_id] [int] IDENTITY(1,1) NOT NULL,
	[comments_id] [int] NOT NULL,
	[commentsuseful_points] [tinyint] NOT NULL,
 CONSTRAINT [PK_commentsuseful] PRIMARY KEY CLUSTERED 
(
	[commentsuseful_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END;
ALTER AUTHORIZATION ON [dbo].[commentsuseful] TO  SCHEMA OWNER;
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[posts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[posts](
	[posts_id] [int] IDENTITY(1,1) NOT NULL,
	[blogs_id] [int] NOT NULL,
	[posts_title] [varchar](256) COLLATE Latin1_General_CI_AS NOT NULL,
	[posts_text] [text] COLLATE Latin1_General_CI_AS NOT NULL,
	[posts_username] [varchar](64) COLLATE Latin1_General_CI_AS NOT NULL,
	[posts_email] [varchar](128) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_posts] PRIMARY KEY CLUSTERED 
(
	[posts_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END;
ALTER AUTHORIZATION ON [dbo].[posts] TO  SCHEMA OWNER;
SET ANSI_PADDING ON;
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[posts]') AND name = N'IX_posts_title')
CREATE UNIQUE NONCLUSTERED INDEX [IX_posts_title] ON [dbo].[posts]
(
	[posts_title] ASC,
	[blogs_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY];
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[postsadditionals]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[postsadditionals](
	[posts_id] [int] NOT NULL,
	[postsadditionals_note] [text] COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_postsadditionals] PRIMARY KEY CLUSTERED 
(
	[posts_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END;
ALTER AUTHORIZATION ON [dbo].[postsadditionals] TO  SCHEMA OWNER;
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[poststotags]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[poststotags](
	[posts_id] [int] NOT NULL,
	[tags_id] [int] NOT NULL,
	[poststotags_comments] [varchar](128) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_poststotags] PRIMARY KEY CLUSTERED 
(
	[posts_id] ASC,
	[tags_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END;
ALTER AUTHORIZATION ON [dbo].[poststotags] TO  SCHEMA OWNER;
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tags]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tags](
	[tags_id] [int] IDENTITY(1,1) NOT NULL,
	[tags_name] [varchar](128) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_tags] PRIMARY KEY CLUSTERED 
(
	[tags_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END;
ALTER AUTHORIZATION ON [dbo].[tags] TO  SCHEMA OWNER;
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_comments_posts]') AND parent_object_id = OBJECT_ID(N'[dbo].[comments]'))
ALTER TABLE [dbo].[comments]  WITH CHECK ADD  CONSTRAINT [FK_comments_posts] FOREIGN KEY([posts_id])
REFERENCES [dbo].[posts] ([posts_id]);
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_comments_posts]') AND parent_object_id = OBJECT_ID(N'[dbo].[comments]'))
ALTER TABLE [dbo].[comments] CHECK CONSTRAINT [FK_comments_posts];
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_commentsuseful_comments]') AND parent_object_id = OBJECT_ID(N'[dbo].[commentsuseful]'))
ALTER TABLE [dbo].[commentsuseful]  WITH CHECK ADD  CONSTRAINT [FK_commentsuseful_comments] FOREIGN KEY([comments_id])
REFERENCES [dbo].[comments] ([comments_id]);
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_commentsuseful_comments]') AND parent_object_id = OBJECT_ID(N'[dbo].[commentsuseful]'))
ALTER TABLE [dbo].[commentsuseful] CHECK CONSTRAINT [FK_commentsuseful_comments];
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_posts_blogs]') AND parent_object_id = OBJECT_ID(N'[dbo].[posts]'))
ALTER TABLE [dbo].[posts]  WITH CHECK ADD  CONSTRAINT [FK_posts_blogs] FOREIGN KEY([blogs_id])
REFERENCES [dbo].[blogs] ([blogs_id]);
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_posts_blogs]') AND parent_object_id = OBJECT_ID(N'[dbo].[posts]'))
ALTER TABLE [dbo].[posts] CHECK CONSTRAINT [FK_posts_blogs];
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_postsadditionals_posts]') AND parent_object_id = OBJECT_ID(N'[dbo].[postsadditionals]'))
ALTER TABLE [dbo].[postsadditionals]  WITH CHECK ADD  CONSTRAINT [FK_postsadditionals_posts] FOREIGN KEY([posts_id])
REFERENCES [dbo].[posts] ([posts_id]);
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_postsadditionals_posts]') AND parent_object_id = OBJECT_ID(N'[dbo].[postsadditionals]'))
ALTER TABLE [dbo].[postsadditionals] CHECK CONSTRAINT [FK_postsadditionals_posts];
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_poststotags_posts]') AND parent_object_id = OBJECT_ID(N'[dbo].[poststotags]'))
ALTER TABLE [dbo].[poststotags]  WITH CHECK ADD  CONSTRAINT [FK_poststotags_posts] FOREIGN KEY([posts_id])
REFERENCES [dbo].[posts] ([posts_id]);
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_poststotags_posts]') AND parent_object_id = OBJECT_ID(N'[dbo].[poststotags]'))
ALTER TABLE [dbo].[poststotags] CHECK CONSTRAINT [FK_poststotags_posts];
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_poststotags_tags]') AND parent_object_id = OBJECT_ID(N'[dbo].[poststotags]'))
ALTER TABLE [dbo].[poststotags]  WITH CHECK ADD  CONSTRAINT [FK_poststotags_tags] FOREIGN KEY([tags_id])
REFERENCES [dbo].[tags] ([tags_id]);
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_poststotags_tags]') AND parent_object_id = OBJECT_ID(N'[dbo].[poststotags]'))
ALTER TABLE [dbo].[poststotags] CHECK CONSTRAINT [FK_poststotags_tags];
