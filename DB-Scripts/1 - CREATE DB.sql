USE [master]
GO

CREATE DATABASE [Luxoft_JMoncisbays]
CONTAINMENT = NONE
GO

ALTER DATABASE [Luxoft_JMoncisbays] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Luxoft_JMoncisbays].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO


USE [Luxoft_JMoncisbays]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Companies](
	[id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[transactionDate] [smalldatetime] NOT NULL,
	[companyId] [int] NOT NULL,
	[identifier] [varchar](10) NULL,
	[headline] [varchar](200) NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Companies] FOREIGN KEY([companyId])
REFERENCES [dbo].[Companies] ([id])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Companies]
GO
